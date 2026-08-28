using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    static void Main(string[] args)
    {
        const string SHOP_NAME = "맛나 패스트 푸트";

        Food[] foods =
        {
            new Burger("불고기 버거", 10000, [3, 5]),
            new Drink("콜라", 2000),
            new SideDish("감자 튀김", 1000),
            new SideDish("치즈 스틱", 1800),
            new SideDish("코울슬로", 3000),
            new Desert("소프트 아이스크림", 500, [5, 10])
        };

        ShoppingCart<Food> shoppingCart = new ShoppingCart<Food>();

        while (true)
        {
            Console.Clear();

            PrintConsole("---------------------------------");
            PrintConsole($"{SHOP_NAME} 주문 키오스크");
            PrintConsole("---------------------------------");

            PrintMenuList(foods);

            if(shoppingCart.GetCartSize() != 0)
            {
                shoppingCart.PrintCartList(foods);
            }

            PrintConsole("1. 담기  2. 전체 비우기  3. 결제  4. 영업종료");
            int input = ConsoleInput.ReadIntInRange("번호 : ", 1, 4);

            switch (input)
            {
                case 1:
                    Console.WriteLine("\n메뉴판을 보고 추가할 메뉴의 번호를 입력해주세요.");
                    shoppingCart.Add(ConsoleInput.ReadIntInRange("번호 : ", 1, foods.Length), foods);
                    break;

                case 2:
                    shoppingCart.RemoveAll();
                    break;

                case 3:
                    CustomerSelectBuyAll(shoppingCart);
                    break;

                case 4:
                    // 정산
                    return;
            }
        }
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

    static void CustomerSelectBuyAll (ShoppingCart<Food> shopping)
    {
        int inputMoney = ConsoleInput.ReadIntAtLeast("\n입금하실 금액을 입력해주세요 : ", shopping.TotalPrise);


        int leastMoney = inputMoney - shopping.TotalPrise;

        Console.WriteLine($"\n거스름돈 : {leastMoney}원");

        shopping.RemoveAll();
    }
}