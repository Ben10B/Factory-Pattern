using System;
using System.Collections.Generic;
using FactoryPattern;
using ClassLibrary.Models;

namespace ClassLibrary
{
    public class CSharpFactory : GUIFactory
    {
        public string finalGUI = "";
        public override void createGUI(List<Component> c)
        {
            foreach(Component comp in c)
            {
                switch (comp.type)
                {
                    case GUIType.Button:
                        createButton(comp);
                        break;
                    case GUIType.TextBox:
                        createTextBox(comp);
                        break;
                    case GUIType.Label:
                        createLabel(comp);
                        break;
                    case GUIType.ListBox:
                        createListBox(comp);
                        break;
                }
            }
        }

        public override void createButton(Component c)
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
