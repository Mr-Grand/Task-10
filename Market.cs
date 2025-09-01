namespace Task_10;

public class Market
{
    private List<Buyer> _buyersQueue = new();
    private List<Buyer> _pastBuyers = new();
    public double EarnedMoney { get; private set; }

    public Market(int buyersCount)
    {
        for (int i = 0; i < buyersCount; i++)
        {
            _buyersQueue.Add(new Buyer());
        }
    }

    public int GetQueueCount()
    {
        return _buyersQueue.Count;
    }

    public Buyer GetFirstPersonInQueue()
    {
        return _buyersQueue[0];
    }

    public void DoneWithBuyer()
    {
        _pastBuyers.Add(_buyersQueue[0]);
        _buyersQueue.RemoveAt(0);
    }

    public void SellItems(Buyer buyer)
    {
        foreach (ProductTypes item in buyer.GetBuyerBasket())
        {
            EarnedMoney += ProductsCatalog.GetProductPrice(item);
        }
    }

    public void WaitUntilMoreBuyers()
    {
        int x = RandomClass.Random.Next(1, 4);
        for (int i = 0; i < x; i++)
        {
            _buyersQueue.Add(new Buyer());
        }
    }
}