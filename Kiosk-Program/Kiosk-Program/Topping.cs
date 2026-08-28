using System;

internal class Topping : Food
{
    public Topping(string name, int prise) : base  (name, prise)
    {
        FoodType = FoodType.Topping;
    }

    public override void OnCalculate()
    {

    }
}
