using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHEditor
{
    public class JHContextTabControl : TabControl
    {
        private int IconWOrH = 16;

        public delegate void OnMouseOhterClickHandle(int selectIndex,bool IsCloseClick);
        public event OnMouseOhterClickHandle OnMouseOhterClickEvt;

        public JHContextTabControl():base()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = GetTabRect(e.Index);
            if (e.Index == this.SelectedIndex)    //当前选中的Tab页，设置不同的样式以示选中
            {
                Brush selected_color = Brushes.SteelBlue; //选中的项的背景色
                g.FillRectangle(selected_color, r); //改变选项卡标签的背景色
                string title = this.TabPages[e.Index].Text;
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X, r.Y + 5));//PointF选项卡标题的位置
                r.Offset(r.Width - IconWOrH, 2);
                //g.DrawImage(icon, new Point(r.X, r.Y));//选项卡上的图标的位置 fntTab = new System.Drawing.Font(e.Font, FontStyle.Bold);
            }
            else//非选中的
            {
                Brush selected_color = Brushes.AliceBlue; //选中的项的背景色
                g.FillRectangle(selected_color, r); //改变选项卡标签的背景色
                string title = this.TabPages[e.Index].Text + "  ";
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X, r.Y + 5));//PointF选项卡标题的位置
                r.Offset(r.Width - IconWOrH, 2);
                //g.DrawImage(icon, new Point(r.X, r.Y));//选项卡上的图标的位置
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            Point point = e.Location;
            Rectangle r = GetTabRect(this.SelectedIndex);
            r.Offset(r.Width - IconWOrH - 3, 2);
            r.Width = IconWOrH;
            r.Height = IconWOrH;
            if (r.Contains(point))
            {
                OnMouseOhterClickEvt?.Invoke(this.SelectedIndex, true);
            }
            else
            {
                OnMouseOhterClickEvt?.Invoke(this.SelectedIndex, false);
            }
            
        }

    }
}
