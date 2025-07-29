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

            Console.WriteLine("Пришел покупатель:");
            currentBuyer.ShowBusket();
            
            
            
            
            buyersQueue.DoneWithBuyer();
            Console.ReadKey();
            Console.Clear();
        }
    }
}