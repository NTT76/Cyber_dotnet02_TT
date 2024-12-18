class ThucPham : SanPham
{
    public override double tinhGiaBan(double phi)
    {
        GiaBan = this.GiaGoc + phi;
        return GiaBan;
    }
    public ThucPham(string maSP, string tenSP, double giaGoc, double phi) : base(maSP, tenSP, giaGoc)
    {
        GiaBan = tinhGiaBan(phi);
    }
    public override void hienThiThongTin()
    {
        base.hienThiThongTin();
        Console.WriteLine($"Giá bán: {GiaBan}");
    }
}