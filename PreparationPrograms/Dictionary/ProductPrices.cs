namespace PreparationPrograms.Dictionary;

public class ProductPrices
{
    public Dictionary<string, double> ManagePrices()
    {
        Dictionary<string, double> productPrices = new Dictionary<string, double>();

        productPrices.Add("Apple", 1.00);
        productPrices.Add("Orange", 2.00);
        productPrices.Add("Pear", 3.00);
        productPrices.Add("Banana", 2.5);
        
        return productPrices; 
    }
}