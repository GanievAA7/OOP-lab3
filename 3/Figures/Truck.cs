using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Truck : Rectangle
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public Rectangle r1;
        public Rectangle r2;
        public Square sq1;
        public Square sq2;
        public Circle circle1;
        public Circle circle2;
        public Triangle triangle1;
        public List<Figure> figures;
        public Truck(int id, int x, int y, int w, int h) : base(id, x, y, w, h)
        {
            figures = new List<Figure>();
            r1 = new Rectangle(0, x, y + 60, 100, 60);
            r2 = new Rectangle(0, x + 105, y + 20, 50, 100);
            sq1 = new Square(0, x + 115, y + 35, 25);
            sq2 = new Square(0, x + 160, y + 70, 50);
            circle1 = new Circle(0, x + 10, y + 126, 25);
            circle2 = new Circle(0, x + 130, y + 126, 25);
            Point point1 = new Point(x, y + 55);
            Point point2 = new Point(x + 50, y);
            Point point3 = new Point(x + 100, y + 55);
            Point[] tri_points = { point1, point2, point3 };
            triangle1 = new Triangle(0, tri_points);
            Figure[] fs = { r1, r2, sq1, sq2, circle1, circle2, triangle1 };
            figures.AddRange(fs);
        }

        public override void Draw()
        {
            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        Init.pen.Color = Color.Maroon;
                        r1.Draw();
                        break;
                    case 1:
                        Init.pen.Color = Color.MediumSeaGreen;
                        r2.Draw();
                        break;
                    case 2:
                        Init.pen.Color = Color.Crimson;
                        sq1.Draw();
                        break;
                    case 3:
                        Init.pen.Color = Color.SteelBlue;
                        sq2.Draw();
                        break;
                    case 4:
                        Init.pen.Color = Color.SaddleBrown;
                        circle1.Draw();
                        break;
                    case 5:
                        Init.pen.Color = Color.SaddleBrown;
                        circle2.Draw();
                        break;
                    case 6:
                        Init.pen.Color = Color.Khaki;
                        triangle1.Draw();
                        break;
                }
            }
            Init.pen.Color = Color.Black;
        }
        public override void MoveTo(int x, int y)
        {
            Init.Clear();
            this.x += x;
            this.y += y;
            for (int i = 0; i < 7; i++)
            {
                Figure figure = figures[i];
                if (figure.points != null)
                {
                    for (int j = 0; j < figure.points.Length; j++)
                    {
                        figure.points[j].X += x;
                        figure.points[j].Y += y;
                    }
                    figure.x = figure.points[0].X;
                    figure.y = figure.points[0].Y;
                }
                else
                {
                    figure.x += x;
                    figure.y += y;
                }
                
            }
            this.Draw();
            foreach (Figure f in ShapeContainer.figureList)
            {
                f.Draw();
            }
        }
        public override string Name
        { get { return "Машина " + this.id.ToString(); } }
    }
}
