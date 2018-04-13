using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern;

namespace ClassLibrary
{
    public class HTMLFactory : GUIFactory
    {
        public override double setHeight(Component c)
        {
            return c.height;
        }

        public override string setText(Component c)
        {
            return c.text;
        }

        public override double setWidth(Component c)
        {
            return c.width;
        }

        public override double setXPos(Component c)
        {
            return c.xOffest;
        }

        public override double setYPos(Component c)
        {
            return c.yOffset;
        }
    }
}
