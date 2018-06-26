using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace BudgetByTdd
{
    [TestClass]
    public class AccountingTests
    {
        private IBudgetRepository _budgetRepository = Substitute.For<IBudgetRepository>();
        private Accounting _accounting;

        [TestInitialize]
        public void TestInit()
        {
            _accounting = new Accounting(_budgetRepository);
        }

        [TestMethod]
        public void no_budgets()
        {
            AmountShouldBe("20180601", "20180601", 0m);
        }

        private void AmountShouldBe(string startTime, string endTime, decimal expected)
        {
            var start = DateTime.ParseExact(startTime, "yyyyMMdd", null);
            var end = DateTime.ParseExact(endTime, "yyyyMMdd", null);
            var totalAmount = _accounting.TotalAmount(start, end);
            Assert.AreEqual(expected, totalAmount);
        }
    }
}