using System;
using BankyStuffLibrary;
using Xunit;

namespace BankingTests
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Should_fail_if_withdrawal_larger_than_balance()
        {
            var account = new BankAccount("Joe", 10000);

            // Test for a negative balance:
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawal(80000, DateTime.Now, "foo bar"));
        }

        [Fact]
        public void Should_fail_if_deposit_negative()
        {
            var account = new BankAccount("Joe", 10000);

            // Test for accounts with negative balances
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("John", -500)
            );
        }
    }
}