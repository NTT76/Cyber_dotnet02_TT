using System.Runtime.CompilerServices;

class Fashion : Product
{
    private string size;
    public string Size
    {
        get { return size; }
        set
        {
            List<string> validSize = new List<string> { "S", "M", "L", "XL", "XXL" };
            if (string.IsNullOrWhiteSpace(value) || !validSize.Contains(value))
            {
                // !validSize.Contais(value) => value không nằm trong validSize
                throw new ArgumentException("Size must be S, M, L, XL, XXL");
            }
        }
    }
    public Fashion(
        int productId,
        string productName,
        double price,
        string description,
        string size
    ) : base(productId, productName, price, description)
    {
        Size = size;
    }
    public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine($"Size: {Size}");
    }
}