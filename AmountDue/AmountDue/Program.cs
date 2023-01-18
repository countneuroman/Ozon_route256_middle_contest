namespace AmountDue;

class Program
{
    public static void Main(string[] args)
    {
        var dataCount = int.Parse(Console.ReadLine());
        for (var i = 0; i < dataCount; i++)
        {
            var setCount = int.Parse(Console.ReadLine());
            var allPricesInSet = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();

            Dictionary<int, int> prices = new Dictionary<int, int>();
            foreach (var price in allPricesInSet)
            {
                if (prices.ContainsKey(price))
                {
                    prices[price]++;
                    continue;
                }
                prices.Add(price, 1);
            }

            int result = 0;
            foreach (var price in prices)
            {
                int actionValue = price.Value / 3;

                result += (price.Value - actionValue) * price.Key;
            }
            
            Console.WriteLine(result);
        }
    }
}