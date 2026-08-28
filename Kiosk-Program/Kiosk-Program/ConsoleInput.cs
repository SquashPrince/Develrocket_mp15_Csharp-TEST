using System;

public class ConsoleInput
{
    public static int ReadIntInRange(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);

            string input = Console.ReadLine() + "";
            input = input.Trim();

            if (input.Length == 0)
            {
                Console.WriteLine($"  값을 입력해 주세요.");
                continue;
            }

            int value;

            if (int.TryParse(input, out value) == false)
            {
                Console.WriteLine($"  숫자로 입력해 주세요.");
                continue;
            }

            if (value < min || value > max)
            {
                if (max == int.MaxValue)
                {
                    Console.WriteLine($"  {min} 이상으로 입력해 주세요.");
                }
                else
                {
                    Console.WriteLine($"  {min}부터 {max} 사이로 입력해 주세요.");
                }

                continue;
            }

            return value;
        }
    }

    public static int ReadIntAtLeast(string prompt, int min)
    {
        return ReadIntInRange(prompt, min, int.MaxValue);
    }

    public static void Pause()
    {
        Console.WriteLine();
        Console.Write($"계속하려면 Enter를 누르세요 : ");
        Console.ReadLine();
    }
}
