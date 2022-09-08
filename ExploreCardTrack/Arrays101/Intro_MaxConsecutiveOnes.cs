/*
    Given a binary array nums, return the maximum number of consecutive 1's in the array.
*/

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) { // Can probably be done cleaner
        int maxCons = 0;
        int tempCons = 0;
        for (int i = 0; i < nums.Length; i++) {
            
            if(nums[i] == 1) {
                tempCons++;
                if (tempCons > maxCons) { maxCons = tempCons; }
            } else if(nums[i] == 0) {
                tempCons = 0;
            }
        }
        
        return maxCons;
    }
}