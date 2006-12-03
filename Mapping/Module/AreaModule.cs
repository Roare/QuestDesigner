using System;
using System.Collections.Generic;
using System.Text;
using DOL.Tools.Mapping.Modules;
using DOL.Tools.Mapping.Map;
using System.Collections;
using System.Data;
using DOL.Tools.Mapping.DX;
using DOL.Tools.QuestDesigner.Util;
using System.Windows.Forms;
using Microsoft.DirectX;
using System.Drawing;
using DOL.Tools.QuestDesigner;

namespace DOL.Tools.Mapping.Modules
{
    [Modul("Area", true, true)]
    public class AreaModule : AbstractDataRowModule
    {

        private DataRowChangeEventHandler areaTableEventHandler;

        public override void Load()
        {            
            areaTableEventHandler = new DataRowChangeEventHandler(AreaTable_RowChanged);
            DB.AreaTable.RowChanged += areaTableEventHandler;
        }

        public override void Unload()
        {
            DB.LocationTable.RowChanged -= areaTableEventHandler;
            areaTableEventHandler = null;
        }
        public override void Activate()
        {
        }
        public override void Deactivate()
        {
        }

        public override void RegionLoad(RegionMgr.Region region)
        {
            ClearObjectRowMapping();

            // load locations
            DataRow[] areas = DB.AreaTable.Select("RegionID=" + RegionMgr.CurrentRegion.ID);
            foreach (DataRow area in areas)
            {
                AddArea(area);
            }
        }

        public override void RegionUnload(RegionMgr.Region region)
        {
        }

        public override void DXClick(MouseEventArgs e)
        {
        }

        public override void ObjectMoved(IMapObject obj)
        {
        }

        public override IMapObject GetObjectAt(int x, int y)
        {
            return null;
        }

        public override ArrayList GetObjects()
        {
            return base.GetObjects();
        }

        public override void ClearDirty()
        {
            
        }

        public override void Filter(ModulMgr.ModulObj mod)
        {
            foreach (GeometryObj obj in GetObjects())
            {
                Objects.Remove(obj);
            }
        }

        public override void Unfilter(ModulMgr.ModulObj mod)
        {
            foreach (GeometryObj obj in GetObjects())
            {
                Objects.Add(obj);
            }
        }

        public override Form GetPropertyForm()
        {
            return null;
        }

        private GeometryObj AddArea(DataRow areaRow)
        {
            float x = (float)Convert.ToDouble(areaRow["X"]);
            float y = (float)Convert.ToDouble(areaRow["Y"]);

            float r = areaRow["R"] == DBNull.Value ? 0 : (float)Convert.ToDouble(areaRow["R"]);

            GeometryObj obj = null;
            if (x > 0 || y > 0)
            {
                Vector2 nextpoint = new Vector2(r, r);

                Color color = Color.FromArgb(100, Color.Orange);
                DOL.Tools.Mapping.DX.Meshes.Rectangle rect = new DOL.Tools.Mapping.DX.Meshes.Rectangle(Common.Device, nextpoint, color);
                Model mod = new Model(rect, null);
                obj = new GeometryObj(mod, DrawLevel.Middle, DetailLevel.MoreDetailed, x, y, 0, 0, 0, 0, new Vector3(1, 1, 1));

                Objects.Add(obj);
                SetObjectForRow(areaRow, obj);
            }
            return obj;
        }

        private void AreaTable_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            DataRow areaRow = e.Row;
            if (RegionMgr.CurrentRegion != null && areaRow["RegionID"] is int && (int)areaRow["RegionID"] == RegionMgr.CurrentRegion.ID)
            {
                if (e.Action == DataRowAction.Add)
                {
                    GeometryObj obj = AddArea(areaRow);
                }
                else if (e.Action == DataRowAction.Delete)
                {
                    GeometryObj obj = GetObjectForRow(areaRow);
                    if (obj != null)
                        Objects.Remove(obj);

                    RemoveObjectForRow(areaRow);
                }
                else if (e.Action == DataRowAction.Change)
                {
                    float x = (float)Convert.ToDouble(areaRow["X"]);
                    float y = (float)Convert.ToDouble(areaRow["Y"]);



                    GeometryObj obj = GetObjectForRow(areaRow);
                    if (obj != null)
                        Objects.Remove(obj);

                    // since the radius etc can change be havto create a new object from scratch
                    AddArea(areaRow);

                }
                QuestDesignerMain.DesignerForm.DXControl.Invalidate();
            }
        }

    }
}
