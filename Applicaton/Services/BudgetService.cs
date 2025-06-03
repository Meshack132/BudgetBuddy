using System;
using System.Collections.Generic;
using BudgetBuddy.Domain.Interfaces;
using BudgetBuddy.Domain.Models;

namespace BudgetBuddy.Application.Services
{
    public class BudgetService
    {
        private readonly IExpenseRepository _expenseRepo;

        public BudgetService(IExpenseRepository expenseRepo)
        {
            _expenseRepo = expenseRepo;
        }

        public void AddExpense(string category, decimal amount, string note)
        {
            var expense = new Expense { Category = category, Amount = amount, Note = note, Date = DateTime.Now };
            _expenseRepo.AddExpense(expense);
        }

        public IEnumerable<Expense> GetAllExpenses()
        {
            return _expenseRepo.GetAll();
        }

        public decimal CalculateBudget(IBudgetStrategy strategy)
        {
            return strategy.Calculate(_expenseRepo.GetAll());
        }
    }
}