using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square : Rectangle
    {
        public Matrix matrix = new Matrix();
        public Square(int id, int x, int y, int w, string name = "Квадрат") : base(id, x, y, w, w, name)
        { }
        public override string Name
        { get { return "Квадрат " + this.id.ToString(); } }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Transform = matrix;
            g.DrawRectangle(Init.pen, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
    }
}
