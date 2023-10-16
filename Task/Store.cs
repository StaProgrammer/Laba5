public class Store : ISearchable
{
    public List<Product> Products { get; set; }
    public List<User> Users { get; set; }
    public List<Order> Orders { get; set; }

    public Store()
    {
        Products = new List<Product>();
        Users = new List<User>();
        Orders = new List<Order>();
    }

    public List<Product> SearchByPrice(double minPrice, double maxPrice)
    {
        return Products.Where(item => item.Price >= minPrice && item.Price <= maxPrice).ToList();
    }

    public List<Product> SearchByCategory(string category)
    {
        return Products.Where(item => item.Category == category).ToList();
    }

    public void AddUser(User user)
    {
        Users.Add(user);
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void PlaceOrder(User user, List<Product> products, int quantity)
    {
        if (Users.Contains(user) && products.All(Products.Contains))
        {
            Order order = new Order(products, quantity);
            Orders.Add(order);
            user.PurchaseHistory.Add(order);
        }
        else
        {
            Console.WriteLine("Error: User or product not found.");
        }
    }
}