// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region học phép toán cơ bản
// học +, -, *, /(chia lấy phần nguyên), %(chia lấy phần dư)
//khai báo biến
int add = 5 + 10;
// Console.WriteLine($"5+10 = : {add}");

// int minus = 100 - 25;
// Console.WriteLine($"100-2 = {minus}");

// double divide = 7 / 2;
// Console.WriteLine($"7 chia 2 = {divide}");

// double divide2 = 7 % 2;
// Console.WriteLine($"7 chia 2 = {divide2}");
#endregion

#region toán tử gán
int a = 1;
// a += 2;
// Console.WriteLine($"numberic cộng bằng = {a}");
// a -= 2;
// Console.WriteLine($"numberic trừ bằng = {a}");
// a *= 2;
// Console.WriteLine($"numberic nhân bằng = {a}");
// a /= 2;
// Console.WriteLine($"numberic chia bằng = {a}");
#endregion

#region ép kiểu dữ liệu
//ép kiểu convert
// Console.WriteLine("nhập giá trị");
// string number = Console.ReadLine();
// int convertNumber = Convert.ToInt32(number);
// Console.WriteLine($"value number: {convertNumber}");
#endregion

#region tính chỉ số BMI
//Input: chiều cao cân nặng nhập từ bàn phím
// Console.WriteLine("nhập chiều cao:");
// string chieuCao = Console.ReadLine();
// double formatChieuCao = Convert.ToDouble(chieuCao);

// Console.WriteLine("nhập cân nặng:");
// string canNang = Console.ReadLine();
// double formatCanNang = Convert.ToDouble(canNang);

// //output: chỉ số BMI
// double bmi = 0.0;

// //process: BMI = cân nặng / (chiều cao * chiều cao)
// bmi = formatCanNang / Math.Pow(formatChieuCao, 2);
// Console.WriteLine("chỉ số bmi của bạn là: " + bmi);
#endregion

#region tính chu vi và diện tích hình tròn
//input: bán kính hình tròn
// Console.WriteLine("nhập bán kính hình tròn: ");
// string banKinh = Console.ReadLine();
// double formatBanKinh = Convert.ToDouble(banKinh);

// //output: chi vi và diện tích
// double chuVi = 0.0;
// double dienTich = 0.0;
// double pi = Math.PI;
// //process
// chuVi = 2 * pi * formatBanKinh;
// dienTich = pi * Math.Pow(formatBanKinh, 2);
// Console.WriteLine("Chu vi hình tròn là: " + chuVi);
// Console.WriteLine("Diện tích hình tròn là: " + dienTich);
#endregion
