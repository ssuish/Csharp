class BirthdayCandles
{
    // Birthday Cake Candles
    /*
        Input: array of candle heights.
        Expected Output: number of tallest candles.
    */
    public static int birthdayCakeCandles(List<int> candles)
    {
        int tallest = 0;
        int result = 0;

        for (int i = 0; i < candles.Count; i++)
        {
            if (tallest < candles[i])
                tallest = candles[i];
        }

        for (int j = 0; j < candles.Count; j++)
        {
            if (tallest == candles[j])
                result++;
        }

        return result;
    }
}