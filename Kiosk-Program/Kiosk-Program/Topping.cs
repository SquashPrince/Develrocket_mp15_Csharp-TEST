using System;

public enum ToppingType
{
    Tomato,
    Egg,
    Patty,
    Lattuce
}

public class Topping : Food
{
    private ToppingType _toppingType;

    public ToppingType ToppingType
    {
        get {  return _toppingType; }

        set { _toppingType = value; }
    }

    public Topping(string name, int prise, ToppingType toppingType) : base  (name, prise)
    {
        FoodType = FoodType.Topping;
        ToppingType = toppingType;
    }

    public override int OnCalculate(int addAmount)
    {
        return Prise + addAmount;
    }
}
