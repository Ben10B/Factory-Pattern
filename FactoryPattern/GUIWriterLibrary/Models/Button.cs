using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIWriterLibrary.Models
{
    public class Button : Component
    {
        public Button(GUIType g, string t, double h, double w, double x, double y) : base(g, t, h, w, x, y)
        {
            this.type = g;
            this.text = t;
            this.height = h;
            this.width = w;
            this.xOffest = x;
            this.yOffset = y;
        }
    }
}
