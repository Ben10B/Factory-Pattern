using FactoryPattern;

namespace ClassLibrary
{
    abstract public class GUIFactory
    {
        abstract public void createButton(Component c);
        abstract public void createLabel(Component c);
        abstract public void createTextBox(Component c);
        abstract public void createListBox(Component c);
    }
}
