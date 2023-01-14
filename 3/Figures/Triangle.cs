using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{ 
    public class Triangle : Polygon
    {
        public Triangle(int id, Point[] points) : base(id, points)
        { }
        public override string Name
        { get { return "Треугольник " + this.id.ToString(); } }
    }
}
