namespace PreparationPrograms.Dictionary;

public class Price
{
    public double GetProductPrice(Dictionary<string, double> products, string product)
    {
            if (products.ContainsKey(product))
            {
                return products[product];
            }
            else
            {
                return 0;
            }
    }
}