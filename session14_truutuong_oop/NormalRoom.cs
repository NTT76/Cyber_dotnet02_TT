class NormalRoom : Room
{
    public NormalRoom(
        string roomId,
        string roomName,
        double basePrice
    ) : base(roomId, roomName, basePrice) { }

    public override double calculatePrice()
    {
        return this.BasePrice;
    }
}