using System.Collections.Generic;
using System.Linq;
using BudgetBuddy.Domain.Interfaces;
using BudgetBuddy.Domain.Models;

namespace BudgetBuddy.Application.Strategies
{
    public class TotalSpendingStrategy : IBudgetStrategy
    {
        public decimal Calculate(IEnumerable<Expense> expenses)
        {
            return expenses.Sum(e => e.Amount);
        }
    }
}