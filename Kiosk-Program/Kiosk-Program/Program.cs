using System;

public class Program
{
    static void Main(string[] args)
    {
        const string SHOP_NAME = "맛나 패스트 푸트";

        PrintConsole("---------------------------------");
        PrintConsole($"{SHOP_NAME} 주문 키오스크");
        PrintConsole("---------------------------------");
    }

    static T ShoppingCart<T>(params T[] values) where T : IOderable
    {

        return default(T); 
    }

    static void PrintConsole(string text)
    {
        Console.WriteLine(text);
    }

    public void PrintMenuList()
    {

    }

}