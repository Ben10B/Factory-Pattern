using FactoryPattern;

namespace ClassLibrary
{
    abstract public class GUIFactory
    {
        abstract public void setText(Component c);
        abstract public void setHeight(Component c);
        abstract public void setWidth(Component c);
        abstract public void setXPos(Component c);
        abstract public void setYPos(Component c);
    }
}
