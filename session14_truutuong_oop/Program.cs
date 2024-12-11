internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        NhanVien nv1 = new TruongPhong("NV01", "Trong Thin", 1000, 1.5);
        Console.WriteLine($"Lương của Trong Thin: {nv1.tinhLuong()}");
        Animal dog = new Animal("Dog");
        dog.eat();
        dog.sleep();

        //Bài tập về quản lý khách sạn
        //sbstract class: Room
        // - roomId: string
        // - roomName: string
        // - basePrice: double


        // class con:
        // - NormalRoom: Room
        // - LuxuryRoom: Room
        //      + extraService: string
        // - SuitedRoom: Room
        //      + extraService: string
        //      + premiumService: string

        // thêm interface
        // - IWifi: bool hashWifi()

        // class Hotel

        Room normalRoom = new NormalRoom("01", "dan1", 500);
        Room luxuryRoom = new LuxuryRoom("02", "quan", 500, "free breakfast");
        Room suiteRoom = new SuiteRoom("03", "vua", 500, "free breakfast", "free massage");

        Console.WriteLine($"Price of normal room: {normalRoom.calculatePrice()}");
        Console.WriteLine($"Price of normal room: {luxuryRoom.calculatePrice()}");
        Console.WriteLine($"Price of normal room: {suiteRoom.calculatePrice()}");
    }
}