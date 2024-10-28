// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region if-else statements
// nhập số nguyên in ra số chẵn hay lẻ
//input
// Boolean  flag = true;
// while (flag){
//     Console.WriteLine("Mời bạn nhập số nguyên: ");
//     string? number = Console.ReadLine();
//     try{
//         int test = Convert.ToInt32(number);
//         flag = false;
//     } catch {
//         flag = true;
//     }
// }

// Console.WriteLine("Nhập số nguyên");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// if (formatNumber % 2 == 0)
// {
//     Console.WriteLine("là số chẵn");
// }
// else
// {
//     Console.WriteLine("là số lẻ");
// }

//output

//process

//truthy
int day = 5;
if (day != 0)
{
    // >, <, >=, <=, !=
    Console.WriteLine("Truthy");
}

//nhập điểm trung bình học sinh. Xuất ra học lực
// Console.WriteLine("Nhập điểm trung bình: ");
// string? diemTrungBinh = Console.ReadLine();
// Double formatDiem = Convert.ToDouble(diemTrungBinh);
// if (formatDiem >= 9)
// {
//     Console.WriteLine("xuất sắc");
// }
// else if (formatDiem >= 8 && formatDiem < 9)
// {
//     Console.WriteLine("giỏi");
// }
// else if (formatDiem >= 6.5 && formatDiem < 8)
// {
//     Console.WriteLine("khá");
// }
// else if (formatDiem >= 5 && formatDiem < 6.5)
// {
//     Console.WriteLine("trung bình");
// }
// else if (formatDiem >= 4 && formatDiem <= 5)
// {
//     Console.WriteLine("yếu");
// }
// else
// {
//     Console.WriteLine("quá kém");
// }

//nhập số có 3 chữ số tính tổng 3 số đó
// Console.WriteLine("Nhập số có 3 chữ số: ");
// string? number =Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// if(formatNumber>=100 && formatNumber<1000){
//     //789
//     int hundred = formatNumber/100; //7
//     int tens = (formatNumber%100)/10; //8
//     int units = formatNumber%10; //9

//     int sum = hundred+tens+units;
//     Console.WriteLine("Tổng 3 chữ số "+number+" là: ");
// }else{
//     Console.WriteLine("Không phải số có 3 chữ số");
// }

//Nhập ngày (dd/mm/yyyy). In ra thứ mấy trong tuần
//vd: 23/10/2024 => thứ 4
//lưu ý: không dùng thư viện


//switch ...case
//c1: dùng switch..case
//nhập số từ 1 đến 10. Đọc số
Console.WriteLine("nhập số 1 đến 5: ");
string? number = Console.ReadLine();
int formatNumber = Convert.ToInt32(number);
// switch (formatNumber)
// {
//     case 1:
//         Console.WriteLine("số 1");
//         break;
//     case 2:
//         Console.WriteLine("số 2");
//         break;
//     case 3:
//         Console.WriteLine("số 3");
//         break;
//     case 4:
//         Console.WriteLine("số 4");
//         break;
//     case 5:
//         Console.WriteLine("số 5");
//         break;
//     default:
//         Console.WriteLine("không trong khoảng 1 đến 5");
//         break;
// }

//c2: var..switch
Console.WriteLine("nhập số 1 đến 5: ");
string? number2 = Console.ReadLine();
int formatNumber2 = Convert.ToInt32(number2);
#endregion