using TicketShop;

var calculator = new ShippingCalculator();

Console.WriteLine("Order total in whole kroner: ");

if (!int.TryParse(Console.ReadLine(), out int orderTotal) || orderTotal < 0)
{
    Console.WriteLine("Please enter a non-negative whole number.");
    return;
}

Console.Write("Are you a member? (y/n): ");
bool isMember = Console.ReadLine() == "y";

int shipping = calculator.CalculateShipping(orderTotal, isMember);
Console.WriteLine($"Shipping: {shipping} kr");