/*

Given two strings s and t, return true if t is an anagram of s, and false otherwise.
An Anagram is a word or phrase formed by rearranging the letters of a different word 
or phrase, typically using all the original letters exactly once.

Example 1:
Input: s = "anagram", t = "nagaram"
Output: true

Example 2:
Input: s = "rat", t = "car"
Output: false

*/

public class Anagram {
    public bool IsAnagram(string s, string t) {
        IDictionary<char, int> set = new Dictionary<char, int>();

        if (s.Length != t.Length) {
            return false;
        }

        foreach (char c in s) {
            if (set.ContainsKey(c)) {
                set[c] += 1;
            } else {
                set.Add(c, 1);
            }
        }

        foreach (char c in t) {
            if (set.ContainsKey(c)) {
                set[c] -= 1;
            } else {
                return false;
            }
        }

        return set.Values.All(x => x == 0);
    }
}