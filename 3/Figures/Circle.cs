using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle : Ellipse
    {
        public Circle(int id, int x, int y, int r) : base(id, x, y, r, r)
        { }
        public override string Name
        { get { return "Окружность " + this.id.ToString(); } }
    }
}
