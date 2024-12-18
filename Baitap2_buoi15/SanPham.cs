abstract class SanPham
{
    private string maSP;
    public string MaSP { get { return maSP; } set { maSP = value; } }
    private string tenSP;
    public string TenSP { get { return tenSP; } set { tenSP = value; } }
    private double giaGoc;
    public double GiaGoc { get { return giaGoc; } set { giaGoc = value; } }
    private double giaBan;
    public double GiaBan { get { return giaBan; } set { giaBan = value; } }
    public SanPham(string maSP, string tenSP, double giaGoc)
    {
        this.maSP = maSP;
        this.tenSP = tenSP;
        this.giaGoc = giaGoc;
    }
    public SanPham()
    {

    }
    public abstract double tinhGiaBan(double x);
    public virtual void hienThiThongTin()
    {
        Console.Write($"Mã: {maSP}, Tên: {tenSP}, ");
    }

}