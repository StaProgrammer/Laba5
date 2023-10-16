public class Order
{
    public List<Product> Products { get; set; }
    public int Quantity { get; set; }
    public double TotalPrice { get; set; }
    public string Status { get; set; }

    public Order(List<Product> products, int quantity)
    {
        Products = products;
        Quantity = quantity;
        TotalPrice = products.Sum(item => item.Price) * quantity;
        Status = "Processing";
    }
}