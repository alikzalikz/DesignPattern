namespace Starbuzz.Beverages;

public class DarkRoast : Beverage
{
    public DarkRoast(Size size)
    {
        SetSize(size);
    }
    
    public override string GetDescription()
    {
        return "Dark Roast Coffee";
    }

    public override double Cost()
    {
        return GetSize() switch
        {
            Size.SMALL => .99,
            Size.MEDIUM => 1.1,
            Size.LARGE => 1.3
        };
    }
}