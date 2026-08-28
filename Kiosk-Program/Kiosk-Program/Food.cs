using System;

public enum FoodType
{
    None,
    Burger,
    Drink,
    Desert,
    SideDish,
    Topping
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

    private FoodType _foodType;
    public FoodType FoodType
    {
        get { return _foodType; }
        protected set { _foodType = value; }
    }
    public string PrintFoodType()
    {
        string typeStr = "잘못된 입력입니다.";

        switch(FoodType)
        {
            case FoodType.Burger:
                typeStr = "버거";
                break;

            case FoodType.Drink:
                typeStr = "음료";
                break;

            case FoodType.Desert:
                typeStr = "디저트";
                break;

            case FoodType.SideDish:
                typeStr = "사이드";
                break;
        }

        return typeStr;
    }

    public Food(string name, int prose)
    {
        Name = name;
        Prise = prose;
    }

    public virtual int OnCalculate(int addAmount) { return 0; }
}
