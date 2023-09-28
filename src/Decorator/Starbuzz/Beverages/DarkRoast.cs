namespace Starbuzz.Beverages;

public class DarkRoast : Beverage
{
    public override string GetDescription()
    {
        return "Dark Roast Coffee";
    }

    public override double Cost()
    {
        return .99;
    }
}