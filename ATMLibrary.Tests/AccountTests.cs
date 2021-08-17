using ATMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATMLibrary.Tests
{
    // This class represents AccountTests  -  a unittest area!
    public class AccountTests
    {
        [Fact]
        public void AddToAccount_ShouldAdd()
        {
            // Arrange!
            double expected = 100;

            // Act!
            double actual = Account.AddToAccount(0, 100);

            // Assert!
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(500,100,400)]
        [InlineData(1000,199.95,800.05)]
        public void WithDrawFromAccount_ShouldWithDraw(double x, double y, double expected) // Arrange is expected!
        {
            // Act!
            double actual = Account.WithDrawFromAccount(x, y);

            // Assert!
            Assert.Equal(expected, actual);
        }
    }
}
