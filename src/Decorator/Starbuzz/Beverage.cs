namespace Starbuzz;
public abstract class Beverage
{
    public enum Size { SMALL, MEDIUM, LARGE }

    private Size _size = Size.SMALL;

    public void SetSize(Size size)
    {
        _size = size;
    }

    public Size GetSize()
    {
        return _size;
    }
    
    public abstract string GetDescription();

    public abstract double Cost();
}
