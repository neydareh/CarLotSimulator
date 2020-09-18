using CarLotSimulator;
using System;
using Xunit;

namespace xCarLotSimulator
{
    public class UnitTest1
    {
        [Fact]
        public void TestDriveable()
        {
            // Arrange
            var testCar = new Car();
            testCar.IsDriveable = false;
            // Act
            var actual = testCar.IsDriveable;
            // Assert
            Assert.True(actual);
        }
    }
}
