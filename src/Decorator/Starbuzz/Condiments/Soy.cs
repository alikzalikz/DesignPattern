﻿namespace Starbuzz.Condiments;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Soy";
    }

    public override double Cost()
    {
        return beverage.Cost() + .30;
    }
}