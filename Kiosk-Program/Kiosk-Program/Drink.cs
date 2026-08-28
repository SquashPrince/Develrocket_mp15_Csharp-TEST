using System;
public class Drink : Food, IOrderable
{
    public Drink(string name, int prise) : base(name, prise)
    {
        FoodType = FoodType.Drink;
    }

    public override int OnCalculate(int addAmount)
    {
        return Prise + addAmount;
    }
}
