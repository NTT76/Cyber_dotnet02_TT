class Person
{
    private string name;
    private int age;
    // dùng property để truy cập từng thuộc tính

    public string Name
    {
        get { return name; }
        set
        {
            // gán các logic kiển tra giá trị trước khi gắn cho thuộc tính
            // check tên không được rỗng
            // hoặc check tên có đọ dài tối thiểu 2 ký tự
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
            {
                throw new ArgumentException("Tên không hợp lệ");
            }
            name = value;
        }
    }

    // tương tự với age
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 150)
            {
                throw new ArgumentException("Tuổi không hợp lệ");
            }
            age = value;
        }
    }
    public Person(string name, int age)
    {
        //gán giá trị cho thuộc thính trông setter
        Name = name;
        Age = age;
    }
    public Person() { }
}