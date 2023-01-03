using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int balance = 500;

            Console.WriteLine("Добро пожаловать в Банкомат. Какую операцию вы хотите выполнить?");
            Console.WriteLine("1 - Баланс");
            Console.WriteLine("2 - Снять деньги");
            Console.WriteLine("3 - Пополнить счет");
            Console.WriteLine("Q - завершить операцию");
            Console.Write("\nВыбор: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Ваш баланс составляет: " + balance + "AZN");
            }

            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("Сколько вы хотите снять денег?");
                int withDrawMoney = Convert.ToInt32(Console.ReadLine());

                if (withDrawMoney > balance)
                {
                    Console.Write("Недостаточно средств.");
                }
                else
                {
                    balance -= withDrawMoney;
                    Console.WriteLine("Снято денег: " + withDrawMoney + "AZN" + "\nТекущий баланс: " + balance + "AZN");
                }
            }

            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("Внесите необходимую сумму");
                int depositMoney = Convert.ToInt32(Console.ReadLine());
                balance += depositMoney;
                Console.WriteLine("Вы внесли: " + depositMoney + "AZN" + "\nТекущий баланс: " + balance + "AZN");
            }

            else if (choice == "q" || choice == "Q")
            {
                Console.Clear();
                Console.Write("Операция завершена. Спасибо за ваше внимание.");
            }

            else
            {
                Console.WriteLine("Произошла ошибка. Проверьте правильность ввода.");
            }

            Console.ReadLine();
        }
    }
}
