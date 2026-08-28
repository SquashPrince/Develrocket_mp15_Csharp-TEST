using System;
using System.Runtime.ExceptionServices;


public class ShoppingCart<T> where T : Food
{
    private List<T> T_CartList;
    private int _totalPrise;
    public int TotalPrise
    {
        get { return _totalPrise; }
        private set { _totalPrise = value; }
    }

    private int CartSize
    {
        get
        {
            return T_CartList.Count;
        }
    }

    public ShoppingCart()
    {
        T_CartList = new List<T>();
    }

    public int Count()
    {
        return CartSize;
    }

    public void Add(int targetIndex, T[] targetList)
    {
        T_CartList.Add(targetList[targetIndex - 1]);
    }

    public void RemoveAll()
    {
        T_CartList.Clear();
    }

    public void PrintCartList()
    {
        Console.WriteLine("[장바구니]");

        TotalPrise = 0;

        for (int i = 0; i < Enum.GetNames(typeof(FoodType)).Length; i++)
        {
            int menuPriseSum = 0;

            for (int j = 0; j < T_CartList.Count; j++)
            {
                if (T_CartList[j].FoodType == (FoodType)i)
                {
                    menuPriseSum += T_CartList[j].Prise;
                }
            }
            Console.WriteLine($"{T_CartList[i].Name} x{GetNumByName(T_CartList[i].Name)}   {T_CartList[i].OnCalculate(menuPriseSum)}원");
            TotalPrise += menuPriseSum;
        }

        Console.WriteLine($"합계 : {TotalPrise}원");
        Console.WriteLine("---------------------------------");
    }

    public int GetNumByName(string name)
    {
        int count = 0;

        for (int i = 0; i < T_CartList.Count; i++)
        {
            if (T_CartList[i].Name == name)
            {
                count++;
            }
        }

        return count;
    }

    public int GetNumByFoodType(FoodType foodType)
    {
        int count = 0;

        for (int i = 0; i < T_CartList.Count; i++)
        {
            if (T_CartList[i].FoodType == foodType)
            {
                count++;
            }
        }

        return count;
    }
}
