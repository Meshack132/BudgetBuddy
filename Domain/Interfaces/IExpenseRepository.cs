using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using BudgetBuddy.Domain.Models;

namespace BudgetBuddy.Domain.Interfaces
{
    public interface IExpenseRepository
    {
        void AddExpense(Expense expense);
        IEnumerable<Expense> GetAll();
    }
}