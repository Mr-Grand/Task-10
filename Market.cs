namespace Task_10;

public class Market
{
    public List<ProductTypes> Products { get; private set; } = new()
    {
        ProductTypes.Banana,
        ProductTypes.Milk,
        ProductTypes.Chocolate,
        ProductTypes.Oil,
        ProductTypes.Pineapple,
        ProductTypes.Meat,
        ProductTypes.Eggs,
        ProductTypes.Cheese
    };
    public List<Buyer> BuyersQueue { get; private set; } = new();
    public double EarnedMoney { get; private set; }
    
    
}