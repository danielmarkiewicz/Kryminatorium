using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy_JIPP4
{
    class EclipseButton : Button
    {
        protected override void OnPaint(PaintEventArgs paint)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0,0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphics);
            base.OnPaint(paint);
        }
    }
}
