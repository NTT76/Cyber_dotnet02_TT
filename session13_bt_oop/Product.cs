class Product
{
    private int productId;
    // integer: AUTO_INCREMENT
    //string (uuud): 
    public int ProductId
    {
        get { return productId; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("ID must be greater than 0");
            }
            productId = value;
        }
    }
    // exception:
    // 5 loại lỗi phổ biến
    //1. Lỗi logic và tham số (ArgumentException,...)
    //2. Lỗi dữ liệu (FormatException,..)
    //3. Lỗi hệ thống
    //4. Lỗi I/O và mạng
    //5. Lỗi luồng và đa nhiệm

    private string productName;
    public string ProductName
    {
        get { return productName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Product name must not be empty");
            }
            productName = value;
        }
    }
    private double price;
    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price must be greater than 0");
            }
            price = value;
        }
    }
    private string description;
    public string Description
    {
        get { return description; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Description name must not be empty");
            }
            description = value;
        }
    }
    public Product(int productId, string productName, double price, string description)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        Description = description;
    }

    // static method
    // - function này không dùng tới các thuộc tính của đối tượng
    // - function này không cần phải khởi tạo đối tượng
    // VD: Product.sum(1,2);
    // - còn nếu k dùng static thì phải khởi tạo đối tượng
    public static int sum(int num1, int num2) { return num1 + num2; }
    public virtual void displayInfo()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Prics: {Price}");
        Console.WriteLine($"Descriptions: {Description}");
    }
}
