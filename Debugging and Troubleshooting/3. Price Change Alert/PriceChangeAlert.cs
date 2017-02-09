using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double minDiffValue = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double currDiffValue = GetCurrFiffValue(lastPrice, currentPrice);
            bool diffValue = GetDiffValue(currDiffValue, minDiffValue);

            string message = Get(currentPrice, lastPrice, currDiffValue, diffValue);
            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }

    private static string Get(double currentPrice, double lastPrice, double currDiffValue, bool diffValue)
    {
        string result = "";
        if (currDiffValue == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!diffValue)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, currDiffValue * 100);
        }
        else if (diffValue && (currDiffValue > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, currDiffValue * 100);
        }
        else if (diffValue && (currDiffValue < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, currDiffValue * 100);
        }
        return result;
    }

    private static bool GetDiffValue(double minDiffValue, double isDiff)
    {
        if (Math.Abs(minDiffValue) >= isDiff)
        {
            return true;
        }
        return false;
    }


    private static double GetCurrFiffValue(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) / lastPrice;
        return result;
    }
}

