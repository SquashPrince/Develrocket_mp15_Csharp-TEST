using System;

public class Burger : Food, IOrderable, IToppingable
{
    public Dictionary<Topping, int> toppings = new Dictionary<Topping, int>();

    public Burger(string name, int prise) : base(name, prise)
    {
        FoodType = FoodType.Burger;
    }

    public void AddTopping(Topping topping, int count)
    {
        toppings.Add(topping, count);
    }

    public override int OnCalculate(int addAmount)
    {
        return Prise + addAmount;
    }
}
