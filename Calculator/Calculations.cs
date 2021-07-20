using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
   public class Calculations
   {
        public void GetFromConsole()
        {
           
            bool loopStop = false;


            while (!loopStop)
            {
                Console.WriteLine("Калькулятор работает в 2-х режимах \n 1-ввод данных с консоли \n 2-чтение из файла и запись в файл \n Любая другая клавиша - закрыть приложение");
                Console.Write("Выберете режим работы: ");
                string userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    Console.Write("Введите данные для решения: ");
                    ConsoleHandler result = new ConsoleHandler(Console.ReadLine());
                    Console.WriteLine("{0} = {1}", result.formula, result.stringResult);
                }
                else if (userChoice == "2")
                {
                    FileHandler handler = new FileHandler();
                    handler.GetResult();
                    
                }
                else
                {
                    Console.WriteLine("\n Pежим не выбран. Закройте программу. ");
                    loopStop = true;
                }

            }
                       
        }
   }
}
