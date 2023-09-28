namespace Starbuzz.Beverages;

public class Espresso : Beverage
{
    public Espresso(Size size)
    {
        SetSize(size);
    }
    
    public override string GetDescription()
    {
        return "Espresso";
    }

    public override double Cost()
    {
        return GetSize() switch
        {
            Size.SMALL => 1.99,
            Size.MEDIUM => 2.1,
            Size.LARGE => 2.2
        };
    }
}