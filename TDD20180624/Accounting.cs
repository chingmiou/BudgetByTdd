﻿using System;

namespace BudgetByTdd
{
    public class Accounting
    {
        private readonly IBudgetRepository _budgetRepository;

        public Accounting(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        public decimal GetTotalAmount(DateTime start, DateTime end)
        {
            return 0;
        }
    }
}