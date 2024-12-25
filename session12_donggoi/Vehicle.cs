class Vehicle
{
    private string vehicleId; // mã phương tiện
    public string VehicleId
    {
        get { return vehicleId; }
        set { vehicleId = value; }
    }
    private string brand; //hãng xe
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }
    private int year; //năm sản xuất;
    public int Year
    {
        get { return year; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Năm sản xuất không hợp lệ");
                year = value;
            }
        }
    }
    private double price; // giá xe
    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Giá xe không hợp lệ");
            }
            price = value;
        }
    }
    //contructor
    public Vehicle(string vehicleId, string brand, int year, double price)
    {
        VehicleId = vehicleId;
        Brand = brand;
        Year = year;
        Price = price;
    }
    public virtual void displayInfo()
    {
        Console.WriteLine($"Mã phương tiện: {VehicleId}");
        Console.WriteLine($"Hãng: {Brand}");
        Console.WriteLine($"Năm sản xuất: {Year}");
        Console.WriteLine($"Giá : {Price}");
    }
}