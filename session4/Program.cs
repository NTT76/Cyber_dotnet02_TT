// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//while
//for
//do .. while
// quan trọng nhất là xác định điều kiên dừng

#region while statements
//in ra các số từ 1 đến n với n là số nhập từ bàn phím
//B1: khởi tạo giá trị lặp
//B2: xác định điều kiện lặp
//B3: thay đổi điều kiện lặp
// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// int count = 1;
// while (count <= formatNumber)
// {
//     Console.WriteLine(count);
//     count++;
// }


//nhập số n từ bàn phím in ra tổng từ 1 đến n
// S = 1 + 2 + 3 + ... + n;
// Console.WriteLine("Mời bạn nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int sum = 0;
// while (count <= number)
// {
//     sum += count; //sum = sum + count
//     count++;
// }
// Console.WriteLine("Tổng các số từ 1 đến n là: " + sum);


//Tính giai thừa một số n
// Console.WriteLine("Mời bạn nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int factorial = 1;
// while (count <= number)
// {
//     factorial *= count;
//     count++;
// }
// Console.WriteLine("giai thừa của n là: " + factorial);


//in bảng cửu chương
// Console.WriteLine("mời nhập số: ");
// int count2 = 1;
// while (count2 <= 10)
// {
//     Console.WriteLine($"{count2} x {number} = {count2 * number}");
//     count2++;
// }


//kiểm tra số n có phải là số nguyên tố không
// Console.WriteLine("nhập số n: ");
// string? number2 = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number2);
// int count = 2;
// while (count < number)
// {
//     if (number % count == 0)
//     {
//         Console.WriteLine($"số {number}không phải số nguyên tố");
//         break;
//     }
//     count++;
// }
// if (count == number - 1)
// {
//     Console.WriteLine($"Số {number} là số nguyên tố");
// }
#endregion

#region for statements
//in bảng cửu chương
// Console.WriteLine("mời nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for (int count = 1; count <= 10; count++)
// {
//     Console.WriteLine($"{count} x {number} = {count * number}");
// }


//kiểm tra số n có phải là số nguyên tố không
// Console.WriteLine("nhập số n: ");
// string? number2 = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number2);
// int count2;
// for (count2 = 2; count2 < formatNumber; count2++)
// {
//     if (formatNumber % count2 == 0)
//     {
//         Console.WriteLine($"số {number2} không phải số nguyên tố");
//         break;
//     }
// }
// if (count2 == formatNumber)
// {
//     Console.WriteLine($"số {number2} là số nguyên tố");
// }


//for lồng nhau
//vẽ chữ nhật sao
// Console.WriteLine("nhập số hàng: ");
// int hang = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("nhập số cot: ");
// int cot = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < hang; i++)
// {
//     for (int j = 0; j < cot; j++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }

//vẽ tam giác cân sao cạnh n
Console.WriteLine("nhập n: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    //in khoảng trắng (space) trước dấu *
    for (int j = 0; j < n - i - 1; j++)
    {
        Console.Write(" ");
    }
    //in dấu *
    for (int k = 0; k < (2 * i + 1); k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Bài tập: vẽ hình chữ nhật rỗng
#endregion

