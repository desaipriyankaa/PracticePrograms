using System;
using System.Collections.Generic;

namespace ArrayAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < args.Length; i++)
            {
                int num = Int32.Parse(args[i]);
                numbers.Add(num);
                Console.WriteLine(" Numbers are : " + num);
            }

            ArrayCalculator t = new ArrayCalculator();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Enter your choice :- ");
                Console.WriteLine(" 1.Addition of all numbers\n 2.Addition of numbers at Even position\n 3.Addition of numbers at Odd position\n 4.Exit");
                try
                {
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 4)
                    {
                        break;
                    }

                    switch (choice)
                    {
                        case 1:
                            int adda = t.addAll(numbers);
                            Console.WriteLine(adda);
                            break;

                        case 2:
                            int adde = t.addEven(numbers);
                            Console.WriteLine(adde);
                            break;

                        case 3:
                            int addo = t.addOdd(numbers);
                            Console.WriteLine(addo);
                            break;

                        default:
                            Console.WriteLine("Invalid Choice..... Please select\n1.Addition of all numbers\n 2.Addition of numbers at Even position\n 3.Addition of numbers at Odd position\n 4.Exit");
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }

            }
        }
    }
}
