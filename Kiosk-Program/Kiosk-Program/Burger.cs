using System;

public class Burger : Food, ICalculatable, ISalable
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
        if(SaleValue[0] == 0)
        {
            return "정가";
        }

        return $"{SaleValue[0]}개 이상 구매시 {SaleValue[1]}% 할인";
    }

    public int OnCalculate(int addAmount)
    {
        if (SaleValue[0] >= 1 && addAmount >= SaleValue[0])
        {
            return (Prise * (100 - SaleValue[1]) / 100);
        }

        return Prise;
    }
}
