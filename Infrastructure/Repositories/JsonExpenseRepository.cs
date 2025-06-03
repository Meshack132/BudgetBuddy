using System.Collections.Generic;
using System.IO;
using System.Linq;
using BudgetBuddy.Domain.Interfaces;
using BudgetBuddy.Domain.Models;
using System.Text.Json;

namespace BudgetBuddy.Infrastructure.Repositories
{
    public class JsonExpenseRepository : IExpenseRepository
    {
        private const string FilePath = "expenses.json";

        public void AddExpense(Expense expense)
        {
            var expenses = GetAll().ToList();
            expenses.Add(expense);
            File.WriteAllText(FilePath, JsonSerializer.Serialize(expenses));
        }

        public IEnumerable<Expense> GetAll()
        {
            if (!File.Exists(FilePath)) return new List<Expense>();

            var content = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Expense>>(content) ?? new List<Expense>();
        }
    }
}
