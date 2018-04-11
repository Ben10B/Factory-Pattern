using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FactoryPattern
{
    public class Component
    {
        public Component(double h, double w, double x, double y)
        {
            this.height = h;
            this.width = w;
            this.xOffest = x;
            this.yOffset = y;
        }

        public double height { get; set; }
        public double width { get; set; }
        public double xOffest { get; set; }
        public double yOffset { get; set; }

        public override string ToString()
        {
            return $"Component (H: {height}, W: {width}, X: {xOffest}, Y: {yOffset})";
        }
    }
}
