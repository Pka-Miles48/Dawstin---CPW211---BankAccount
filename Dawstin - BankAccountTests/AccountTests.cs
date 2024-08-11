﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dawstin___BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dawstin___BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void Deposit_APositiveAmount_AddToBalance()
        {
            Account acc = new("J. Doe");
            acc.Deposit(100);

            Assert.AreEqual(100, acc.Balance);
        }

        [TestMethod]
        public void Deposit_APositiveAmount_ReturnsUpdateBalance()
        {
            // AAA - Arrange Act Assert
            // Arrange
            Account acc = new Account("J. Doe");
            double depositAmount = 100;
            double expectedReturn = 100;

            // Act
            double returnValue = acc.Deposit(depositAmount);

            // Assert
            Assert.AreEqual(expectedReturn, returnValue);
        }
    }
}