/*  Given an integer num, return the number of steps to reduce it to zero.
    In one step, if the current number is even, you have to divide it by 2, 
    otherwise, you have to subtract 1 from it.
*/

public class Solution {
    public int NumberOfSteps(int num) {
        int steps = 0;
        while(num != 0) {
            if(num%2 == 0) {
                num = num/2;
            } else {
                num = num - 1;
            }
            
            steps++;
        }
        
        return steps;
    }
}

/*
Runtime: 30 ms, faster than 69.38% of C# online submissions for Number of Steps to Reduce a Number to Zero.
Memory Usage: 25.2 MB, less than 58.66% of C# online submissions for Number of Steps to Reduce a Number to Zero.
*/