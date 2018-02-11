using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolTipTest
{
    public partial class ucDrawBoard : UserControl
    {
        private class RectangleInfo
        {
            public string Name=string.Empty;
            public Rectangle Bound=new Rectangle(0,0,25,25);
        }
        private List<RectangleInfo> m_rects = new List<RectangleInfo>();

        public ucDrawBoard()
        {
            InitializeComponent();

            InitTestRectangle();

            this.DoubleBuffered = true;
        }

        private bool m_mouseHoverMode = true;
        public bool MouseHoverMode
        {
            get 
            {
                return m_mouseHoverMode;
            }
            set
            {
                m_mouseHoverMode = value;
                this.Refresh();
            }
        }
        private void InitTestRectangle()
        {
            m_rects.Clear();
            Point pStart = new Point(10, 10);

            for (int i = 0; i < 40; i++)
            {
                if(i!=0 && i%10==0)
                {
                    pStart.X=10;
                    pStart.Y +=45;
                }
                RectangleInfo info = new RectangleInfo();
                info.Name = string.Format("矩形{0}", i + 1);
                info.Bound.Location = pStart;
                m_rects.Add(info);

                pStart.X += 45;
            }
        }

        private void ucDrawBoard_Paint(object sender, PaintEventArgs e)
        {
            foreach (RectangleInfo rect in m_rects)
            {
                e.Graphics.DrawRectangle(Pens.Red, rect.Bound);
            }
        }

        private void ucDrawBoard_MouseHover(object sender, EventArgs e)
        {
            if (!m_mouseHoverMode)
            {
                return;
            }

            Point pMouse=PointToClient(Control.MousePosition);
            if (m_rects.Any(r => r.Bound.Contains(pMouse)))
            {
                RectangleInfo info = m_rects.First(r => r.Bound.Contains(pMouse));
                tipMsg.Show(info.Name, this, info.Bound.Right, info.Bound.Bottom);
            }
            else
            {
                tipMsg.Hide(this);
            }
        }

        private void ucDrawBoard_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_mouseHoverMode)
            {
                return;
            }

            Point pMouse = e.Location;

            if (m_rects.Any(r => r.Bound.Contains(pMouse)))
            {
                if (this.Tag == null)
                {
                    RectangleInfo info = m_rects.First(r => r.Bound.Contains(pMouse));
                    tipMsg.Show(info.Name, this, info.Bound.Right, info.Bound.Bottom);
                    this.Tag = info;
                }
            }
            else
            {
                tipMsg.Hide(this);
                this.Tag=null;
            }
        }
    }
}
