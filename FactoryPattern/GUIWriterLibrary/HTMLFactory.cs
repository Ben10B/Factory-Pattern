using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern;
using GUIWriterLibrary.Models;
using System.IO;

namespace GUIWriterLibrary
{
    public class HTMLFactory : GUIFactory
    {
        private string htmlOpening = "<!doctype html>\n<html>\n<head></head>\n<body>";
        private string htmlClosing = "</body>\n</html>";
        public override void createButton(Component c)
        {
            string btn = "<button type='button' " +
                "style='position: absolute;" +
                        "width:" + c.width + ";" +
                        "height:" + c.height + ";" +
                        "top:" + c.xOffest + ";" +
                        "left:" + c.xOffest + "'>" + c.text + "</button>";
            htmlOpening += btn;
        }

        public override void createGUI(List<Component> c)
        {
            foreach (Component comp in c)
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
            htmlOpening += htmlClosing;

            File.WriteAllText("test.html", htmlOpening);
        }

        public override void createLabel(Component c)
        {
            string label = "<div" +
                "style='position: absolute;" +
                        "width:" + c.width + ";" +
                        "height:" + c.height + ";" +
                        "top:" + c.xOffest + ";" +
                        "left:" + c.xOffest + "'>" + c.text + "</div>";
            htmlOpening += label;
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
