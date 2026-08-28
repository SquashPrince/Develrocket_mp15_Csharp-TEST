using System;


public class ShoppingCart<T> where T : Food
{
    private List<T> T_CartList;

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

    public void Add(T target)
    {
        T_CartList.Add(target);
    }

    public void RemoveAll()
    {
        T_CartList.Clear();
    }

    public void PrintCartList()
    {
        foreach(T list in T_CartList)
        {
            Console.WriteLine($"{list.Name} x{GetNumByName(list.Name)}   {list.OnCalculate()}원");
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
        int totalPrise = 0;

        foreach(Food food in T_CartList)
        {
            totalPrise += food.OnCalculate();
        }

        return totalPrise;
    }
}
