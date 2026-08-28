using System;
public class Drink : Food
{
    public Drink(string name, int prise) : base(name, prise)
    {
        FoodType = FoodType.Drink;
    }
}
