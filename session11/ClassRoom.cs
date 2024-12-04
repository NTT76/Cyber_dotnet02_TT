class ClassRoom
{
    public string classId;
    public string className;
    public List<Student> students;

    //Constructor
    public ClassRoom(string classId, string className)
    {
        this.classId = classId;
        this.className = className;
        this.students = new List<Student>();
    }

    // phương thức thêm sinh viên vào lớp
    public void addStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine($"Student {student.studentName} added to class {className}");
    }

    // phương thức hiển thị sinh viên trong lớp
    public void showStudent()
    {
        Console.WriteLine($"\n ----Students in class {className}----");
        foreach (Student student in students)
        {
            student.displayInfo();
        }
    }

    // phương thức tìm kiếm sv theo ID
    public void findStudentByStudentId(string studentId)
    {
        foreach (Student student in students)
        {
            if (student.studentId == studentId)
            {
                student.displayInfo();
                return;
            }
        }
        //Trong trường hợp duyệt hết danh sách mà không có sinh viên nào.
        Console.WriteLine($"Student with id {studentId} is not found in class {className}.");
    }
}
