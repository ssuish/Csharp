/*
Given an integer array nums, return true if any value appears at 
least twice in the array, and return false if every element is distinct.

Example 1:
Input: nums = [1,2,3,1]
Output: true

Example 2:
Input: nums = [1,2,3,4]
Output: false

Example 3:
Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true

*/

public class ContainsDuplicate {
    public bool IsContainsDuplicate(int[] nums) {
        int[] sorted_arr = nums;
        Array.Sort(sorted_arr);
        
        for (int i = 0; i < sorted_arr.Length - 1; i++) {
            if (sorted_arr[i] == sorted_arr[i + 1]) {
                return true;
            }
            else {
                continue;
            }
        }

        return false;
    }
}