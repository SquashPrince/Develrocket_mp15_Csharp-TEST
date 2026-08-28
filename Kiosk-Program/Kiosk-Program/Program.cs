using System;

public class Program
{
    static void Main(string[] args)
    {
        const string SHOP_NAME = "맛나 패스트 푸트";

        PrintConsole("---------------------------------");
        PrintConsole($"{SHOP_NAME} 주문 키오스크");
        PrintConsole("---------------------------------");

        ShoppingCart<Food> shoppingCart = new ShoppingCart<Food>();

        Food[] foods =
        {

        }

        shoppingCart.Add();

        shoppingCart.PrintCartList();
    }

    static void PrintConsole(string text)
    {
        Console.WriteLine(text);
    }

    public void PrintMenuList(Food[] menu)
    {
        for(int i = 0; i < menu.Length; i++)
        {
            PrintConsole($"{i + 1}. {menu[i].Name}  ({menu[i].FoodType})  {}원  [{}]");
        }
    }

}