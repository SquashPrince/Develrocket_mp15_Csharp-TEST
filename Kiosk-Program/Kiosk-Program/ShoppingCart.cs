using System;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;


public class ShoppingCart<T> where T : Food
{
    private List<T> T_CartList;
    private List<T> T_TotalList = new List<T>();
    private int _totalPrise;
    public int TotalPrise
    {
        get { return _totalPrise; }
        private set { _totalPrise = value; }
    }

    public int GetCartSize()
    {
        return T_CartList.Count;
    }

    public ShoppingCart()
    {
        T_CartList = new List<T>();
    }

    public void Add(int targetIndex, T[] targetList)
    {
        T_CartList.Add(targetList[targetIndex - 1]);
    }

    public void SaveCustomerBuyLog()
    {
        T_TotalList.AddRange(T_CartList);

        Console.WriteLine("\n구매가 완료 되었습니다.");
        ConsoleInput.Pause();
    }

    public void RemoveAll()
    {
        TotalPrise = 0;

        T_CartList.Clear();

        Console.WriteLine("\n장바구니를 비웠습니다.");
        ConsoleInput.Pause();
    }

    public void PrintCartList(Food[] foods)
    {
        Console.WriteLine("[장바구니]");

        TotalPrise = 0;

        for(int i = 0; i < foods.Length; i++)
        {
            string name = "";
            int prise = 0;
            int count = 0;

            foreach (T list in T_CartList)
            {
                if (list.Name == foods[i].Name)
                {
                    count++;
                    name = list.Name;

                    if(list is ICalculatable)
                    {
                        prise = (list as ICalculatable).OnCalculate(count);
                    }
                    else
                    {
                        prise = list.OnCalculate();
                    }
                }
            }
            if(count >= 1)
            {
                Console.WriteLine($"  {name}  x{count}  {prise * count}원");
            }

            TotalPrise += prise * count;
        }

        Console.WriteLine($"  합계 : {TotalPrise}원");
        Console.WriteLine("---------------------------------");
    }

    public void PrintTotalList(Food[] foods)
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("[영업 종료 정산]");

        TotalPrise = 0;

        for (int i = 0; i < foods.Length; i++)
        {
            string name = "";
            int prise = 0;
            int count = 0;

            foreach (T list in T_TotalList)
            {
                if (list.Name == foods[i].Name)
                {
                    count++;
                    name = list.Name;

                    if (list is ICalculatable)
                    {
                        prise = (list as ICalculatable).OnCalculate(count);
                    }
                    else
                    {
                        prise = list.OnCalculate();
                    }
                }
            }
            if (count >= 1)
            {
                Console.WriteLine($"  {name}  x{count}  {prise * count}원");
            }

            TotalPrise += prise * count;
        }

        Console.WriteLine($"  합계 : {TotalPrise}원");
        Console.WriteLine("---------------------------------");
    }
}
