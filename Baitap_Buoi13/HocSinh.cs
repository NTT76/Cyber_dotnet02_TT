class HocSinh
{
    public string maHS;
    public string tenHS;
    public int toan;
    public int van;
    public int anh;
    public HocSinh(string maHS, string tenHS, int toan, int van, int anh)
    {
        this.maHS = maHS;
        this.tenHS = tenHS;
        this.toan = toan;
        this.van = van;
        this.anh = anh;
    }
    public void xuatThongTin()
    {
        Console.WriteLine($"Mã học sinh: {maHS}, tên học sinh: {tenHS}, điểm toán: {toan}, điểm văn: {van}, điểm anh: {anh}");
    }
    public double diemTB
    {
        get { return (toan + van + anh) / 3; }
    }
}