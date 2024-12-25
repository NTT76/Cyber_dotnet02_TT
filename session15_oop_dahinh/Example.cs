abstract class Animal
{
    private string name;
    public string Name { get; set; }
    public Animal(string name)
    {
        this.name = name;
    }
    public abstract void Speak();
    public abstract void displayInfo();
}

class Dog : Animal
{
    private string breed; // giống chó
    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }
    public Dog(string name, string breed) : base(name)
    {
        this.breed = breed;
    }
    public override void Speak()
    {
        Console.WriteLine("gâu gâu");
    }
    public override void displayInfo()
    {
        Console.WriteLine($"Name: {Name}, Breed: {breed}");
    }
}

class Cat : Animal
{
    private string color;
    public string Color { get; set; }
    public Cat(string name, string color) : base(name)
    {
        this.color = color;
    }
    public override void Speak()
    {
        Console.WriteLine("meo meo");
    }
    public override void displayInfo()
    {
        Console.WriteLine($"Name: {Name}, Color: {Color}");
    }
}