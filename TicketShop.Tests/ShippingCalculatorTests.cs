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
    [Fact]
    public void CalculateShipping_Member_ReturnsZero()
    {
        var calculator = new ShippingCalculator();
        int actual = calculator.CalculateShipping(100, true);

        Assert.True(actual == 0);
        Assert.False(actual > 0);
        Assert.NotEqual(79, actual);
    }

    [Theory]
    [InlineData(0, false, 79)]
    [InlineData(499, false, 79)]
    [InlineData(500, false, 0)]
    [InlineData(501, false, 0)]
    [InlineData(100, true, 0)]
    public void CalculateShipping_ValidInputs_ReturnsExpected(int orderTotal, bool isMember, int expected)
    {
        var calculator = new ShippingCalculator();
        int actual = calculator.CalculateShipping(orderTotal, isMember);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CalculateShipping_NegativeTotal_ThrowsException()
    {
        var calculator = new ShippingCalculator();

        var exception = Assert.Throws<ArgumentOutOfRangeException>(
            () => calculator.CalculateShipping(-1, false)
        ); 

        Assert.Equal("orderTotal", exception.ParamName);
    }
}
