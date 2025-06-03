using System;
using BudgetBuddy.Application.Services;
using BudgetBuddy.Infrastructure.Factory;
using BudgetBuddy.Application.Strategies;

namespace BudgetBuddy.CLI
{
    public class Menu
    {
        private readonly BudgetService _budgetService;

        public Menu()
        {
            var repo = RepositoryFactory.CreateExpenseRepository();
            _budgetService = new BudgetService(repo);
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n--- Budget Buddy ---");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Total Spending");
                Console.WriteLine("4. Spending by Category");
                Console.WriteLine("0. Exit");
                Console.Write("Choose: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": AddExpenseUI(); break;
                    case "2": ViewExpensesUI(); break;
                    case "3": TotalSpendingUI(); break;
                    case "4": CategorySpendingUI(); break;
                    case "0": return;
                    default: Console.WriteLine("Invalid input."); break;
                }
            }
        }

        private void AddExpenseUI()
        {
            Console.Write("Category: ");
            var category = Console.ReadLine();

            Console.Write("Amount: ");
            var amount = decimal.Parse(Console.ReadLine());

            Console.Write("Note (optional): ");
            var note = Console.ReadLine();

            _budgetService.AddExpense(category, amount, note);
            Console.WriteLine("✔ Expense added.");
        }

        private void ViewExpensesUI()
        {
            var expenses = _budgetService.GetAllExpenses();

            Console.WriteLine("\n--- All Expenses ---");
            foreach (var e in expenses)
            {
                Console.WriteLine($"{e.Date:yyyy-MM-dd} | {e.Category} | R{e.Amount:N2} | {e.Note}");
            }
        }

        private void TotalSpendingUI()
        {
            var strategy = new TotalSpendingStrategy();
            var total = _budgetService.CalculateBudget(strategy);
            Console.WriteLine($"Total Spending: R{total:N2}");
        }

        private void CategorySpendingUI()
        {
            Console.Write("Category: ");
            var category = Console.ReadLine();
            var strategy = new CategorySpendingStrategy(category);
            var total = _budgetService.CalculateBudget(strategy);
            Console.WriteLine($"Spending in '{category}': R{total:N2}");
        }
    }
}