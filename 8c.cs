

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
            Console.WriteLine("Enter a Number : ");
            int Number = Convert.ToInt16(Console.ReadLine());
            int result = sq(Number);
            Console.WriteLine("Square root of {0} is: {1}", Number, result);
            Console.ReadLine();
            
        }
        public int sq(int x){
                
                
                double SqrtNumber = Math.Sqrt(x);
                return SqrtNumber
            }
    }
}