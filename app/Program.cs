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

        static void loop(int num)
        {
            for (int i = 0; i <= num; i++) {
            Console.WriteLine(i);
            }
        }


        static void Main(string[] args)
        {

            // calc();
            // loop(50);


            int[] myarray = { 5, 3, 64, 234, 56, 4 };
            
           // for (int i=0; i < myarray.Length; i++){
           //     Console.WriteLine(myarray[i]);
           // }


           foreach (int element in myarray)
            {
                Console.WriteLine(element + 1);
            }



            Console.ReadLine();

        }
    }
}
