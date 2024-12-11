abstract class NhanVien
{
    private string maNV;
    public string MaNV
    {
        get { return maNV; }
        set { maNV = value; }
    }
    private string tenNV;
    public string TenNV
    {
        get { return tenNV; }
        set { tenNV = value; }
    }
    private double luongCoBan;
    public double LuongCoBan
    {
        get { return luongCoBan; }
        set { luongCoBan = value; }
    }

    public NhanVien(string maNV, string tenNV, double luongCoBan)
    {
        this.maNV = maNV;
        this.tenNV = tenNV;
        this.luongCoBan = luongCoBan;
    }

    public void chamCong()
    {
        Console.WriteLine("Cham cong");
    }

    //hàm abstract này không có thân hàm
    public abstract double tinhLuong();
}