namespace Task_10;

public static class ProductsCatalog
{
    private static Dictionary<ProductTypes, double> _productsPrice = new()
    {
        [ProductTypes.Banana] = 5.60,
        [ProductTypes.Milk] = 1.98,
        [ProductTypes.Chocolate] = 13.9,
        [ProductTypes.Oil] = 30.1,
        [ProductTypes.Pineapple] = 6,
        [ProductTypes.Meat] = 11.9,
        [ProductTypes.Eggs] = 3.99,
        [ProductTypes.Cheese] = 19.20
    };

    public static double GetProductPrice(ProductTypes productType)
    {
        return _productsPrice[productType];
    }
}