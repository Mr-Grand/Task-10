namespace Task_10;

class Program
{
    static void Main(string[] args)
    {
        BuyersQueue buyersQueue = new(10);
        
        while (buyersQueue.GetQueueCount() > 0)
        {
            Console.WriteLine($"Очередь состоит из {buyersQueue.GetQueueCount()} людей");

            Buyer currentBuyer = buyersQueue.GetFirstPersonInQueue();

            Console.WriteLine("Пришел покупатель. Вот его корзина:");
            currentBuyer.ShowBusket();
            double priceForBusker = Cashier.CalculatePrice(currentBuyer.GetBuyerBusket());
            Console.WriteLine($"Цена за товары - {priceForBusker}" +
                              $"\nИмеющиеся деньги - {currentBuyer.OwnedMoney}");
            Cashier.ComparePriceAndMoney(currentBuyer);
            
            
            buyersQueue.DoneWithBuyer();
            Console.ReadKey();
            Console.Clear();
        }
    }
}