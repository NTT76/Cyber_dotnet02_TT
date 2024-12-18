class ThoiTrang : SanPham
{
    public override double tinhGiaBan(double uuDai)
    {
        GiaBan = this.GiaGoc - (this.GiaGoc / 100 * uuDai);
        return GiaBan;
    }
    public ThoiTrang(string maSP, string tenSP, double giaGoc, double uuDai) : base(maSP, tenSP, giaGoc)
    {
        GiaBan = tinhGiaBan(uuDai);
    }
    public override void hienThiThongTin()
    {
        base.hienThiThongTin();
        Console.WriteLine($"Giá bán: {GiaBan}");
    }
}