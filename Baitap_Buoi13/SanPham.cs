class SanPham
{
    public string maSP;
    public string tenSP;
    public double giaBan;
    public int soLuong;
    public SanPham(string maSP, string tenSP, double giaBan, int soLuong)
    {
        this.maSP = maSP;
        this.tenSP = tenSP;
        this.giaBan = giaBan;
        this.soLuong = soLuong;
    }
    // public override string ToString()
    // {
    //     return tenSP;
    // }
    public void xuatThongTin()
    {
        Console.WriteLine($"{maSP} : {tenSP} có giá {giaBan}. Còn {soLuong}");
    }
}

// B chay lai xem