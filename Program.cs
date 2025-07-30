namespace Task_10;

class Program
{
    static void Main(string[] args)
    {
        Market market = new(10);
        
        while (market.GetQueueCount() > 0)
        {
            Console.WriteLine($"Очередь состоит из {market.GetQueueCount()} людей");

            Buyer currentBuyer = market.GetFirstPersonInQueue();

            Console.WriteLine("Пришел покупатель. Вот его корзина:");
            currentBuyer.ShowBusket();
            double priceForBusker = Cashier.CalculatePrice(currentBuyer.GetBuyerBusket());
            Console.WriteLine($"Цена за товары - {priceForBusker}" +
                              $"\nИмеющиеся деньги - {currentBuyer.OwnedMoney}");
            Cashier.ComparePriceAndMoney(currentBuyer);
            
            market.SellItems(currentBuyer);
            currentBuyer.TransferItemsToBag();
            market.DoneWithBuyer();
            
            Console.WriteLine("Корзина покупателя:");
            currentBuyer.ShowBusket();
            Console.WriteLine("Сумка покупателя:");
            currentBuyer.ShowBag();
            Console.WriteLine($"Суммарная выручка: {market.EarnedMoney}");
            
            
            Console.ReadKey();
            Console.Clear();
        }
    }
}