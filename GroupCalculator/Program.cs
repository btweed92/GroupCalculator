using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //prompt
            bool go = true;
            while (go)
            {
                PrintMenu();

                //receive
                string userChoice = Console.ReadLine();
                

                //processing
                switch (userChoice.ToLower())
                {
                    case "1":
                    case "addition":
                        //input, getting numbers from user
                        double num1 = ReadDoubles("Number 1: ");
                        double num2 = ReadDoubles("Number 2: ");
                        //processing
                        double sum = AddDoubles(num1, num2);
                        //output
                        Console.WriteLine($"{num1} + {num2} = {sum}");
                        break;

                    case "2":
                    case "subtraction":
                        //input, getting numbers from user
                        double num3 = ReadDoubles("Number 1: ");
                        double num4 = ReadDoubles("Number 2: ");
                        //processing
                        double rem = SubDoubles(num3, num4);
                        //output
                        Console.WriteLine($"{num3} - {num4} = {rem}");
                        break;

                    case "3":
                    case "mulitplication":
                        //input, getting numbers from user
                        double num5 = ReadDoubles("Number 1: ");
                        double num6 = ReadDoubles("Number 2: ");
                        //processing
                        double prod = MultiDoubles(num5, num6);
                        //output
                        Console.WriteLine($"{num5} * {num6} = {prod}");
                        break;

                    case "4":
                    case "division":
                        //input, getting numbers from user
                        double num7 = ReadDoubles("Number 1: ");
                        double num8 = ReadDoubles("Number 2: ");
                        //processing
                        double quot = DivDoubles(num7, num8);
                        //output
                        Console.WriteLine($"{num7} / {num8} = {quot}");
                        break;

                    case "5":
                    case "exit":
                        go = false;
                        break;

                    default:
                        break;

                }
            }
            //output
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
        }
        public static double ReadDoubles(string message)
        {
            //input
            //prompt
            Console.WriteLine(message);
            //retrieve
            string input = Console.ReadLine();
            //processing
            double num = double.Parse(input);
            //output
            return num;
        }

        public static double AddDoubles(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double SubDoubles(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double MultiDoubles(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double DivDoubles(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
