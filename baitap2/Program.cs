// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
#region bài 1
//tính số ngày trong tuần và số ngày lẻ
//input: số ngày
Console.WriteLine("Nhập số ngày: ");
string soNgay = Console.ReadLine();
int formatSoNgay = Convert.ToInt32(soNgay);

//output: bao nhiêu tuần và còn lẻ bao nhiêu ngày
int tuan = 0;
int leNgay = 0;
//process
tuan = formatSoNgay / 7;
leNgay = formatSoNgay % 7;

Console.WriteLine(formatSoNgay + " là " + tuan + " tuần và " + leNgay + " ngày lẻ.");
#endregion

#region bài 2
//tính giá trị đơn hàng sau giảm giá
//input: giá trị đơn hàng và % giảm giá
Console.WriteLine("Nhập giá trị đơn hàng: ");
string giaTri = Console.ReadLine();
double formatGiaTri = Convert.ToDouble(giaTri);
Console.WriteLine("Nhập phần trăm giảm giá:");
string uuDai = Console.ReadLine();
double formatUuDai = Convert.ToDouble(uuDai);

//output: số tiền được giảm và số tiền phải thanh toán
double giam = 0;
double thanhToan = 0;

//process
giam = (formatGiaTri / 100) * formatUuDai;
thanhToan = formatGiaTri - giam;

Console.WriteLine("Đơn hàng " + formatGiaTri + " ưu đãi " + formatUuDai + "% giảm " + giam + " còn " + thanhToan);
#endregion

#region bài 3
//chuyển đổi phút sang giờ và phút
//input: phút
Console.WriteLine("Nhập số phút: ");
string soPhut = Console.ReadLine();
int formatSoPhut = Convert.ToInt32(soPhut);

//output: giờ và phút
int gio = 0;
int phut = 0;

//process
gio = formatSoPhut / 60;
phut = formatSoPhut % 60;

Console.WriteLine(formatSoPhut + " phút bằng " + gio + " giờ " + phut + " phút.");
#endregion

#region bài 4
//tính tổng tiền sau khi thêm thuế VAT
//input: số tiền gốc và tỷ lệ thuế VAT
Console.WriteLine("Nhập tổng tiền: ");
string tienGoc = Console.ReadLine();
double formatTienGoc = Convert.ToDouble(tienGoc);
Console.WriteLine("Nhập tỷ lệ thuế VAT:");
string thueVAT = Console.ReadLine();
double formatVAT = Convert.ToDouble(thueVAT);

//output: số tiền phải trả cả thuế
double tien = 0;

//process
tien = formatTienGoc + (formatTienGoc / 100) * formatVAT;

Console.WriteLine("Khách hàng phải thanh toán: " + tien);
#endregion

#region bài 5
//chuyển đổi đơn vị tiền tệ
//input: số tiền chuyển đổi và tỷ giá chuyển đổi
Console.WriteLine("Số tiền chuyển đổi (USD): ");
string tienUSD = Console.ReadLine();
double USD = Convert.ToDouble(tienUSD);
Console.WriteLine("Tỷ giá chuyển đổi tiền tệ hôm nay: ");
string tyGia = Console.ReadLine();
double formatTyGia = Convert.ToDouble(tyGia);

//output
double VND = 0;

//process
VND = USD * formatTyGia;

Console.WriteLine(USD + "USD = " + VND + "VND");
#endregion
