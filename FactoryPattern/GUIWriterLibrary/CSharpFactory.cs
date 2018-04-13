using System;
using System.Collections.Generic;
using GUIWriterLibrary.Models;
using FactoryPattern;

namespace GUIWriterLibrary
{
    public class CSharpFactory : GUIFactory
    {
        public string finalGUI = "<Window x:Class='tobedeleted.MainWindow' xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' " +
        "xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml' " +
        "xmlns:d='http://schemas.microsoft.com/expression/blend/2008' " +
        "xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' " +
        "mc:Ignorable='d' " +
        "Title='MainWindow' Height='350' Width='525'>" +
        "<Canvas>";
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
            finalGUI += $"<Button Canvas.Left={c.xOffest} Canvas.Top={c.yOffset} Height={c.height} Width={c.width}>{c.text}</Button>";
        }

        public override void createLabel(Component c)
        {
            finalGUI += $"<Label Canvas.Left={c.xOffest} Canvas.Top={c.yOffset} Height={c.height} Width={c.width}>{c.text}</Label>";
        }

        public override void createListBox(Component c)
        {
            finalGUI += $"<ListBox Canvas.Left={c.xOffest} Canvas.Top={c.yOffset} Height={c.height} Width={c.width}>{c.text}</ListBox>";
        }

        public override void createTextBox(Component c)
        {
            finalGUI += $"<TextBox Canvas.Left={c.xOffest} Canvas.Top={c.yOffset} Height={c.height} Width={c.width}>{c.text}</TextBox>";
        }
    }
}
