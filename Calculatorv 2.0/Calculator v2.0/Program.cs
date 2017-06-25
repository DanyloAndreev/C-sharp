using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //преобразование строки в float
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Хочешь что-то посчитать?");
                string input = Console.ReadLine();
                string[] numbers = input.Split('+', '-', '*', '/');
                string[] signs = input.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.');
                List<string> signsList = new List<string>();
                signsList = signs.ToList();
                List<float> operandList = new List<float>();
                for (int i = 0; i < numbers.Length; i++)
                {
                    float numbersConverted = float.Parse(numbers[i], System.Globalization.CultureInfo.InvariantCulture);
                    operandList.Add(numbersConverted);
                    foreach (string sign in signs)
                    {
                        switch (sign)
                        {
                            case "*":
                                int index = signsList.FindIndex("*");
                                Console.WriteLine(index);
                                Console.ReadKey();
                                break;
                        }
                    }
                }

                
            }
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();
        }
    }
}
