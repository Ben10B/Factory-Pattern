using System.Collections.Generic;

namespace GUIWriterLibrary
{
    abstract public class GUIFactory
    {
        abstract public void createGUI(List<Component> c);
        abstract public void createButton(Component c);
        abstract public void createLabel(Component c);
        abstract public void createTextBox(Component c);
        abstract public void createListBox(Component c);
    }
}
