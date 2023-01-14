using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle : Figure
    {
        public Rectangle(int id, int x, int y, int w, int h, string name = "Прямоугольник") : base(id, x, y)
        {
            this.w = w;
            this.h = h;
            this.n_name = name;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override string Name
            { get { return "Прямоугольник " + this.id.ToString(); } }
    }
}
