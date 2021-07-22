using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Калькулятор";
            ModeSelector regime = new ModeSelector();
            regime.GetFromConsole();
           

        }
    }
}
