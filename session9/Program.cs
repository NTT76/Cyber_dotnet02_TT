internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // bản chất của OOP đó chính là gom nhóm các biến
        // các biến được gọi là các thuộc tính
        // chữ cái đầu tiên của class phải là in hoa
        BaiViet baiviet1 = new BaiViet();
        baiviet1.tieuDe = "Trọng Thìn";
        baiviet1.noiDung = "yêu Yến";
        baiviet1.hinhAnh = "hinh.pnj";
        baiviet1.xuatThongTin();

        Console.WriteLine("========================");

        BaiViet baiviet2 = new BaiViet();
        baiviet2.tieuDe = " Hải Yến";
        baiviet1.noiDung = "yêu thìn";
        baiviet1.hinhAnh = "hinh2.pnj";
        baiviet2.xuatThongTin();

        Console.WriteLine("========================");

        BaiViet baiviet3 = new BaiViet(baiviet1);
        Console.WriteLine($"kiểm tra: {baiviet3 == baiviet1}");
        baiviet3.hinhAnh = "hinh3.png";
        Console.WriteLine(baiviet1.hinhAnh);

        BaiViet baiviet4 = new BaiViet();
        baiviet4.tieuDe = baiviet1.tieuDe;
        baiviet4.noiDung = baiviet1.noiDung;
        baiviet4.hinhAnh = baiviet1.hinhAnh;
        Console.WriteLine($"kiểm tra: {baiviet4 == baiviet1}");

        BaiViet baiviet5 = new BaiViet();
        Console.WriteLine($"giá trị mặc định của thuộc tính nội dung là: {baiviet5.noiDung}");
        //default value của các biến có kiểu dữ liệu string là null
        //của integer là số 0
        //của boolean là số 0 (0 và 1)

        // bài tập nhập môn
        //tạo đối tượng HS(họ tên, tuổi , giới tính, mail)
        //xuất thông tin học sinh đó
        HocSinh hs = new HocSinh();
        hs.hoTen = "Trọng Thìn";
        hs.tuoi = 24;
        hs.gioiTinh = "nam";
        hs.mail = "thin@gmail.com";
        hs.xuatThongTin();

        //Bài tập về nhà
        //bài 1: tạo đối tượng sản phẩm(tên sp, giá bán, số lượng tồn kho)
        //nhập xuất tt

        //bài 2: tạo đối tượng hình chữ nhật (chiều dài, chiều rộng)
        //nhập tt, tính chu vi diện tích
    }
}