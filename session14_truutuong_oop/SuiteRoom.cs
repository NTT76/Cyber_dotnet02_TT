using System.Xml.Schema;

class SuiteRoom : Room
{
    private string extraService;
    public string ExtraService { get; set; }

    private string premiumService;
    public string premiumServices { get; set; }

    public SuiteRoom(
        string roomId,
        string roomName,
        double basePrice,
        string extraService,
        string premiumService
        ) : base(roomId, roomName, basePrice)
    {
        this.extraService = extraService;
        this.premiumService = premiumService;
    }

    public override double calculatePrice()
    {
        return BasePrice + 200;
    }

    public override void displauInfo()
    {
        base.displauInfo();
        Console.WriteLine($"Premium Service: {premiumService}");
    }
}