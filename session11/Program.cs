using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region Quản lý lớp học

        //B1: Quản lý lớp học
        //1. Lớp học
        // tạo lớp classroom để quản lý lớp học
        // classId: mã lớp học
        // className: tên lớp học
        // danh sách sinh viên trong lớp
        //2. Sinh viên
        // studentId: mã sinh viên
        // studentName:tên sinh viên
        // age: tuổi
        //3. Yêu cầu chức năng
        // - Thêm sinh viên vào lớp
        // - Hiển thị danh sách sinh viên trong lớp
        // - Tìm sinh viên theo mã sinh viên

        //tạo lớp học
        ClassRoom classroom = new ClassRoom("C02", "Dotnet02");
        //tạo menu quản lý
        //1. thêm sv
        //2. hiển thị sv
        //3. tìm kiếm theo id
        //4. thoát
        while (true)
        {
            Console.WriteLine("\n-----Classroom Management-----");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. show students");
            Console.WriteLine("3. find students");
            Console.WriteLine("4. exit");
            Console.WriteLine("Please enter your choice (1-4)");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    // thêm sv
                    Console.WriteLine("Enter student ID: ");
                    string studentId = Console.ReadLine();
                    Console.WriteLine("Enter student Name: ");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("Enter student Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Student student = new Student(studentId, studentName, age);
                    //thêm sv vào lớp
                    classroom.addStudent(student);

                    //lưu danh sách sinh viên vào json
                    //chuyển danh sách sv thành json
                    var json = JsonConvert.SerializeObject(classroom.students, Formatting.Indented);
                    // lưu json vào file
                    File.WriteAllText("students.json", json);

                    Console.WriteLine("Add students successfully");
                    break;
                case 2:
                    //hiển thị danh sách sv
                    // đọc danh sách sv từ file json
                    var studentsJson = File.ReadAllText("students.json");

                    //chuyển json thành danh sách sv
                    classroom.students = JsonConvert.DeserializeObject<List<Student>>(studentsJson);
                    classroom.showStudent();
                    break;
                case 3:
                    //tìm kiếm sv theo id
                    Console.WriteLine("Enter student ID to find: ");
                    string? Id = Console.ReadLine();
                    if (Id == null)
                    {
                        Console.WriteLine("Student ID is required");
                    }
                    classroom.findStudentByStudentId(Id);
                    break;
                case 4:
                    //thoát
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter (1-4)");
                    break;
            }
        }
        #endregion

        #region Quản lý thư viện

        //1. tạo class Book để quản lý sách
        // - bookId: mã sách
        //- bookName: tên sách
        //- author: tác giả
        //- price: giá sách
        //2. Tạo class Library để quản lý thư viện
        //- libraryId: mã thư viện
        //- libraryName: tên thư viện
        // - danh sách sách trong thư viện
        // -------------------
        // 3. Yêu cầu chức năng
        // - Thêm sách vào thư viện
        // - Hiển thị danh sách sách trong thư viện
        // - Tìm sách theo mã sách
        // - Thoát

        // Library library = new Library("A01", "Tiến Thọ");
        // while (true)
        // {
        //     Console.WriteLine("\n-----Classroom Management-----");
        //     Console.WriteLine("1. Add Book");
        //     Console.WriteLine("2. show books");
        //     Console.WriteLine("3. find books");
        //     Console.WriteLine("4. exit");
        //     Console.WriteLine("Please enter your choice (1-4)");
        //     int choice = Convert.ToInt32(Console.ReadLine());
        //     switch (choice)
        //     {
        //         case 1:
        //             // thêm book
        //             Console.WriteLine("Enter book ID: ");
        //             string bookId = Console.ReadLine();
        //             Console.WriteLine("Enter book Name: ");
        //             string bookName = Console.ReadLine();
        //             Console.WriteLine("Enter book author: ");
        //             string author = Console.ReadLine();
        //             Console.WriteLine("Enter book price: ");
        //             double price = Convert.ToDouble(Console.ReadLine());

        //             Book book = new Book(bookId, bookName, author, price);
        //             library.addBook(book);
        //             break;
        //         case 2:
        //             //hiển thị danh sách book
        //             library.showBook();
        //             break;
        //         case 3:
        //             //tìm kiếm sách
        //             Console.WriteLine("Enter books ID to find: ");
        //             string? Id = Console.ReadLine();
        //             if (Id == null)
        //             {
        //                 Console.WriteLine("Book ID is required");
        //             }
        //             library.findBook(Id);
        //             break;
        //         case 4:
        //             //thoát
        //             return;
        //         default:
        //             Console.WriteLine("Invalid choice. Please enter (1-4)");
        //             break;
        //     }
        // }
        #endregion
    }
}