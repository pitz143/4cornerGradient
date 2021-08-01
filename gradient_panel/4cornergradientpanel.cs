using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace gradient_panel
{
    public class _4cornergradientpanel : Panel //we can make four corner gradient using path gradient
    {
        public Color GTopLeft { get; set; } = Color.Transparent;//times 4 for 4 corner
        public Color GTopRight { get; set; } = Color.Transparent;
        public Color GBottomLeft { get; set; } = Color.Transparent;
        public Color GBottomRight { get; set; } = Color.Transparent;//to avoid front color foreground color mixxing with actual gradient.

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var colorArray = new Color[] { GTopLeft, GTopRight, GBottomRight, GBottomLeft };//array in circular form
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(this.ClientRectangle);

            Graphics graphics = e.Graphics;
            using (PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath)
            {
                CenterColor = Color.FromArgb((int)colorArray.Average(a => a.R), (int)colorArray.Average(a => a.G), (int)colorArray.Average(a => a.B)),
                SurroundColors = colorArray
            })
            {
                graphics.FillPath(pathGradientBrush, graphicsPath);
            }//cool huh!
        }
    }
}
