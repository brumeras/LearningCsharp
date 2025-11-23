namespace PreparationPrograms.Dictionary;

public class MaxPrice
{
    public double GetMaxPrice(Dictionary<string, double> productPrices)
    {
        return productPrices.Values.Max();
    }
}