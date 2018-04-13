﻿using System;
using System.Collections.Generic;
using GUIWriterLibrary.Models;
using FactoryPattern;
using System.IO;

namespace GUIWriterLibrary
{
    public class CSharpFactory : GUIFactory
    {
        public string finalGUI = "<Window x:Class='tobedeleted.MainWindow'\n" +
        "xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'\n" +
        "xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'\n" +
        "xmlns:d='http://schemas.microsoft.com/expression/blend/2008'\n" +
        "xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006'\n" +
        "mc:Ignorable='d'\n" +
        "Title='MainWindow' Height='350' Width='525'>\n" +
        "<Canvas>\n";
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
            finalGUI += "</Canvas>";

            File.WriteAllText("../../../TestingFile.txt", finalGUI);
        }

        public override void createButton(Component c)
        {
            finalGUI += $"<Button Canvas.Left={c.xOffest} Canvas.Top={c.yOffset} Height={c.height} Width={c.width}>{c.text}</Button>\n";
        }

        public override void createLabel(Component c)
        {
            finalGUI += $"<Label Canvas.Left={c.xOffest} Canvas.Top={c.yOffset} Height={c.height} Width={c.width}>{c.text}</Label>\n";
        }

        public override void createListBox(Component c)
        {
            finalGUI += $"<ListBox Canvas.Left={c.xOffest} Canvas.Top={c.yOffset} Height={c.height} Width={c.width}>{c.text}</ListBox>\n";
        }

        public override void createTextBox(Component c)
        {
            finalGUI += $"<TextBox Canvas.Left={c.xOffest} Canvas.Top={c.yOffset} Height={c.height} Width={c.width}>{c.text}</TextBox>\n";
        }
    }
}
