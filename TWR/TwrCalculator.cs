namespace TWR
{
    public static class TwrCalculator
    {
        public static double CalculateTwr(IEnumerable<double> dailyReturns) =>
            dailyReturns.Any()
            ? dailyReturns.Aggregate(1.0, (twr, dailyReturn) => twr * (1 + dailyReturn)) - 1
            : 0;
    }
}
