using System;

namespace BudgetByTdd
{
    public class Period
    {
        public Period(DateTime start, DateTime end)
        {
            if (end < start)
            {
                throw new ArgumentException();
            }
            Start = start;
            End = end;
        }

        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public decimal OverlappingDays(Period overPeriod)
        {
            if (HasNoOverlap(overPeriod))
            {
                return 0;
            }

            var overlapStart = Start > overPeriod.Start ? Start : overPeriod.Start;
            var overlapEnd = End < overPeriod.End ? End : overPeriod.End;

            return (overlapEnd - overlapStart).Days + 1;
        }

        private bool HasNoOverlap(Period overPeriod)
        {
            return End < overPeriod.Start || Start > overPeriod.End;
        }
    }
}