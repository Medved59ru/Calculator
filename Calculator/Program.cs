using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Калькулятор";
            Calculations regime = new Calculations();
            regime.GetFromConsole();
           

        }
    }
}
