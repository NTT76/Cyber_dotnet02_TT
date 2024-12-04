using Newtonsoft.Json;
class KhoHang
{
    public string maKho;
    public string tenKho;
    List<SanPham> sp;
    public KhoHang(string maKho, string tenKho)
    {
        this.maKho = maKho;
        this.tenKho = tenKho;
        sp = new List<SanPham>();
    }
    public void themSP(SanPham sanPham)
    {
        sp.Add(sanPham);
        Console.WriteLine($"{sanPham.tenSP} đã được thêm vào kho {tenKho}");
    }
    public void hienThiHS()
    {
        Console.WriteLine($"\n -----Sản phẩm trong {tenKho}-----");
        foreach (SanPham sanPham in sp)
        {
            sanPham.xuatThongTin();
        }
    }
    public void timSP(string name)
    {
        foreach (SanPham sanPham in sp)
        {
            if (sanPham.tenSP == name)
            {
                sanPham.xuatThongTin();
                return;
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sản phẩm nào tên {name}");
            }
        }
    }
    public void capNhatGiaHoacSoLuong(string name, int a)
    {
        switch (a)
        {
            case 1:
                foreach (SanPham sanPham in sp)
                {
                    if (sanPham.tenSP == name)
                    {
                        Console.WriteLine("Nhập giá trị mới của sản phẩm: ");
                        sanPham.giaBan = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Cập nhật thành công");
                        break;
                    }
                    else { Console.WriteLine("Không tìm thấy sản phẩm"); break; }
                }
                break;
            case 2:
                foreach (SanPham sanPham in sp)
                {
                    if (sanPham.tenSP == name)
                    {
                        Console.WriteLine("Nhập số lượng mới của sản phẩm: ");
                        sanPham.soLuong = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cập nhật thành công");
                        break;
                    }
                    else { Console.WriteLine("Không tìm thấy sản phẩm"); break; }
                }
                break;
            default:
                break;
        }
    }
    public void tongGiaTriKho(string name)
    {
        double tong = 0;
        foreach (SanPham sanPham in sp)
        {
            if (sanPham.tenSP == name)
            {
                tong = sanPham.giaBan * sanPham.soLuong;
                Console.WriteLine($"Tổng giá trị {sanPham.tenSP} là: {tong}");
                return;
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sản phẩm nào tên {name}");
            }
        }
    }
    public void xoaSP(string Id)
    {
        for (int i = 0; i < sp.Count; i++)
        {
            int check = 0;
            if (String.Compare(Id, sp[i].tenSP, true) == 0)
            {
                sp.RemoveAt(i);
                Console.WriteLine("xóa thành công");
                check = 1;
                break;
            }
            if (check == 0)
            {
                Console.WriteLine("Không tồn tại Sản phẩm này");
                break;
            }
        }
    }
    public void danhSachSPVaGiaTri()
    {
        Dictionary<string, double> tongGiaTri = new Dictionary<string, double>();
        foreach (SanPham sanPham in sp)
        {
            double tong = sanPham.giaBan * sanPham.soLuong;
            tongGiaTri.Add(sanPham.tenSP, tong);
        }
        foreach (KeyValuePair<string, double> key in tongGiaTri)
        {
            Console.WriteLine($"Sản phẩm {key.Key} có tổng giá trị bằng: {key.Value}");
        }
    }

    public void sapXepSPTheoGiaBan()
    {
        SortedDictionary<double, string> sapXepGiaBanTang = new SortedDictionary<double, string>();
        foreach (SanPham sanPham in sp)
        {
            double tong = sanPham.giaBan * sanPham.soLuong;
            sapXepGiaBanTang.Add(tong, sanPham.tenSP);
        }
    }
    public void hienThiTheoGiaBanTang()
    {
        // Dictionary<double, string> sapXep = sapXepSPTheoGiaBan().sapXepGiaBanTang;
        SortedDictionary<double, string> sapXepGiaBanTang = new SortedDictionary<double, string>();
        foreach (SanPham sanPham in sp)
        {
            double tong = sanPham.giaBan * sanPham.soLuong;
            sapXepGiaBanTang.Add(tong, sanPham.tenSP);
        }
        foreach (KeyValuePair<double, string> key in sapXepGiaBanTang)
        {
            Console.WriteLine($"{key.Value}: {key.Key}");
        }
    }
    public void sapXepTheoTenSP()
    {
        List<string> list = new List<string>();
        foreach (SanPham sanPham in sp)
        {
            string[] str = sanPham.tenSP.Split(' ');
            for (int i = str.Length - 1; i >= 0; i--)
            {
                list.Add(str[i]);
                break;
            }
        }
        list.Sort();
    }
    public void hienThiTheoTenSP()
    {
        List<string> list = new List<string>();
        foreach (SanPham sanPham in sp)
        {
            string[] str = sanPham.tenSP.Split(' ');
            for (int i = str.Length - 1; i >= 0; i--)
            {
                list.Add(str[i]);
                break;
            }
        }
        list.Sort();
        foreach (string str2 in list)
        {
            Console.WriteLine($"{str2}");
        }
    }
    public void ghiFileJson()
    {
        //lưu danh sách sinh viên vào json
        //chuyển danh sách sv thành json
        var json = JsonConvert.SerializeObject(sp, Formatting.Indented);
        // lưu json vào file
        File.WriteAllText("sanpham.json", json);

        Console.WriteLine("Add students successfully");
    }
    public void docFileJson()
    {
        //hiển thị danh sách sv
        // đọc danh sách sv từ file json
        var studentsJson = File.ReadAllText("sanpham.json");

        //chuyển json thành danh sách sv
        sp = JsonConvert.DeserializeObject<List<SanPham>>(studentsJson);
        hienThiHS();
    }
}