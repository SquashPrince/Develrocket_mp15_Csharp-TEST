using System;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    static void Main(string[] args)
    {
        const string SHOP_NAME = "맛나 패스트 푸트";

        PrintConsole("---------------------------------");
        PrintConsole($"{SHOP_NAME} 주문 키오스크");
        PrintConsole("---------------------------------");



        Food[] foods =
        {
            new Burger("불고기 버거", 10000),
            new Drink("콜라", 2000),
            new SideDish("감자 튀김", 10000),
            new Desert("소프트 아이스크림", 500, [5, 10])
        };

        Topping[] toppings =
        {
            new Topping("달걀 프라이", 200, ToppingType.Egg),
            new Topping("토마토", 300, ToppingType.Tomato),
            new Topping("패티", 1500, ToppingType.Patty),
            new Topping("상추", 200, ToppingType.Lattuce)
        };


        PrintMenuList(foods);

        ShoppingCart<Food> shoppingCart = new ShoppingCart<Food>();

        shoppingCart.Add(4,foods);
        shoppingCart.Add(4,foods);
        shoppingCart.Add(4,foods);
        shoppingCart.Add(4,foods);
        shoppingCart.Add(4,foods);
        shoppingCart.Add(4,foods);
        shoppingCart.Add(4,foods);

        shoppingCart.PrintCartList();
    }

    static void PrintConsole(string text)
    {
        Console.WriteLine(text);
    }

    static void PrintMenuList(Food[] menu)
    {
        Console.WriteLine("[메뉴판]");

        for (int i = 0; i < menu.Length; i++)
        {
            string text = "정가";

            if (menu[i] is ISalable)
            {
                text = (menu[i] as ISalable).PrintSalePoint();
            }

            PrintConsole($"  {i + 1}. {menu[i].Name}  ({menu[i].PrintFoodType()})  {menu[i].Prise}원  [{text}]");
        }
        PrintConsole("---------------------------------");
    }

}