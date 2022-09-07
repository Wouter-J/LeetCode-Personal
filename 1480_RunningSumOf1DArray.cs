/*
Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
Return the running sum of nums.
*/

public class Solution {
    public int[] RunningSum(int[] nums) {
        
        int[] sumList = new int[nums.Length];
        sumList[0] = nums[0];
        for(int i = 1; i < nums.Length; i++) { // Skip first number since it's always the same
            sumList[i] = nums[i] + sumList[i -1];
        }
        
        return sumList;
    }
}

/*
Runtime: 217 ms, faster than 42.33% of C# online submissions for Running Sum of 1d Array.
Memory Usage: 41.8 MB, less than 42.64% of C# online submissions for Running Sum of 1d Array.
*/