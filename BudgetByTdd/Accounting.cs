﻿using System;
using System.Linq;

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
            var budgets = _budgetRepository.GetAll();
            var period = new Period(start, end);
            if (budgets.Any())
            {
                var budget = budgets[0];
                var overlappingDays = period.OverlappingDays(budget);
                var dailyAmount = budget.DailyAmount();
                return overlappingDays * dailyAmount;
            }
            return 0;
        }
    }
}