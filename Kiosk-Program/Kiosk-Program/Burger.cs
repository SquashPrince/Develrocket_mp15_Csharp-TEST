using System;

public class Burger : Food, IOrderable, IToppingable, ICalculatable, ISalable
{
    private int[] _saleValue = new int[2];

    public int[] SaleValue
    {
        get
        {
            return _saleValue;
        }
        protected set
        {
            _saleValue = value;
        }
    }

    public Burger(string name, int prise, int[] saleValue) : base(name, prise)
    {
        SaleValue = saleValue;
        FoodType = FoodType.Burger;
    }

    public string PrintSalePoint()
    {
        return $"{SaleValue[0]}개 이상 구매시 {SaleValue[1]}% 할인";
    }

    public int OnCalculate(int addAmount)
    {
        if (addAmount >= SaleValue[0])
        {
            return (Prise * (100 - SaleValue[1]) / 100);
        }

        return Prise;
    }
}
