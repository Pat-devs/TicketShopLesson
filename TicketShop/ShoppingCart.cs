namespace TicketShop;

public class ShoppingCart
{
    private readonly List<string> _items = new();

    public int Count
    {
        get { return _items.Count; }
    }
    public void Add(string item)
    {
        _items.Add(item);
    }
    public bool Contains(string item)
    {
        return _items.Contains(item);
    }
    public List<string> GetItems()
    {
        return new List<string>(_items);
    }
    public bool Remove(string item)
    {
        return false; // will implement later :)
    }
}