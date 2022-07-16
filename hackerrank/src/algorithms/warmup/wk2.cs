// Week 2 of Warm Up Algorithms

// Birthday Cake Candles
/*
    Input: array of candle heights.
    Expected Output: number of tallest candles.
*/
class BirthdayCandles
{
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

// Time Conversion
/*
    Given a time in -hour AM/PM format, convert it to military (24-hour) time.

    Note: 
    - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
    - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
*/
class TimeConverter
{
    

    public static string timeConversion(string s)
    {
        return string.Empty;
    }
}