using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract public class Figure
    {
        public int x;
        public int y;
        public int w;
        public int h;

        public string n_name = "Фигура";
        public int id;
        public Point[] points;
        public Figure(int id, int x, int y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
        }
        abstract public void Draw();
        virtual public void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;
            this.DeleteF(this, false);
            this.Draw();
        }
        public void DeleteF(Figure figure, bool flag = true)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            ShapeContainer.figureList.Remove(figure);
            Init.Clear();
            Init.pictureBox.Image = Init.bitmap;
            foreach (Figure f in ShapeContainer.figureList)
            {
                f.Draw();
            }
            if (flag == false)
            {
                ShapeContainer.figureList.Add(figure);
            }
        }
        public virtual string Name
        {
            get;
        }
    }
}
