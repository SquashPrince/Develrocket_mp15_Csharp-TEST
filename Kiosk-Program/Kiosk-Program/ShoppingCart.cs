using System;


public class ShoppingCart<T> where T : Food
{
    private List<T> T_CartList;
    private List<int> totalPrise = new List<int>();

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
        string checkStr = T_CartList[0].Name;
        int menuPriseSum = 0;

        foreach(T list in T_CartList)
        {
            if (checkStr == list.Name)
            {
                menuPriseSum = list.OnCalculate(menuPriseSum);

                Console.WriteLine(menuPriseSum);
            }
            else
            {
                Console.WriteLine($"{list.Name} x{GetNumByName(list.Name)}   {list.OnCalculate(menuPriseSum)}원");
                totalPrise.Add(menuPriseSum);

                menuPriseSum = 0;
                checkStr = list.Name;
            }
        }

        Console.WriteLine($"합계 : {GetTotalPrise()}원");
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

    public int GetTotalPrise()
    {
        int sum = 0;

        foreach(int prise in totalPrise)
        {
            sum += prise;
        }

        return sum;
    }
}
