class NhanVien
{
    protected string maNV;
    private string hoTen { get; set; }
    //Mục đích dùng getter và setter để truy cập vào các thuộc tính privete
    public string gioiTinh;
    public string ngaySinh;
    public int tuoi;
    public double luong;

    // overload: nạp chồng phương thức
    // override: ghi đè phương thức của class cha
    public virtual double tinhLuong()
    {
        return 1000;
    }
}