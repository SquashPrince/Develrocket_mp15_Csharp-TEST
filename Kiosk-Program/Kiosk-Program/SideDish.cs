using System;

public class SideDish : Food
{
    public SideDish(string name, int prise) : base(name, prise)
    {
        FoodType = FoodType.SideDish;
    }
}
