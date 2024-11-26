class TuDienAnhViet
{
    public static void process()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        //1. thêm từ
        //2. tra từ
        //3. xóa từ
        //4. thoát
        while (true)
        {
            Console.WriteLine("1. Thêm từ");
            Console.WriteLine("2. Tra từ");
            Console.WriteLine("3. Xóa từ");
            Console.WriteLine("4. Tìm từ tiếng anh bằng Tiếng Việt");
            Console.WriteLine("5. Thoát");
            Console.WriteLine("Mời bạn chọn 1 chức năng: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            // int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Mời nhập từ tiếng Anh: ");
                string englishText = Console.ReadLine();
                Console.WriteLine("Mời bạn nhập Tiếng Việt tương ứng: ");
                string vietnameseText = Console.ReadLine();

                //C1:
                dictionary[englishText] = vietnameseText;

                //C2:
                //dictionary.Add(englishText, vietnameseText);
                Console.WriteLine("Đã thêm thành công");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Mời nhập từ cần tra: ");
                string englishText = Console.ReadLine();
                //ContainsKey để tìm cặp key-value
                if (dictionary.ContainsKey(englishText))
                {
                    Console.WriteLine($"Nghĩa của từ {englishText} là {dictionary[englishText]}");
                }
                else
                {
                    Console.WriteLine($"Từ này chưa có trong từ điển");
                }
                Console.WriteLine("----------------------------------------------------------------");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Mời nhập từ cần xóa: ");
                string english = Console.ReadLine();
                if (dictionary.ContainsKey(english) == true)
                {
                    Console.WriteLine("Xóa từ thành công");
                }
                else
                {
                    Console.WriteLine("Từ này không có trong từ điển");
                }
                Console.WriteLine("----------------------------------------------------------------");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Mời nhập từ Tiếng Việt: ");
                string vietnameseText = Console.ReadLine();
                string englishOutput = null;
                foreach (KeyValuePair<string, string> kvp in dictionary)
                {
                    //C1: 
                    if (kvp.Value == vietnameseText)
                    {
                        englishOutput = kvp.Key;
                        break;
                    }

                    //C2:
                    // if (kvp.Value.Equals(vietnameseText))
                    // {

                    // }
                }
                if (englishOutput != null)
                {
                    Console.WriteLine($"Từ tiếng anh tương ứng là: {englishOutput}");
                }
                else
                {
                    Console.WriteLine($"Không tìm thấy từ tiếng anh tương ứng");
                }
                Console.WriteLine("----------------------------------------------------------------");
            }
            else
            {
                break;
            }
        }
    }
}