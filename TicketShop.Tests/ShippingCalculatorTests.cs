using TicketShop;

namespace TicketShop.Tests;

public class ShippingCalculatorTests
{
    [Fact]
    public void CalculateShipping_Below500ForNonMember_Returns79()
    {
        // Arrange
        var calculator = new ShippingCalculator();

        // Act
        int actual = calculator.CalculateShipping(100, false);

        // Assert 
        Assert.Equal(79, actual); 
    }
    [Fact]
    public void CalculateShipping_At500ForNonMember_ReturnsZero()
    {
        var calculator = new ShippingCalculator();
        int actual = calculator.CalculateShipping(500, false);
        Assert.Equal(0, actual);
    }
}
