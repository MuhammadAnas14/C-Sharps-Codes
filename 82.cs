using System;
public class se
{
    public static void Main()
    {
        int a, b, c, d;
        Console.Write("\n\n");
        Console.Write("Enter Values\n");
        Console.Write("------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the 1st number :");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the  2nd number :");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd  number :");
        c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 4th  number :");
        d = Convert.ToInt32(Console.ReadLine());

        if (a < b)
        {
            if (c > d)
            {
                Console.Write('1');
            }
            else if (c == d)
            {
                Console.Write('2');
            }
            else
            {
                Console.Write('3');
            }
        }
        else if (a == b)
        {
            Console.Write('4');
        }
        else if (c == d)
        {
            Console.Write('5');
        }
        else
        {
            Console.Write('6');
        }
        Console.Write("\n");
        Console.Write("Press <Enter> to exit... ");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
    }
    
}
