using System;  
class Program  
{  
    static void Main()  
    {  
        Console.Write("Enter first number : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number : ");
        c = Convert.ToInt32(Console.ReadLine());
        sq(a,b,c);
        //Waiting for output
        Console.ReadKey();  
    }  
    public int sq(int x,int y,int z){
                

        int i;  
        int [] a = new int[5]  {x,y,z};  
        
          
        //Sorting the values  
        for (i = 1; i <= n; i++)  
        {  
            for (int j = 1; j <= n - 1; j++)  
            {  
                if (a[j] > a[j + 1])  
                {  
                    int temp = a[j];  
                    a[j] = a[j + 1];  
                    a[j + 1] = temp;  
                }  
            }  
        }  
        Console.Write("Sorted number : ");  
        for (i = 1; i <= n; i++)  
        {  
            Console.Write(a[i]+" ");
        }

    }
            
}
