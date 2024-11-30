class QuanLy : TruongNhom
{
    public string thuKy;
    public override double tinhLuong()
    {
        double luongCoBan = base.tinhLuong();
        return base.tinhLuong() + 500;
    }
}