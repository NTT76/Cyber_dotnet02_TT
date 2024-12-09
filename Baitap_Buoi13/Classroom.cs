using Newtonsoft.Json;
class Classroom
{
    public string classId;
    public string className;
    public List<HocSinh> hs;
    public Classroom(string classId, string className)
    {
        this.classId = classId;
        this.className = className;
        hs = new List<HocSinh>();
    }
    public void themHocSinh(HocSinh hocSinh)
    {
        hs.Add(hocSinh);
        Console.WriteLine($"Học sinh {hocSinh.tenHS} được thêm vào lớp {className}");
    }
    public void hienThiHS()
    {
        Console.WriteLine($"\n -----Học sinh trong {className}-----");
        foreach (HocSinh hocSinh in hs)
        {
            hocSinh.xuatThongTin();
        }
    }
    public void timHocSinh(string name)
    {
        foreach (HocSinh hocSinh in hs)
        {
            if (hocSinh.tenHS == name)
            {
                hocSinh.xuatThongTin();
                return;
            }
            else
            {
                Console.WriteLine($"Không tìm thấy học sinh nào tên {name}");
                break;
            }
        }
    }
    public void capNhatDiem(string name)
    {
        Console.WriteLine("Chọn điểm cần cập nhật");
        Console.WriteLine("1. Toán");
        Console.WriteLine("2. Văn");
        Console.WriteLine("3. Anh");
        int ints = Convert.ToInt32(Console.ReadLine());
        foreach (HocSinh hocSinh in hs)
        {
            while (hocSinh.tenHS == name)
            {
                if (ints == 1)
                {
                    Console.WriteLine("Nhập điểm môn toán: ");
                    hocSinh.toan = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                else if (ints == 2)
                {
                    Console.WriteLine("Nhập điểm môn văn: ");
                    hocSinh.van = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                else if (ints == 3)
                {
                    Console.WriteLine("Nhập điểm môn anh: ");
                    hocSinh.anh = Convert.ToInt32(Console.ReadLine());
                    break;
                }
            }
            if (hocSinh.tenHS != name)
            {
                Console.WriteLine("Không tìm thấy học sinh");
            }
            else { Console.WriteLine("Đã cập nhật điểm"); }
        }
    }
    public void diemTBvaHocLuc(string name)
    {
        foreach (HocSinh hocSinh in hs)
        {
            double diemTB = hocSinh.diemTB;
            if (hocSinh.tenHS == name)
            {
                if (diemTB >= 8 && diemTB <= 10)
                {
                    Console.WriteLine($"Điểm trung bình {diemTB}, xếp loại giỏi");
                    break;
                }
                else if (diemTB >= 6.5 && diemTB < 8)
                {
                    Console.WriteLine($"Điểm trung bình {diemTB}, xếp loại khá");
                    break;
                }
                else if (diemTB >= 5 && diemTB < 6.5)
                {
                    Console.WriteLine($"Điểm trung bình {diemTB}, xếp loại trung bình");
                    break;
                }
                else
                {
                    Console.WriteLine($"Điểm trung bình {diemTB}, xếp loại kém");
                    break;
                }
            }
            else { Console.WriteLine("Không tìm thấy học sinh"); break; }
        }
    }
    public void xoaHocSinh(string name)
    {
        for (int i = 0; i < hs.Count; i++)
        {
            if (hs[i].tenHS == name)
            {
                hs.RemoveAt(i);
                Console.WriteLine("xóa thành công");
                break;
            }
            else
            {
                Console.WriteLine("Không tồn tại học sinh này");
                break;
            }
        }
    }


    public void xepLoai()
    {
        Dictionary<string, string> hocLucHS = new Dictionary<string, string>();
        foreach (HocSinh hocSinh in hs)
        {
            double diemTB = hocSinh.diemTB;
            string hocLuc;
            if (diemTB >= 8 && diemTB <= 10)
            {
                hocLuc = "giỏi";
            }
            else if (diemTB >= 6.5 && diemTB < 8)
            {
                hocLuc = "khá";
            }
            else if (diemTB >= 5 && diemTB < 6.5)
            {
                hocLuc = "trung bình";
            }
            else
            {
                hocLuc = "kém";
            }
            hocLucHS.Add(hocSinh.tenHS, hocLuc);
        }
        foreach (KeyValuePair<string, string> key in hocLucHS)
        {
            Console.WriteLine($"Học sinh {key.Key} có học lực {key.Value}");
        }
    }

    public void hienThiTheoDiemTB()
    {
        List<HocSinh> result = hs.OrderBy(p => p.diemTB).ToList();
        foreach (HocSinh h in result)
        {
            h.xuatThongTin();
        }
    }
    public void hienThiTheoTenHS()
    {
        List<HocSinh> list = hs.OrderBy(p => p.tenHS).ToList();
        foreach (HocSinh hocSinh in hs)
        {
            hocSinh.xuatThongTin();
        }
    }
    public void ghiDuLieu()
    {
        //lưu danh sách sinh viên vào json
        //chuyển danh sách sv thành json
        var json = JsonConvert.SerializeObject(hs, Formatting.Indented);
        // lưu json vào file
        File.WriteAllText("students.json", json);

        Console.WriteLine("Add students successfully");
    }
    public void docDuLieu()
    {
        //hiển thị danh sách sv
        // đọc danh sách sv từ file json
        var studentsJson = File.ReadAllText("students.json");

        //chuyển json thành danh sách sv
        hs = JsonConvert.DeserializeObject<List<HocSinh>>(studentsJson);
        hienThiHS();
    }
}