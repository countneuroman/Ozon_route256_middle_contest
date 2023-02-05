namespace PairProgramming;

class Program
{
    public static void Main(string[] args)
    {
        var caseCount = int.Parse(Console.ReadLine());
        
        for (var i = 0; i < caseCount; i++)
        {
            var dataCount = int.Parse(Console.ReadLine());
            var data = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToList();

            CheckPair(data);
        }
    }

    private static void CheckPair(List<int> data)
    {
        var partnerProgrammerIndex = 0;
        var partnerProgrammerMinRaznost = int.MaxValue;
        for (var i = 0; i < data.Count; i++)
        {
            var currentProgrammer = data[i];
            data.RemoveAt(i);
            var datas = new List<int>(data);
            for (var j = 0; j < datas.Count; j++)
            {
                if (partnerProgrammerMinRaznost > datas[j] / currentProgrammer)
                {
                    
                }
                
            }
        }
        
    }
}