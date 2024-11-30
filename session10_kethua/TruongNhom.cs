class TruongNhom : NhanVien
{
    public string maNhom;
    public string getMaNV()
    {
        return this.maNV;

    }
    public override double tinhLuong()
    {
        double luongCoBan = base.tinhLuong();
        return luongCoBan + 1.5 * luongCoBan;
    }
}