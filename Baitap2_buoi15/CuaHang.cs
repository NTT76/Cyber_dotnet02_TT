using Newtonsoft.Json;
class CuaHang
{
    private string tenCH;
    public string TenCH { get { return tenCH; } set { tenCH = value; } }
    List<SanPham> sanPhams;
    public CuaHang(string tenCH)
    {
        this.tenCH = tenCH;
        sanPhams = new List<SanPham>();
    }
    public void themSP(SanPham sanPham)
    {
        sanPhams.Add(sanPham);
    }
    public void DanhSachSP()
    {
        foreach (SanPham sanPham in sanPhams)
        {
            sanPham.hienThiThongTin();
        }
    }
    public void ghiDuLieu()
    {
        //lưu danh sách sinh viên vào json
        //chuyển danh sách sv thành json
        string json = JsonConvert.SerializeObject(sanPhams, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        });
        // lưu json vào file
        File.WriteAllText("sanpham.json", json);
    }
    public void hienThiDanhSachSP()
    {
        Console.WriteLine("Danh sách sản phẩm: ");
        string sanPhamJson = File.ReadAllText("sanpham.json");

        //chuyển json thành danh sách sv
        List<SanPham>? sanPhams1 = JsonConvert.DeserializeObject<List<SanPham>>(sanPhamJson, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        });
        foreach (SanPham sp in sanPhams1)
        {
            sp.hienThiThongTin();
        }
    }
    public double tongDoanhThu()
    {
        double tong = 0;
        foreach (SanPham sp in sanPhams)
        {
            tong += sp.GiaBan;
        }
        Console.WriteLine(tong);
        return tong;
    }
    public void xoaSP(string id)
    {
        for (int i = 0; i < sanPhams.Count; i++)
        {
            if (sanPhams[i].MaSP == id)
            {
                sanPhams.ElementAt(i);
                Console.WriteLine("Xóa thành công");
            }
            else Console.WriteLine("Sản phẩm không tồn tại");
        }
    }
}