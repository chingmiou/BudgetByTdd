﻿using System;

namespace BudgetByTdd
{
    public class Accounting
    {
        private IBudgetRepository _budgetRepository;

        public Accounting(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        public decimal TotalAmount(DateTime start, DateTime end)
        {
            return 0;
        }
    }
}