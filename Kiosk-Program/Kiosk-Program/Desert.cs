using System;
public class Desert : Food, IOrderable, ISalable
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

    public Desert(string name, int prise, int[] saleValue) : base(name, prise)
    {
        SaleValue = saleValue;
        FoodType = FoodType.Desert;
    }

    public string PrintSalePoint()
    {
        return $"{SaleValue[0]}개 이상 구매시 {SaleValue[1]}% 할인";
    }

    public override int OnCalculate( int addAmount )
    {
        if(addAmount >= Prise * SaleValue[0])
        {
            return (addAmount * (100 - SaleValue[1]) / 100);
        }

        return Prise;
    }
}
