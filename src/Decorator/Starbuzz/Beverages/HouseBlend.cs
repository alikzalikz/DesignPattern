namespace Starbuzz.Beverages;

public class HouseBlend : Beverage
{
    public HouseBlend(Size size)
    {
        SetSize(size);
    }
    public override string GetDescription()
    {
        return "House Blend Coffee";
    }

    public override double Cost()
    {
        return GetSize() switch
        {
            Size.SMALL => .89,
            Size.MEDIUM => 1,
            Size.LARGE => 1.2
        };
    }
}