using System;
using BudgetBuddy.CLI;

namespace BudgetBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Budget Buddy - Personal Finance Tracker";
            var menu = new Menu();
            menu.Run();
        }
    }
}