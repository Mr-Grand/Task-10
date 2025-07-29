namespace Task_10;

public class Buyer
{
    public double OwnedMoney { get; }
    private List<ProductTypes> _busket = new();
    private List<ProductTypes> _bag = new();
    
    public Buyer()
    {
        OwnedMoney = RandomClass.Random.Next(1,51) + RandomClass.Random.NextDouble()*100;
        
        string[] temporaryArray = Enum.GetNames(typeof(ProductTypes));
        int productCount = temporaryArray.Length;
        int randomNumber = RandomClass.Random.Next(1,productCount);
        
        for (int i = 0; i < randomNumber; i++)
        {
            int enumNumber = RandomClass.Random.Next(0, productCount);
            ProductTypes productAtEnumNumber = (ProductTypes)enumNumber;
            _busket.Add(productAtEnumNumber);
            i++;
        }
        
        
    }
}