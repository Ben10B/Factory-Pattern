using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIWriterLibrary.Models
{
    public class ListBoxFactory : ComponentFactory
    {
        public override Component createComponent(GUIType g, string t, double h, double w, double x, double y)
        {
            return new ListBox(g, t, h, w, x, y);
        }
    }
}
