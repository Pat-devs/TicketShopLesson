namespace TicketShop;

public class ShippingCalculator
{
    public int CalculateShipping(int orderTotal, bool isMember)
    {
        if (orderTotal < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(orderTotal));
        }
        if (isMember || orderTotal >= 500)
        {
            return 0;
        }

        return 79;
    }
}
