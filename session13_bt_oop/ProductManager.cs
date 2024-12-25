using Newtonsoft.Json;
class ProductManager
{
    private List<Product> products;
    private string filePath;
    private void loadData()
    {
        if (!File.Exists(filePath))
        {
            products = new List<Product>();
        }
        else
        {
            string json = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }
    public ProductManager()
    {
        loadData();
    }
    private void saveData()
    {
        string json = JsonConvert.SerializeObject(products, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
    public void addProduct(Product product)
    {
        products.Add(product);
        saveData();
    }
    public void addElectronic()
    {
        Console.WriteLine("Enter product ID: ");
        int productId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter product name: ");
        string? productName = Console.ReadLine();
        Console.WriteLine("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter description: ");
        string? description = Console.ReadLine();
        Console.WriteLine("Enter warranty: ");
        int warranty = Convert.ToInt32(Console.ReadLine());
        Electronic electronic = new Electronic(productId, productName, price, description, warranty);
        addProduct(electronic);
    }
    public void displayAllProducts()
    {
        //sắp xếp giảm dần theo giá
        // (p1,p2) => p2.Price.CompareTo(p1.Price)
        // => lamda expression
        // synxtax: (input parameters) => expression
        //int sum = (num1,num2) => num1+num2;
        //sắp xếp giảm dần theo giá
        //p1 (10000),p2 (40000), p2.Price.CompareTo(p1.Price) => giảm dần
        //p1 (10000),p2 (40000), p1.Price.CompareTo(p2.Price) => tăng dần
        products.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
        foreach (Product product in products)
        {
            product.displayInfo();
            Console.WriteLine("==========================");
        }

        //C2: dùng OrderBy(tăng dần) hoặc OrderByDescending(giảm dần)
        // OrderBy thì không lam ảnh hưởng đến list ban đầu
        // List<Product> sortProduct = products.OrderByDescending(p => p.Price).ToList();
        // foreach (Product product1 in sortProduct)
        // {
        //     product1.displayInfo();
        //     Console.WriteLine("=====================");
        // }

        //Sắp xếp giảm dần theo giá tiền và tên sản phẩm
        // List<Product> sortProduct = products
        //                                 .OrderByDescending(p => p.Price)
        //                                 .ThenByDescending(p => p.ProductName)
        //                                 .ToList();
    }
    public void searchByName(string name)
    {
        //ToLower() => chuyển chuỗi về chữ thường
        //ToUpper() => chuyển chuỗi về chữ hoa
        Product product = products.Find(p => p.ProductName.ToLower().Contains(name));
        if (product == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            product.displayInfo();
        }
    }
}