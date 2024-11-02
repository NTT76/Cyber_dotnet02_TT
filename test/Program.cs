// See https://aka.ms/new-console-template for more information


//bài1
Console.WriteLine("nhập số n: ");
string? n = Console.ReadLine();
int formatN = Convert.ToInt32(n);
for (int i = 2; i <= formatN; i++)
{
    bool check = true;
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            check = false;
            break;
        }
    }
    if (check == true)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();

//in tam giác cân rỗng
// Console.WriteLine("nhập canh tam giac: ");
// int canh = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < canh; i++)
// {
//     for (int j = 0; j < canh - i - 1; j++)
//     {
//         Console.Write(" ");
//     }
//     for (int k = 0; k < 2 * i + 1; j++)
//     {
//         if (k = 0 || k == 2 * 1 || i == number - 1)
//         {
//             Console.Write("*");
//         }else
//         {
//             Console.Write(" ");
//         }
//     }
//     Console.WriteLine();
// }

//kiểm tra số đối xứng
// Console.WriteLine("nhập số: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int originalNumber = number;
// int reverseNumber = 0;
// while (number > 0)
// {
//     int lastDigit = number % 10;
//     reverseNumber = reverseNumber * 10 + lastDigit;
//     number = number / 10;
// }
// if (reverseNumber == originalNumber)
// {
//     Console.WriteLine($"{originalNumber} là số đối xứng");
// }
// else
// {
//     Console.WriteLine($"{originalNumber} không là số đối xứng");
// }
