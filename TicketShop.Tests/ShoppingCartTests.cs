using TicketShop;

namespace TicketShop.Tests;

public class ShoppingCartTests
{
    [Fact]
    public void NewCart_IsEmpty()
    {
        var cart = new ShoppingCart();

        Assert.Equal(0, cart.Count);
        Assert.Empty(cart.GetItems());
    }
    [Fact]
    public void Add_OneItem_MakesItAvailable()
    {
        var cart = new ShoppingCart();

        cart.Add("Milk");

        Assert.Single(cart.GetItems());
        Assert.Contains("Milk", cart.GetItems());
        Assert.True(cart.Contains("Milk"));
    }

    [Fact]
    public void GetItems_ReturnsCopy_ChangingItDoesNotChangeCart()
    {
        var cart = new ShoppingCart();
        cart.Add("Milk");

        List<string> snapshot = cart.GetItems();
        snapshot.Add("Bread");

        Assert.Equal(1, cart.Count);
        Assert.DoesNotContain("Bread", cart.GetItems());
    }
}