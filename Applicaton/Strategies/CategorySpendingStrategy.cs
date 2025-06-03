using System.Collections.Generic;
using System.Linq;
using BudgetBuddy.Domain.Interfaces;
using BudgetBuddy.Domain.Models;

namespace BudgetBuddy.Application.Strategies
{
    public class CategorySpendingStrategy : IBudgetStrategy
    {
        private readonly string _category;

        public CategorySpendingStrategy(string category)
        {
            _category = category;
        }

        public decimal Calculate(IEnumerable<Expense> expenses)
        {
            return expenses.Where(e => e.Category == _category).Sum(e => e.Amount);
        }
    }
}