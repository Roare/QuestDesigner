/*
 * DAWN OF LIGHT - The first free open source DAoC server emulator
 * 
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Flobbster.Windows.Forms;
using System.Collections;
using DOL.Tools.QuestDesigner.Controls;
using System.Reflection;
using DOL.Tools.QuestDesigner.Util;
using DOL.GS.PacketHandler;
using DOL.GS;
using DOL.Tools.QuestDesigner.Exceptions;
using DOL.Tools.QuestDesigner.Converter;
using Microsoft.DirectX;

namespace DOL.Tools.QuestDesigner
{
	public partial class NPC : UserControl
	{

		View[] listViewModes = new View[] { View.Details, View.List, View.LargeIcon, View.Tile };		

		private PropertyBag npcBag;

		public NPC()
		{
			InitializeComponent();
            DB.DatabaseLoaded += new DB.DatabaseLoadedEventHandler(DB_DatabaseLoaded);
		}

        void DB_DatabaseLoaded()
        {
            foreach (DataRow npcRow in DB.NPCTable.Rows)
            {
                listViewNPC.Items.Add(generateListItem(npcRow));
            }

            DB.NPCTable.RowChanged += new DataRowChangeEventHandler(npcTable_RowChanged);
            DB.NPCTable.RowDeleting += new DataRowChangeEventHandler(npcTable_RowChanged);
            DB.NPCTable.TableCleared += new DataTableClearEventHandler(npcTable_TableCleared);

            // Configure PropertyBags
            npcBag = new PropertyBag();
            npcBag.GetValue += new PropertySpecEventHandler(this.npcBag_GetValue);
            npcBag.SetValue += new PropertySpecEventHandler(this.npcBag_SetValue);
            foreach (DataColumn col in DB.NPCTable.Columns)
            {
                npcBag.Properties.Add(getNPCProperties(col));
            }
            propertyGridNPC.SelectedObject = npcBag;
        }

		public void SetDatabaseSupport(bool support)
		{
			B_SearchNPC.Enabled = support;
		}

		void npcTable_TableCleared(object sender, DataTableClearEventArgs e)
		{
			listViewNPC.Items.Clear();
		}						

		void npcTable_RowChanged(object sender, DataRowChangeEventArgs e)
		{
			if (e.Action == DataRowAction.Add)
			{
				// add new item if none was found
				listViewNPC.Items.Add(generateListItem(e.Row));				
			}
			else if (e.Action == DataRowAction.Change)
			{
				foreach (ListViewItem item in listViewNPC.Items)
				{
					if (item.Tag == e.Row)
					{
						configureListItem(item, e.Row);
					}
				}
            }
            else if (e.Action == DataRowAction.Delete)
            {
                foreach (ListViewItem item in listViewNPC.Items)
                {
                    if (item.Tag == e.Row)
                    {
                        listViewNPC.Items.Remove(item);
                    }
                }
            }
		}

		private ListViewItem generateListItem(DataRow npcRow)
		{
			ListViewItem item = new ListViewItem();
			configureListItem(item, npcRow);
			return item;
		}
		private ListViewItem configureListItem(ListViewItem item, DataRow npcRow)
		{
			item.SubItems.Clear();
			ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
			subItem.Name ="Type";

            item.Name = Convert.ToString(npcRow[DB.COL_NPC_ID]);
            item.Text = Convert.ToString(npcRow[DB.COL_NPC_NAME]);
			item.Tag = npcRow;

            if (npcRow[DB.COL_NPC_REALM] is byte && (byte)npcRow[DB.COL_NPC_REALM] == 0)
			{
				item.ImageIndex = 1;
				item.Group = listViewNPC.Groups["LVG_Monster"];
				
				subItem.Text = "Monster";
				
			}
			else
			{
				item.ImageIndex = 0;
				item.Group = listViewNPC.Groups["LVG_NPC"];
				subItem.Text = "NPC";
			}
			
			item.SubItems.Add(subItem);
			
			return item;
		}

		private void RemoveSelectedNPCs()
		{
			foreach (ListViewItem item in listViewNPC.SelectedItems)
			{				
				DB.NPCTable.Rows.Remove((DataRow)item.Tag);				
			}
		}

		private PropertySpec getNPCProperties(DataColumn col)
		{
			PropertySpec spec = new PropertySpec(col.ColumnName, col.DataType, null, null, col.DefaultValue);
			switch (col.ColumnName)
			{
				case DB.COL_NPC_X:
                case DB.COL_NPC_Y:
                case DB.COL_NPC_Z:
				case DB.COL_NPC_HEADING:
					spec.Category = "Location";
					break;
				case DB.COL_NPC_REGION:
                    spec.ConverterTypeName = typeof(RegionConverter).FullName;
					spec.Category = "Location";
					break;
                case "RespawnInterval":
                    spec.Description = "Insert respawn value in milliseconds, 1000 = 1 second.\n-1 default respawn interval computed based on level and realm.";
                    spec.Category = "Internal";
                    break;
                case "ClassType":
				case "FactionID":
				case "Flags":
				case "MobID":				
				case "ObjectName":
					spec.Category = "Internal";
					break;
				case "Model":
				case "Size":
				case "EquipmentTemplateID":
					spec.Category = "Visual";
					break;
				case DB.COL_NPC_REALM:
                    spec.ConverterTypeName = typeof(RealmConverter).FullName;
					break;
				case "DamageType":
                    spec.ConverterTypeName = typeof(DamageTypeConverter).FullName;
					break;
			}

			return spec;
		}

		private void B_NewNPC_Click(object sender, EventArgs e)
		{
			DataRow npcRow = DB.NPCTable.NewRow();
			//			
            npcRow[DB.COL_NPC_REALM] = eRealm.Albion;
            npcRow[DB.COL_NPC_NAME] = "";			
			//
            DB.NPCTable.Rows.Add(npcRow);

            npcRow[DB.COL_NPC_NAME] = "NewNPC" + npcRow[DB.COL_NPC_ID];
            npcRow[DB.COL_NPC_OBJECTNAME] = Utils.ConvertToObjectName((string)npcRow[DB.COL_NPC_NAME]);
		}

		private void B_NewMob_Click(object sender, EventArgs e)
		{
            DataRow npcRow = DB.NPCTable.NewRow();
			//			
            npcRow[DB.COL_NPC_REALM] = eRealm.None;
            npcRow[DB.COL_NPC_NAME] = "";			
			//
            DB.NPCTable.Rows.Add(npcRow);

            npcRow[DB.COL_NPC_NAME] = "NewMob" + npcRow[DB.COL_NPC_ID];
            npcRow[DB.COL_NPC_OBJECTNAME] = Utils.ConvertToObjectName((string)npcRow[DB.COL_NPC_NAME]);
		}		

		public void npcBag_GetValue(object sender, PropertySpecEventArgs e)
		{
			if (listViewNPC.SelectedItems != null && listViewNPC.SelectedItems.Count>0)
			{
				ListViewItem item = listViewNPC.SelectedItems[0];							
				e.Value = ((DataRow)item.Tag)[e.Property.Name];				
			}
		}

		public void npcBag_SetValue(object sender, PropertySpecEventArgs e)
		{

			if (listViewNPC.SelectedItems != null && listViewNPC.SelectedItems.Count>0)
			{
				ListViewItem item = listViewNPC.SelectedItems[0];

                DataRow row = (DataRow)item.Tag;

                // little hack since the typconverter seems to be skipped if the mousewheel is used to select a value from propertygrid
                if (!row[e.Property.Name].GetType().IsAssignableFrom(e.Value.GetType()))
                {
                    TypeConverter conv = (TypeConverter)Activator.CreateInstance(Assembly.GetCallingAssembly().GetType(e.Property.ConverterTypeName));

                    Type destinationType = row.Table.Columns[e.Property.Name].DataType;

                    e.Value = conv.ConvertTo(e.Value, destinationType);
                }
                // little hackend

				row[e.Property.Name] = e.Value;
                // update objectname if name changed
                if (e.Property.Name == DB.COL_NPC_NAME)
                {
                    row[DB.COL_NPC_OBJECTNAME] = Utils.ConvertToObjectName((String)e.Value);
                }
			}
		}

		private void listViewNPC_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewNPC.SelectedItems != null && listViewNPC.SelectedItems.Count>0)
			{			
				propertyGridNPC.Enabled = true;
				propertyGridNPC.SelectedObject = npcBag;
			}
			else
				propertyGridNPC.Enabled = false;
			
		}

		private void B_ListViewTiles_Click(object sender, EventArgs e)
		{
			listViewNPC.View = View.Tile;
		}

		private void B_ListViewSymbols_Click(object sender, EventArgs e)
		{
			listViewNPC.View = View.LargeIcon;
		}

		private void B_ListViewList_Click(object sender, EventArgs e)
		{
			listViewNPC.View = View.List;
		}

		private void B_ListViewDetails_Click(object sender, EventArgs e)
		{
			listViewNPC.View = View.Details;
		}

		private void B_ToggleGroups_CheckStateChanged(object sender, EventArgs e)
		{
			listViewNPC.ShowGroups = ((ToolStripButton)sender).CheckState == CheckState.Checked;
		}		

		private void B_Delete_Click(object sender, EventArgs e)
		{
			RemoveSelectedNPCs();
		}               

		private void listViewNPC_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				RemoveSelectedNPCs();
				e.Handled = true;
			}
			else
				e.Handled = false;
		}		

		private void B_ListView_ButtonClick(object sender, EventArgs e)
		{
			View view = listViewNPC.View;
			for (int i = 0; i < listViewModes.Length; i++)
			{
				if (view == listViewModes[i])
				{
					listViewNPC.View = listViewModes[(i + 1) % listViewModes.Length];
					break;
				}
			}
		}

		private void listViewNPC_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			if (!e.CancelEdit)
			{
				ListViewItem item = listViewNPC.Items[e.Item];
				if (e.Label != null && e.Label.Length > 0)
				{
                    ((DataRow)item.Tag)[DB.COL_NPC_NAME] = e.Label;
					propertyGridNPC.SelectedObject = npcBag;
				}
			}
		}

		private void listViewNPC_ColumnClick(object sender, ColumnClickEventArgs e)
		{								
			ListViewItemComparer comp = listViewNPC.ListViewItemSorter as ListViewItemComparer;
			if (comp != null)
			{
				if (comp.Column == e.Column)
				{
					comp.Invert = !comp.Invert;
				}
				else
				{
					comp.Column = e.Column;
				}
			}
			else
			{
				comp = new ListViewItemComparer(e.Column);			
			}
			listViewNPC.ListViewItemSorter = comp;
			listViewNPC.Sort();
		}

        public void FillDataRowFromObject(Object mob)
        {
            if (mob != null) {
                DataRow row = DB.NPCTable.NewRow();
                foreach (DataColumn column in DB.NPCTable.Columns)
                {
                    try
                    {
                        String dolColumn = QuestDesignerMain.DatabaseAdapter.ConvertXMLColumnToDOLColumn(column.ColumnName);
                        PropertyInfo field = mob.GetType().GetProperty(dolColumn);
                        if (field != null)
                            row[column.ColumnName] = field.GetValue(mob, null);
                        else
                        {
                            if (dolColumn == DB.COL_NPC_OBJECTNAME || dolColumn == "AddToWorld")
                            {
                                //skipping ObjectName since it a QuestDesigner internal value.
                            }
                            else
                            {
                                throw new DOLConfigurationException("No Property found in DOL Mob object for column: " + column.ColumnName);
                            }
                        }

                    }
                    catch (DOLConfigurationException ex)
                    {
                        QuestDesignerMain.HandleException(ex);
                    }

                    // generate objectname since it doesn't exists in the dol world.
                    row[DB.COL_NPC_OBJECTNAME] = Utils.ConvertToObjectName(Convert.ToString(row[DB.COL_NPC_NAME]));
                }
                DB.NPCTable.Rows.Add(row);
            }
        }

		private void B_SearchNPC_Click(object sender, EventArgs e)
		{
			DialogResult result = QuestDesignerMain.NPCLookupForm.ShowDialog();

			if (result == DialogResult.OK)
			{				
				Object mob = QuestDesignerMain.NPCLookupForm.SelectedMob;
                FillDataRowFromObject(mob);
			}
		}

        private void pasteLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject ido = Clipboard.GetDataObject();

            if (ido.GetDataPresent(ClipboardLocation.Format.Name))
            {
                // Text data is present on the clipboard
                ClipboardLocation loc = (ClipboardLocation)ido.GetData(ClipboardLocation.Format.Name);                

                if (listViewNPC.SelectedItems != null && listViewNPC.SelectedItems.Count > 0)
                {
                    ListViewItem item = listViewNPC.SelectedItems[0];
                    ((DataRow)item.Tag)[DB.COL_NPC_X] = loc.X;
                    ((DataRow)item.Tag)[DB.COL_NPC_Y] = loc.Y;
                    ((DataRow)item.Tag)[DB.COL_NPC_Z] = loc.Z;
                    ((DataRow)item.Tag)[DB.COL_NPC_REGION] = loc.RegionID;

                    if (loc.Heading>=0)
                        ((DataRow)item.Tag)[DB.COL_NPC_HEADING] = loc.Heading;

                    propertyGridNPC.Refresh();
                }
            }
        }

        private void showOnMapToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listViewNPC.SelectedItems != null && listViewNPC.SelectedItems.Count > 0) {

                ListViewItem item = listViewNPC.SelectedItems[0];
                    

                Vector3 location = new Vector3();

                location.X = (float)Convert.ToDouble(((DataRow)item.Tag)[DB.COL_NPC_X]);
                location.Y = (float)Convert.ToDouble(((DataRow)item.Tag)[DB.COL_NPC_Y]);

                int regionID = Convert.ToInt32(((DataRow)item.Tag)[DB.COL_NPC_REGION]);
                QuestDesignerMain.DesignerForm.DXControl.ShowLocation(location, regionID);
                QuestDesignerMain.DesignerForm.ShowTab("Map Editor");
            }
        }

        private void copyLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (listViewNPC.SelectedItems != null && listViewNPC.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewNPC.SelectedItems[0];

                int x = Convert.ToInt32(((DataRow)item.Tag)[DB.COL_NPC_X]);
                int y = Convert.ToInt32(((DataRow)item.Tag)[DB.COL_NPC_Y]);
                int regionID = Convert.ToInt32(((DataRow)item.Tag)[DB.COL_NPC_REGION]);

                IDataObject ido = new DataObject();

                ClipboardLocation loc = new ClipboardLocation(x, y, regionID);

                ido.SetData(loc);
                Clipboard.SetDataObject(ido, true);
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Boolean enabled = false;
            if (listViewNPC.SelectedItems != null && listViewNPC.SelectedItems.Count > 0)
            {
                deleteToolStripMenuItem.Enabled = true;
                ListViewItem item = listViewNPC.SelectedItems[0];
                DataRow row = (DataRow)item.Tag;
                if (row[DB.COL_NPC_X] != DBNull.Value && row[DB.COL_NPC_Y] != DBNull.Value && row[DB.COL_NPC_REGION] != DBNull.Value)
                {
                    enabled = true;
                }
            }
            else
            {
                deleteToolStripMenuItem.Enabled = false;
            }
            copyLocationToolStripMenuItem.Enabled = enabled;
            showOnMapToolStripMenuItem.Enabled = enabled;

            enabled = listViewNPC.SelectedItems != null && listViewNPC.SelectedItems.Count > 0;
            IDataObject ido = Clipboard.GetDataObject();
            if (ido.GetDataPresent(ClipboardLocation.Format.Name))
            {
                enabled &= true;
            }
            else
            {
                enabled = false;
            }
            pasteLocationToolStripMenuItem.Enabled = enabled;
        }

        
		
	}
}
