public interface ISearchable
{
    List<Product> SearchByPrice(double minPrice, double maxPrice);
    List<Product> SearchByCategory(string category);
}