using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BudgetBuddy.Domain.Models;

namespace BudgetBuddy.Domain.Interfaces
{
    public interface IBudgetStrategy
    {
        decimal Calculate(IEnumerable<Expense> expenses);
    }
}
