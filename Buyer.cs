namespace Task_10;

public class Buyer
{
    private List<ProductTypes> _basket = new();
    private List<ProductTypes> _bag = new();
    public double OwnedMoney { get; }

    public Buyer()
    {
        OwnedMoney = Math.Round(RandomClass.Random.Next(1, 71) + RandomClass.Random.NextDouble(), 2);

        string[] temporaryArray = Enum.GetNames(typeof(ProductTypes));
        int productCount = temporaryArray.Length;
        int randomNumber = RandomClass.Random.Next(1, productCount + 1); // +1 из-за особенности рандома

        for (int i = 0; i < randomNumber; i++)
        {
            int enumNumber = RandomClass.Random.Next(0, productCount);
            ProductTypes productAtEnumNumber = (ProductTypes)enumNumber;
            _basket.Add(productAtEnumNumber);
        }
    }

    public void ShowBusket()
    {
        if (_basket.Count == 0)
        {
            Console.WriteLine("Пусто");
        }
        else
        {
            foreach (var item in _basket)
            {
                Console.WriteLine($"- {item} ");
            }
        }
    }

    public void ShowBag()
    {
        if (_bag.Count == 0)
        {
            Console.WriteLine("Пусто");
        }
        else
        {
            foreach (var item in _bag)
            {
                Console.WriteLine($"- {item} ");
            }
        }
    }

    public IReadOnlyList<ProductTypes> GetBuyerBasket()
    {
        return _basket;
    }

    public void BalanceBusket()
    {
        if (_basket.Count == 0)
        {
            Console.WriteLine("У покупателя нет товаров в корзине");
        }
        else if (OwnedMoney < Cashier.CalculatePrice(GetBuyerBasket()))
        {
            int randomNumber = RandomClass.Random.Next(0, _basket.Count);
            Console.WriteLine($"Убран товар {_basket[randomNumber]}");
            _basket.RemoveAt(randomNumber);
            BalanceBusket();
        }
    }

    public void TransferItemsToBag()
    {
        _bag = _basket.ToList();
        _basket.Clear();
    }
}