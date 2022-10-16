using Products;

Console.WriteLine("Welcome Here...\n1.Add Product\n2.Display Product Detail\n3.Edit Product\n4.List all Products");
Console.Write("Enter your choice.. = ");
int choice=Convert.ToInt32(Console.ReadLine());
if (choice<1 ||choice>4)
{
    Console.WriteLine("Invalid choice \n you must enter your choice from 1 to 4");
} 
if (choice == 1)
{
    AddProduct();
}
if (choice == 2)
{
    DisplayProductDetail();
}
if (choice == 3)
{
    EditProduct();
}
if (choice == 4)
{
    ListAllProducts();
}



Console.WriteLine("Press Any Key To Continue...");
Console.ReadKey();


void AddProduct()
{
    Product[] p = new Product[10];
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Add product {i + 1}");
        p[i] = new Product();
        Console.Write("Product Code = ");
        p[i].Code =Convert.ToInt32( Console.ReadLine());
        //Console.Write("Product Name = ");
        //p[i].Name= Console.ReadLine();
        Console.Write("Product Cost Price = ");
        p[i].CostPrice = Convert.ToSingle(Console.ReadLine());
    }
    Console.Clear();
    Console.WriteLine("1.Add Product\n" +
        "2.Display Product Detail" +
        "\n3.Edit Product\n" +
        "4.List all Products");
    Console.Write("Enter your choice.. = ");
    int choice = Convert.ToInt32(Console.ReadLine());
    if (choice < 1 || choice > 4)
    {
        Console.WriteLine("Invalid choice \n you must enter your choice from 1 to 4");
    }
    if (choice == 1)
    {
        AddProduct();
    }
    if (choice == 2)
    {
        DisplayProductDetail();
    }
    if (choice == 3)
    {
        EditProduct();
    }
    if (choice == 4)
    {
        ListAllProducts();
    }
}


void DisplayProductDetail()
{
    Product[] p = new Product[10];
    Console.WriteLine("Enter Product Code = ");
    int detail = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < detail; i++)
    {
        if (detail == p[i].Code)
        {
            Console.WriteLine($"Product details of name\n Code =  {p[i].Code}" +
                $"\n Cost Price = {p[i].CostPrice}\n" +
                $"GST Rate = {p[i].GstRate}\n\"" +
                $"Sale Price = {p[i].SalePrice}");
        }
    }
   
}


void EditProduct()
{
    Product[] p = new Product[10];
    Console.WriteLine("If you want to edit product, Enter product id =");
    int edit = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < 10; i++)
    {
        if (edit == p[i].Code)
        {
            Console.WriteLine($"Add product {i + 1}");
            p[i] = new Product();
            Console.Write("Product Code = ");
            p[i].Code = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Product Name = ");
            //p[i].Name= Console.ReadLine();
            Console.Write("Product Cost Price = ");
            p[i].CostPrice = Convert.ToSingle(Console.ReadLine());
        }
    }


}


void ListAllProducts()
{
    Product[] p = new Product[10];
    
    for (int i = 0; i < 10; i++)
    {
        
            Console.WriteLine($"Product details of name\n Code =  {p[i].Code}" +
                $"\n Cost Price = {p[i].CostPrice}\n" +
                $"GST Rate = {p[i].GstRate}\n\"" +
                $"Sale Price = {p[i].SalePrice}\n\n\n");
        
    }
}