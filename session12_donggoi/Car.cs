class Car : Vehicle
{
    private string model; // dòng xe
    public string Model
    {
        get { return model; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Dòng xe không hợp lệ");
            }
            model = value;
        }
    }
    private string color; // màu xe
    public string Color
    {
        get { return color; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Màu xe không hợp lệ");
            }
            color = value;
        }
    }
    private int engine; //dung tích xe
    public int Engine
    {
        get { return engine; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Dung tích xe không hợp lệ");
            }
            engine = value;
        }
    }
    public Car(
        string vehicleId,
        string brand,
        int year,
        double price,
        string model,
        string color,
        int engine
    ) : base(vehicleId, brand, year, price)
    {
        Model = model;
        Color = color;
        Engine = engine;
    }
    public override void displayInfo()
    {
        base.displayInfo();
        Console.WriteLine($"Dòng xe: {Model}");
        Console.WriteLine($"Màu xe: {Color}");
        Console.WriteLine($"Dung tích: {Engine}");
    }
}