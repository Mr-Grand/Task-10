namespace Task_10;

public static class Сashier
{
    public static double CalculatePrice(IReadOnlyList<ProductTypes> buyerBusket)
    {
        double summ = 0;
        foreach (var item in buyerBusket)
        {
            summ += ProductsCatalog.GetProductPrice(item);
        }
        return Math.Round(summ, 2);
    }
}