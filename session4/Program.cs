// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//ưhile
//for
//do ..while

//b3: thay đổi điều kiện lặp
// Console.WriteLine("Mời bạn nhập số: ");
// string? number = Console.ReadLine();
// int formatNumber = Convert.ToInt32(number);
// int count = 1;
// while(count <= formatNumber) {
//     Console.WriteLine(count);
//     count++; //count = count +1;
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

//kiểm tra số n có phải là số nguyên tố không
// int number = Convert.ToInt32(Console.WriteLine());
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

#region 
//in bảng cửu chương
int number = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count <= 10; count++)
{
    Console.WriteLine($"{count} x {number} = {count * number}");
}

//kiểm tra số nguyên tố 
#endregion