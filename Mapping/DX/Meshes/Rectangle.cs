using System;
using System.Drawing;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace DOL.Tools.Mapping.DX.Meshes
{
    public class Rectangle : AbstractMesh, IMesh
    {
        private Vector2 m_EndPoint;
        private Color m_Color;

        //Indicies are constant and shouldn't be editet--
        private static readonly short[] indices = {
                                                      0, 1, 3, // Top Left
                                                      2, 3, 1 // BottomRight	
                                                  };

        public Vector2 EndPoint
        {
            get { return m_EndPoint; }
            set
            {
                m_EndPoint = value;
                FillVB(VB, null);
            }
        }

        public Color Color
        {
            get { return m_Color; }
            set { m_Color = value; }
        }

        public Rectangle(Device device, Vector2 endpoint, Color color) : base(device)
        {
            m_EndPoint = endpoint;
            m_Color = color;

            VB =
                new VertexBuffer(typeof (CustomVertex.PositionColored), 5, Device, Usage.Dynamic | Usage.WriteOnly,
                                 CustomVertex.PositionColored.Format, Pool.Default);
            IB = new IndexBuffer(typeof (short), 6, device, Usage.WriteOnly, Pool.Default);

            VB.Created += new EventHandler(FillVB);
            IB.Created += new EventHandler(FillIB);

            FillVB(VB, null);
            FillIB(IB, null);
        }


        public void Render()
        {
            Device.SetStreamSource(0, VB, 0);
            Device.Indices = IB;
            Device.VertexFormat = CustomVertex.PositionColored.Format;
            Device.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, 5, 0, 5);
        }

        public void Dispose()
        {
            if (!Disposed)
            {
                VB.Dispose();
                IB.Dispose();
                m_Disposed = true;
            }
        }

        private void FillVB(object sender, EventArgs e)
        {
            lock (sender)
            {
                CustomVertex.PositionColored[] verts = new CustomVertex.PositionColored[5];

                verts[0] = new CustomVertex.PositionColored(0.0f, -EndPoint.Y, 0.0f, m_Color.ToArgb());
                verts[1] = new CustomVertex.PositionColored(0.0f, 0.0f, 0.0f, m_Color.ToArgb());
                verts[2] = new CustomVertex.PositionColored(EndPoint.X, 0.0f, 0.0f, m_Color.ToArgb());
                verts[3] = new CustomVertex.PositionColored(EndPoint.X, -EndPoint.Y, 0.0f, m_Color.ToArgb());                
                //Negate Y..

                ((VertexBuffer) sender).SetData(verts, 0, LockFlags.None);
            }
        }

        private void FillIB(object sender, EventArgs e)
        {
            lock (sender)
            {
                ((IndexBuffer) sender).SetData(indices, 0, LockFlags.None);
            }
        }
    }
}