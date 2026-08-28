using System;
public class Desert : Food, IOrderable
{
    public Desert(string name, int prise) : base(name, prise)
    {
        FoodType = FoodType.Desert;
    }

    public override void OnCalculate()
    {

    }
}
