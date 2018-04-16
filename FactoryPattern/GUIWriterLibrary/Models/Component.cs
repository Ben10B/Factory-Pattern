using GUIWriterLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIWriterLibrary
{
    public abstract class Component
    {
        public Component(GUIType g, string t, double h, double w, double x, double y)
        {
            this.type = g;
            this.text = t;
            this.height = h;
            this.width = w;
            this.xOffest = x;
            this.yOffset = y;
        }

        public GUIType type { get; set; }
        public string text { get; set; }
        public double height { get; set; }
        public double width { get; set; }
        public double xOffest { get; set; }
        public double yOffset { get; set; }

        public override string ToString()
        {
            return $"{type} (H: {height}, W: {width}, X: {xOffest}, Y: {yOffset})";
        }
    }
}
