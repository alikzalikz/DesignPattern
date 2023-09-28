namespace Starbuzz;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;
    
    // public string GetCost()
    // {
    //     return beverage.GetDescription() + " $" + beverage.Cost();
    // }
}
