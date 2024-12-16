using Newtonsoft.Json;
class LichSuThanhToan
{
    public string id;
    public List<SanPham> sp;
    public LichSuThanhToan(string id)
    {
        this.id = id;
        sp = new List<SanPham>();
    }
    public void lichSu(SanPham sanPham, bool check)
    {
        if (check == true)
        {
            sp.Add(sanPham);
        }
    }
    public void hienThiSP()
    {
        foreach (SanPham sanPham in sp)
        {
            sanPham.xuatThongTin();
        }
    }
    public void ghiDuLieu()
    {
        //lưu danh sách sinh viên vào json
        //chuyển danh sách sv thành json
        var json = JsonConvert.SerializeObject(sp, Formatting.Indented);
        // lưu json vào file
        File.WriteAllText("sanpham.json", json);
    }
    public void hienThiLichSu()
    {
        var sanPhamJson = File.ReadAllText("sanpham.json");

        //chuyển json thành danh sách sv
        sp = JsonConvert.DeserializeObject<List<SanPham>>(sanPhamJson);
        hienThiSP();
    }
}