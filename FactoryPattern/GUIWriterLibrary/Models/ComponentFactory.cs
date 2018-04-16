using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIWriterLibrary.Models
{
    public abstract class ComponentFactory
    {
        public abstract Component createComponent(GUIType g, string t, double h, double w, double x, double y);
    }
}
