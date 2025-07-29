namespace Task_10;

public class BuyersQueue
{
    private List<Buyer> _buyers = new();

    public int GetQueueCount()
    {
        return _buyers.Count;
    }

    public BuyersQueue(int buyersCount)
    {
        for (int i = 0; i < buyersCount; i++)
        {
            _buyers.Add(new Buyer());
        }
    }

    public Buyer GetFirstPersonInQueue()
    {
        return _buyers[0];
    }

    public void DoneWithBuyer()
    {
        _buyers.RemoveAt(0);
    }
}