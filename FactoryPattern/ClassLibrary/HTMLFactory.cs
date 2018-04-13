using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern;

namespace ClassLibrary
{
    public class HTMLFactory : GUIFactory
    {
        public override void createButton(Component c)
        {
            throw new NotImplementedException();
        }

        public override void createGUI(List<Component> c)
        {
            throw new NotImplementedException();
        }

        public override void createLabel(Component c)
        {
            throw new NotImplementedException();
        }

        public override void createListBox(Component c)
        {
            throw new NotImplementedException();
        }

        public override void createTextBox(Component c)
        {
            throw new NotImplementedException();
        }
    }
}
