class DienTu : SanPham
{
    public override double tinhGiaBan(double thue)
    {
        GiaBan = this.GiaGoc + (this.GiaGoc / 100 * thue);
        return GiaBan;
    }
    public DienTu(string maSP, string tenSP, double giaGoc, double thue) : base(maSP, tenSP, giaGoc)
    {
        GiaBan = tinhGiaBan(thue);
    }
    public override void hienThiThongTin()
    {
        base.hienThiThongTin();
        Console.WriteLine($"Giá bán: {GiaBan}");
    }
}