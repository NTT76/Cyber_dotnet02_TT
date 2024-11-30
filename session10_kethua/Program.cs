internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // 4 tính chất trong OOP
        // - Tính kế thừa: class con sẽ kế thừa (sở hữu) các thuộc tính (biến) và phương thức (hàm) của class cha
        // - Tính đóng gói
        // - Tính trừu tượng
        // - Tính đa hình

        //Bài tập mẫu: Trong công ty có 3 đối tượng: nhân viên, trưởng nhóm, quản lý.
        //Lập trình quản lý nhân sự trong công ty
        //Nhân viên: mã nhân viên, họ tên, ngày sinh, giới tính, tuổi, lương
        // tính lương: nhân viên = 1000
        //Trưởng nhóm: mã nhân viên, họ tên, ngày sinh, giới tính, tuổi, lương, mã quản lý nhóm
        // tính lương: 1000+ hệ số*1000
        //Quản lý: mã nhân viên, họ tên, ngày sinh, giới tính, tuổi, lương, mã quản lý nhóm, thư ký
        // tính lương: 1000+hệ số*1000+500
        TruongNhom truongNhom = new TruongNhom();
        truongNhom.tuoi = 24;
        Console.WriteLine($"Tuổi nhân viên: {truongNhom.tuoi}");

        //Phạm vi truy cập của thuộc tính và phương thức
        //public: có thể truy cập từ bất kỳ đâu: class con, bên ngoài class
        //private: chỉ có thể truy cập từ chính class đó
        //protected: class con có thể truy cập các thuộc tính của class cha, nhưng bên ngoài class con thì không thể truy cập

        QuanLy quanLy = new QuanLy();
        quanLy.luong = 10000;
        Console.WriteLine($"Lương của quản lý: {quanLy.luong}");
        Console.WriteLine(truongNhom.tinhLuong());
        Console.WriteLine(quanLy.tinhLuong());
        //C# check class QuanLy để tìm thuộc tính lương, nếu không có thì check class cha(TruongNhom),
        //nếu không có thì check class cha của class cha(NhanVien)

        //Lưu ý: override:
        // nếu class con không muốn các logic phương thức class cha
        // => có thể viết lại phương thức đó trong class con
        //nếu class con muốn dùng lại phương thưc class cha
        // => có thể dùng từ khóa base.tenPhuongThuc() để gọi phương thức của class cha

        //BT ôn lại
        //-Sinh viên, giảng viên, cán bộ trong trường
        //viết ct quản lý các đối tượng trên
        //class: Nguoi: ID, ten, ngaySinh, gioiTinh, email
        //Sinh Viên: ID, ten, ngaySinh, gioiTinh, email, lớp, điểm TB
        //giảng viên:ID, ten, ngaySinh, gioiTinh, email, chuyên ngành, học vị
        //cán bộ: ID, ten, ngaySinh, gioiTinh, email, chức vụ, phòng ban
    }
}