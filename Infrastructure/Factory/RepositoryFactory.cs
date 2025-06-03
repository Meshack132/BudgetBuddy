using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using BudgetBuddy.Domain.Interfaces;
using BudgetBuddy.Infrastructure.Repositories;

namespace BudgetBuddy.Infrastructure.Factory
{
    public static class RepositoryFactory
    {
        public static IExpenseRepository CreateExpenseRepository()
        {
            // Future: switch between JSON, DB, etc.
            return new JsonExpenseRepository();
        }
    }
}