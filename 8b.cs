using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication9
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int num1, num2, x, y, lcm = 0;
            Console.Write("Enter the First Number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            b = int.Parse(Console.ReadLine());
            
            int result = lcm_of_num(a,b);
            Console.WriteLine(result);
            Console.Write("Least Common Multiple is : " + result);
            Console.Read();
        }
        public int lcm_of_num(int num1, int num2){

                x = num1;
                y = num2;
                while (num1 != num2)
                {
                    if (num1 > num2)
                    {
                        num1 = num1 - num2;
                    }
                    else
                    {
                        num2 = num2 - num1;
                    }
                }
                lcm = (x * y) / num1;
                return lcm
            }
    }
}