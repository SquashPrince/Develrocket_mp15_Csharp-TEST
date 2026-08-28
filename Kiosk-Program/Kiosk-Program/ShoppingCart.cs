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
