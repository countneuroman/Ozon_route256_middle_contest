namespace Summator;

class Program
{
    public static void Main(string[] args)
    {
        var caseCount = int.Parse(Console.ReadLine());
        
        for (var i = 0; i < caseCount; i++)
        {
            int[] data = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
            Console.WriteLine(data.Sum());
        }
    }
}