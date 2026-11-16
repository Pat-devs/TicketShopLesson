namespace TicketShop;

public class ShippingCalculator
{
    public int CalculateShipping(int orderTotal, bool isMember)
    {
        if (isMember || orderTotal >= 500)
        {
            return 0;
        }

        return 79;
    }
}
