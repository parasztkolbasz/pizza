using Xunit;
using Pizzeria;

namespace Pizzeria.Tests
{
    public class OrderCalculatorTests
    {
     

        [Fact]
        public void CalculateOrderTotal_ZeroPizzaCount()
        {
            // Arrange
            var calculator = new OrderCalculator();

            // Act
            int result = calculator.CalculateOrderTotal(0, false);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void CalculateOrderTotal_NegativePizzaCount()
        {
            // Arrange
            var calculator = new OrderCalculator();

            // Act
            int result = calculator.CalculateOrderTotal(-2, false);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void CalculateOrderTotal_MoreThanMaximum()
        {
            // Arrange
            var calculator = new OrderCalculator();

            // Act
            int result = calculator.CalculateOrderTotal(21, false);

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void CalculateOrderTotal_MaximumPizzaCount()
        {
            // Arrange
            var calculator = new OrderCalculator();

            // Act
            int result = calculator.CalculateOrderTotal(20, false);

            // Assert
            Assert.Equal(45000, result);
        }


        [Fact]
        public void CalculateOrderTotal_OnePizza()
        {
            // Arrange
            var calculator = new OrderCalculator();

            // Act
            int result = calculator.CalculateOrderTotal(1, false);

            // Assert
            Assert.Equal(2500, result);
        }

        [Fact]
        public void CalculateOrderTotal_ThreePizzasWithoutDiscount()
        {
            // Arrange
            var calculator = new OrderCalculator();

            // Act
            int result = calculator.CalculateOrderTotal(3, false);

            // Assert
            Assert.Equal(7500, result);
        }

        [Fact]
        public void CalculateOrderTotal_FourPizzaDiscount()
        {
            // Arrange
            var calculator = new OrderCalculator();

            // Act
            int result = calculator.CalculateOrderTotal(4, false);

            // Assert
            Assert.Equal(9000, result);
        }

        

        [Fact]
        public void CalculateOrderTotal_OnePizzaWithDelivery()
        {
            // Arrange
            var calculator = new OrderCalculator();

            // Act
            int result = calculator.CalculateOrderTotal(1, true);

            // Assert
            Assert.Equal(3000, result);
        }

        [Fact]
        public void CalculateOrderTotal_FourPizzasWithDelivery()
        {
            // Arrange
            var calculator = new OrderCalculator();

            // Act
            int result = calculator.CalculateOrderTotal(4, true);

            // Assert
            Assert.Equal(9500, result);
        }
    }
}