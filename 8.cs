using System;
using System.IO;
using System.Text;

namespace IncludeHelp
{
    class Test
    {
        // Main Method 
        static void Main(string[] args)
        {
            // Largest funtion

            //input the numbers
            Console.Write("Enter first number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number : ");
            z = Convert.ToInt32(Console.ReadLine());


            int result = largest(x,y,z);
            Console.WriteLine(result);

            
            //hit ENTER to exit the program
            Console.ReadLine();
        }
        public int largest(int a, int b,int c){
            if (a > b && a > c)
                large = a;
            else if (b > a && b > c)
                large = b;
            else large = c;
            }
    }
}