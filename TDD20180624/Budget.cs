﻿using System;

namespace BudgetByTdd
{
    public class Budget
    {
        public string YearMonth { get; set; }
        public int Amount { get; set; }

        private DateTime FirstDay
        {
            get
            {
                return DateTime.ParseExact(YearMonth + "01", "yyyyMMdd", null);
            }
        }

        private DateTime LastDay
        {
            get
            {
                return DateTime.ParseExact(YearMonth + DaysInMonth, "yyyyMMdd", null);
            }
        }

        private int DaysInMonth
        {
            get
            {
                return DateTime.DaysInMonth(FirstDay.Year, FirstDay.Month);
            }
        }

        private int DailyAmount()
        {
            return Amount / DaysInMonth;
        }

        private Period GetPeriod()
        {
            return new Period(FirstDay, LastDay);
        }

        public decimal OverlapAmount(Period period)
        {
            return period.OverlappingDays(GetPeriod()) * DailyAmount();
        }
    }
}