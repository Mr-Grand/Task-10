namespace Task_10;

public class Buyer
{
    public double OwnedMoney { get; }
    private List<ProductTypes> _busket = new();
    private List<ProductTypes> _bag = new();
    
    public Buyer()
    {
        OwnedMoney = Math.Round(RandomClass.Random.Next(1,71) + RandomClass.Random.NextDouble(), 2);
        
        string[] temporaryArray = Enum.GetNames(typeof(ProductTypes));
        int productCount = temporaryArray.Length;
        int randomNumber = RandomClass.Random.Next(1,productCount + 1); // +1 из-за особенности рандома
        
        for (int i = 0; i < randomNumber; i++)
        {
            int enumNumber = RandomClass.Random.Next(0, productCount);
            ProductTypes productAtEnumNumber = (ProductTypes)enumNumber;
            _busket.Add(productAtEnumNumber);
        }
    }

    public void ShowBusket()
    {
        foreach (var item in _busket)
        {
            Console.WriteLine($"- {item} ");
        }
    }

    public IReadOnlyList<ProductTypes> GetBuyerBusket()
    {
        return _busket;
    }
}