class Program
{
    static void Main(string[] args)
    {
        Store store = new Store();

        Product product1 = new Product("Gaming Monitor", 450, "High refresh rate monitor", "Electronics");
        Product product2 = new Product("Wireless Headphones", 120, "Noise-canceling headphones", "Electronics");
        store.AddProduct(product1);
        store.AddProduct(product2);

        User user = new User("User123", "Password456");
        store.AddUser(user);

        store.PlaceOrder(user, new List<Product> { product1 }, 2);
        store.PlaceOrder(user, new List<Product> { product2 }, 1);

        Console.WriteLine("Welcome to the console store application!");

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Search by price");
            Console.WriteLine("2. Search by category");
            Console.WriteLine("3. Exit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Minimum price: ");
                    double minPrice = double.Parse(Console.ReadLine());
                    Console.Write("Maximum price: ");
                    double maxPrice = double.Parse(Console.ReadLine());

                    var productsByPrice = store.SearchByPrice(minPrice, maxPrice);
                    Console.WriteLine("Search results by price:");
                    foreach (var product in productsByPrice)
                    {
                        Console.WriteLine($"{product.Name} - ${product.Price}");
                    }
                    break;

                case "2":
                    Console.Write("Category: ");
                    string category = Console.ReadLine();

                    var productsByCategory = store.SearchByCategory(category);
                    Console.WriteLine("Search results by category:");
                    foreach (var product in productsByCategory)
                    {
                        Console.WriteLine($"{product.Name} - {product.Category}");
                    }
                    break;

                case "3":
                    Console.WriteLine("Thank you for using our application. goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}