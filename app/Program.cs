using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class Program
    {

        static void calc()
        {
            
            Console.WriteLine("This is a calculator");
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation do you want to perform? (+,-,*,/)");
            string op = Console.ReadLine();

            var list = new string[] {"+", "-", "*", "/"};

            if (list.Contains(op)) {

            Console.WriteLine("Enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
               case "*":
                    Console.WriteLine(num1 * num2);
                    break;
               case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    // code block
                    break;
            }


            Console.ReadLine();
            } else
            {
                Console.WriteLine("incorrect input");
                calc();
            }
        }


        static void Main(string[] args)
        {

            calc();


        }
    }
}
