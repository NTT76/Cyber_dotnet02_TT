class HocSinh
{
    public string hoTen;
    public int tuoi;
    public string gioiTinh;
    public string mail;
    // public void nhapThongTin()
    // {
    //     Console.WriteLine("nhập thông tin học sinh");
    //     Console.WriteLine("nhập họ tên: ");
    //     hoTen = Console.ReadLine();
    //     Console.WriteLine("nhập tuổi: ");
    //     tuoi = Console.ReadLine(Convert.ToInt32(hoTen));
    //     Console.WriteLine("nhập giới tính: ");
    //     gioiTinh = Console.ReadLine();
    //     Console.WriteLine("nhập mail : ");
    //     mail = Console.ReadLine();
    // }

    public void xuatThongTin()
    {
        Console.WriteLine($"Học sinh: {hoTen}");
        Console.WriteLine($"{tuoi} tuổi");
        Console.WriteLine($"{gioiTinh}");
        Console.WriteLine($"{mail}");
    }
}