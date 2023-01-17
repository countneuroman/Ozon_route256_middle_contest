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
        }
    }
}