using TWR;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<double> dailyReturns;
            try
            {
                dailyReturns = args.Select(arg => double.Parse(arg));
            }
            catch (Exception e)
            {
                Console.WriteLine($"One of the arguments doesn't represent a valid daily input. Daily inputs should be presented as numbers with floating point. {e.Message}");
                return;
            }

            var twr = TwrCalculator.CalculateTwr(dailyReturns);

            Console.WriteLine($"TWR equals {twr}");
        }        
    }  
}