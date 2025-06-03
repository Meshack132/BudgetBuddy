```markdown
# 💸 BudgetBuddy

**BudgetBuddy** is a C# console application built for tracking and analyzing personal expenses. It demonstrates professional software engineering principles including **SOLID**, **design patterns**, and **clean architecture** — making it a perfect project to showcase in your portfolio as a Software Engineer Intern.

---

## 🚀 Features

- Add, list, and remove expenses
- Categorize expenses (e.g., Food, Transport, Bills)
- Analyze spending using different budgeting strategies
- Generate expense reports by category/time period
- Store data in memory (extensible to database storage)
- Follows SOLID principles with clean separation of concerns
- Implements **Strategy** and **Factory** design patterns

---

## 🛠️ Technologies & Design

| Layer         | Responsibilities                                      | Patterns Used          |
|---------------|-------------------------------------------------------|------------------------|
| Core          | Domain models, interfaces, strategy logic             | SOLID, Strategy Pattern |
| Infrastructure| Data repository implementation                       | Repository, Factory Pattern |
| Application   | Use case coordination, input/output handling          | Service Layer          |
| Console UI    | User interaction and application entry point          | Command Pattern        |

---

## 🧱 Architecture Overview

```
BudgetBuddy/
├── Core/
│   ├── Entities/          # Domain models (Expense, Category, etc.)
│   ├── Interfaces/        # Abstraction contracts (IRepository, IStrategy)
│   └── Strategies/        # Budget analysis algorithms
├── Infrastructure/
│   ├── Repositories/      # Data persistence implementations
│   └── Factory/           # Object creation logic
├── Application/
│   ├── Services/          # Business logic and workflow
├── UI/                    # Console interface
│   └── Program.cs         # Entry point
└── BudgetBuddy.sln        # Solution file
```

---

## 💡 Design Patterns

### 🧩 Strategy Pattern
Enables dynamic selection of budget analysis algorithms:
- `IBudgetStrategy`: Strategy interface
- `TotalSpendingStrategy`: Calculates total expenses
- `CategorySpendingStrategy`: Calculates spending by category
- `MonthlyReportStrategy`: Generates monthly expense reports

### 🏭 Factory Pattern
Decouples object creation from business logic:
- `RepositoryFactory`: Creates appropriate `IExpenseRepository` instances
- `StrategyFactory`: Instantiates budgeting strategy implementations

---

## 📦 Getting Started

### Prerequisites
- [.NET 7+ SDK](https://dotnet.microsoft.com/)
- Git

### Clone & Run
```bash
git clone https://github.com/Meshack132/BudgetBuddy.git
cd BudgetBuddy/UI
dotnet run
```

### Example Usage
```
===== BudgetBuddy =====
1. Add Expense
2. View All Expenses
3. Generate Spending Report
4. Exit

Choice: 1
Enter amount: 25.99
Enter category (Food/Transport/Bills): Food
Enter description: Groceries
Expense added successfully!

Choice: 3
Select report type:
1. Total Spending
2. By Category
3. Monthly Summary

Choice: 2
===== Category Report =====
Food: $87.50
Transport: $45.00
Bills: $120.00
```

---

## 🧪 Testing

The architecture supports easy unit testing:
```csharp
// Example test for TotalSpendingStrategy
[Fact]
public void Calculate_ReturnsCorrectTotal()
{
    // Arrange
    var expenses = new List<Expense>
    {
        new(50, "Food"),
        new(30, "Transport")
    };
    var strategy = new TotalSpendingStrategy();
    
    // Act
    var result = strategy.Analyze(expenses);
    
    // Assert
    Assert.Equal(80, result.Total);
}
```

---

## 📈 Future Improvements

* Implement SQLite persistence using Entity Framework Core
* Add unit tests with xUnit/MSTest
* Integrate dependency injection with Autofac
* Add monthly budget limits with alert notifications
* Develop web API layer for multi-client support
* Implement CSV/PDF export functionality

---

## 👨‍💻 Author

**Meshack Mthimkhulu**  
[![GitHub](https://img.shields.io/badge/GitHub-Profile-blue?logo=github)](https://github.com/Meshack132) 
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Profile-blue?logo=linkedin)](https://www.linkedin.com/in/meshackmthimkhulu-software-engineer/))

---

## 📝 License

This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.
```

This README features:

1. Professional structure tailored for software engineering roles
2. Clear highlighting of SOLID principles and design patterns
3. Visual architecture diagram and pattern explanations
4. Concise getting started instructions with example output
5. Practical code snippet demonstrating testability
6. Roadmap showing potential for growth and improvement
7. Professional branding with badges and clean formatting

The design emphasizes your technical skills with:
- Strategy Pattern for interchangeable budgeting algorithms
- Factory Pattern for decoupled object creation
- Repository Pattern for data access abstraction
- Clean layer separation (Core/Infrastructure/Application/UI)
- SOLID compliance through interface segregation and dependency inversion
