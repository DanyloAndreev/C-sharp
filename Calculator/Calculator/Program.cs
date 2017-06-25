using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
    //Калькулятор который не умеет делить с остатком, не понимет дробные числа, зато складывает и умножает не хило
{
    class Program
    {
        static void Main(string[] args)
        {
            int ex = 5;
            do
            {
                Console.WriteLine("Что нужно посчитать?");
                string firstValue;
                firstValue = Console.ReadLine();
                char[] delimeterChar = { '+', '-', '*', '/' };
                string[] symbols = firstValue.Split(delimeterChar);
                foreach (char sign in firstValue)
                {
                    switch (sign)
                    {
                        case '+':
                            Console.WriteLine("Result: " + (Convert.ToInt32 (symbols[0]) + Convert.ToInt32(symbols[1])));
                            break;
                        case '-':
                            Console.WriteLine("Result: " + (Convert.ToInt32 (symbols[0]) - Convert.ToInt32(symbols[1])));
                            break;
                        case '*':
                            Console.WriteLine("Result: " + (Convert.ToInt32 (symbols[0]) * Convert.ToInt32(symbols[1])));
                            break;
                        case '/':
                            Console.WriteLine("Result: " + (Convert.ToInt32 (symbols[0]) / Convert.ToInt32(symbols[1])));
                            break;
                    }
                }
            }
            while (ex < 6);
            Console.ReadKey();
        }
    }
}
