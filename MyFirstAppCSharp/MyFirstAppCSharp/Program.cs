using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAppCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Тюремный калькулято
            string ex = "q";
            char operation;
            do
            {
                Console.WriteLine("Сколько тебе сейчас?");
                    int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Что нужно сделать (+ - / *) ??");
                    operation = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Сколько годков пришили?");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                int sum = number + number1;
                int min = number - number1;
                int mno = number * number1;
                int del = number / number1;
                int total = 0;
                if (operation == '+')
                {
                    Console.WriteLine("Когда выйдешь, тебе будет " + sum + " и");
                    total = sum;
                }
                else if (operation == '-')
                {
                    Console.WriteLine("Когда выйдешь, тебе будет " + min + " и");
                    total = min;
                }
                else if (operation == '*')
                {
                    Console.WriteLine("Когда выйдешь, тебе будет " + mno + " и");
                    total = mno;
                }
                else if (operation == '/')
                {
                    Console.WriteLine("Когда выйдешь, тебе будет " + del + " и");
                    total = del;
                }
                if (total >= 35)
                {
                    Console.WriteLine("Тебе уже нет смыслы выходить с тюрьмы");
                }
                else if (total >= 27 && total < 35)
                {
                    Console.WriteLine("Впринципе у тебя есть еще шанс немножко пожить... (Но это не точно :))");
                }
                else if (total < 27)
                {
                    Console.WriteLine("Не отчаивайся, еще всё впереди!");
                }
                Console.WriteLine("Для выхода наберите 'q' и нажмите Enter");
            }
            while
            (ex != Convert.ToString(Console.ReadLine()));
            
        }
    }
}
