using System;

public class SideDish : Food, IOrderable
{
    public SideDish(string name, int prise) : base(name, prise)
    {
        FoodType = FoodType.SideDish;
    }

    public override int OnCalculate(int addAmount)
    {
        return Prise + addAmount;
    }
}
