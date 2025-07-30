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
            double priceForBusker = Cashier.CalculatePrice(currentBuyer.GetBuyerBasket());
            Console.WriteLine($"Цена за товары - {priceForBusker}" +
                              $"\nИмеющиеся деньги - {currentBuyer.OwnedMoney}");
            Cashier.ComparePriceAndMoney(currentBuyer);

            market.SellItems(currentBuyer);
            currentBuyer.TransferItemsToBag();
            market.DoneWithBuyer();

            /*Console.WriteLine("Корзина покупателя:");
            currentBuyer.ShowBusket();*/
            Console.WriteLine("Сумка покупателя:");
            currentBuyer.ShowBag();
            Console.WriteLine($"Суммарная выручка: {Math.Round(market.EarnedMoney, 2)}");


            Console.WriteLine("\nЧто делаем дальше?" +
                              "\n1) Подождать еще покупателей" +
                              "\n2) Обслужить следующего покупателя");
            ConsoleKey input = Console.ReadKey().Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    market.WaitUntilMoreBuyers();
                    break;
                case ConsoleKey.D2:
                    break;
            }
            
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("\x1b[3J"); 
        }
    }
}