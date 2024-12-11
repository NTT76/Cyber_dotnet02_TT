﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region Bài 1: Quản lý thư viện
        // 1. Tạo classlass Book để quản lý sách (class cha)
        // - bookId: mã sách
        // - bookName: tên sách
        // - author: tác giả
        // - price: giá sách
        // 1.1 Tạo class TextBook kế thừa từ Book
        // - subject: môn học
        // - grade: lớp
        // 1.2 Tạo class ReferenceBook kế thừa từ Book
        // - topic: chủ đề
        // - publisher: nhà xuất bản
        // 1.3 Tạo class FictionBook kế thừa từ Book
        // - genre: thể loại
        // - year: năm xuất bản
        // -------------------
        // 2. Tạo classlass Library để quản lý thư viện
        // - libraryId: mã thư viện
        // - libraryName: tên thư viện
        // - danh sách sách trong thư viện
        // - file json lưu thông tin sách (nâng cao)
        // -------------------
        // 3. Yêu cầu chức năng
        // - Thêm sách vào thư viện 
        // * check xem mã sách đã tồn tại chưa. Nếu có rồi thì báo lỗi
        // lưu sách mới vào file json (sử dụng thư viện NewtonSoft.Json)
        // - Hiển thị danh sách sách trong thư viện (đọc file json)
        // - Tìm sách theo mã sách
        // - Thoát

        Console.WriteLine("Nhập mã thư viện: ");
        string libraryId = Console.ReadLine();
        Console.WriteLine("Nhập tên thư viện: ");
        string libraryName = Console.ReadLine();

        LibraryManager libraryManager = new LibraryManager(libraryId, libraryName);

        //tạo menu
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\n=== Library Management Menu ===");
            Console.WriteLine("1. Thêm sách giáo khoa vào thư viện");
            Console.WriteLine("2. Thêm sách tham khảo vào thư viện");
            Console.WriteLine("3. Thêm sách tiểu thuyết vào thư viện");
            Console.WriteLine("4. Hiển thị danh sách trong thư viện");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Vui lòng chọn chức năng (1-5): ");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    libraryManager.addTextBook();
                    break;
                case 2:
                    libraryManager.addReferenceBook();
                    break;
                case 3:
                    libraryManager.addFictionBook();
                    break;
                case 4:
                    libraryManager.displayAllBook();
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Vui lòng chọn chức năng (1-5): ");
                    break;
            }
        }
        #endregion
    }
}