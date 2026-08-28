using System;

public enum FoodType
{
    None,
    Burger,
    Drink,
    Desert
}

public abstract class Food : ICalculatable
{
    private string _name = "";

    public string Name
    {
        get { return _name; }
        protected set { _name = value; }
    }

    private int _prise;

    public int Prise
    {
        get { return _prise; }
        protected set { _prise = value; }
    }

    public Food(string name, int prose)
    {
        Name = name;
        Prise = prose;
    }

    public virtual void OnCalculate() { }
}
