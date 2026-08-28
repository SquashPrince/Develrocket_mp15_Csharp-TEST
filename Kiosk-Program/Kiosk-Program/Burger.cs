using System;

public class Burger : Food, IOrderable, IToppingable
{
    public Burger(string name, int prise) : base(name, prise)
    {
        FoodType = FoodType.Burger;
    }

    public override void OnCalculate()
    {

    }
}
