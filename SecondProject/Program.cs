using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonachi f = new fibonachi();
            factorial f2 = new factorial();
            Chet_Nechet ch = new Chet_Nechet();
            model m = new model();
            while (true)
            {

                Console.WriteLine("\nEnter the number of task , which you want to launch .From (1-4)");
                int number_of_task = int.Parse(Console.ReadLine());
                switch (number_of_task)
                {
                    case 1:
                        Console.WriteLine("Enter the number of the Fibonacci number to be displayed");
                        int n = Convert.ToInt32(Console.ReadLine());
                        int result = f.fib(n);
                        Console.WriteLine("Result is "+result);
                        break;
                    case 2:
                        Console.WriteLine("Enter the number for which you want to calculate the factorial.");
                         n = Convert.ToInt32(Console.ReadLine());
                         int result2 = f2.fact(n);
                        Console.WriteLine("Result is " + result2);
                        break;
                    case 3:
                        m.resh();
                        break;
                    case 4:
                        Console.WriteLine("enter array dimension");
                        n = Convert.ToInt32(Console.ReadLine());
                        ch.ch_nech( n);
                        break;
                    default:
                        break;

                }
                Console.WriteLine("\nif you want to launch program again press 1 , or to exit - press 2 ");
                
                int exit = int.Parse(Console.ReadLine());
                if(exit==2)
                {
                    break;
                }
            }

               
            
            Console.ReadLine();
        }
    }
}
