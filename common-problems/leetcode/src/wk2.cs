// Leetcode Challenges for New Users
using System.Collections.Generic;

/*
    Roman to Integer
    Given a roman numeral, convert it to an integer.
 
    Constraints: 
    ~ s is input.
    ~ 1 <= s.length <= 15.
    ~ s contains only the char (I,V,X,L,C,D,M).
    ~ s is a valid numberal range in the [1 - 3999].
*/
public class RomanToInteger
{
    private static readonly IDictionary<char, int> RomanConst = new Dictionary<char, int>(){
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int RomanToInt(string s)
    {
        if (!String.IsNullOrWhiteSpace(s))
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (RomanConst.ContainsKey(ch))
                {
                    if (i > 0 && RomanConst[ch] > RomanConst[s[i - 1]])
                    {
                        result += RomanConst[ch] - 2 * RomanConst[s[i - 1]];
                    }
                    else
                    {
                        result += RomanConst[ch];
                    }

                    /*
                    if (i != n - 1 && roman[s[i]] < roman[s[i + 1]]) {
                        sum += roman[s[i + 1]] - roman[s[i]];
                        i++;
                    } else {
                        sum += roman[s[i]];
                    }
                    */
                }
                else
                {
                    return 0;
                }
            }
            return result;
        }
        return 0;
    }
}