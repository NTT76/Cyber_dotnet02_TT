class SanPham
{
    private string maSP;
    public string MaSP
    {
        get { return maSP; }
        set { maSP = value; }
    }
    private string tenSP;
    public string TenSP
    {
        get { return tenSP; }
        set { tenSP = value; }
    }
    private double giaSP;
    public double GiaSP
    {
        get { return giaSP; }
        set { giaSP = value; }
    }
    public SanPham(string maSP, string tenSP, double giaSP)
    {
        this.maSP = maSP;
        this.tenSP = tenSP;
        this.giaSP = giaSP;
    }
    public void xuatThongTin()
    {
        Console.WriteLine($"Mã sản phẩm: {maSP}, tên sản phẩm: {tenSP}, giá sản phẩm: {giaSP}");
    }
}