/*
You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has
in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.

A customer's wealth is the amount of money they have in all their bank accounts. 
The richest customer is the customer that has the maximum wealth.
*/

public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = 0;
        for(int i = 0; i < accounts.Length; i++) { // Accounts
            int tempWealth = 0;
            for(int x = 0; x < accounts[i].Length; x++) { // Money in said account
                tempWealth += accounts[i][x];
            }
            if(tempWealth >= maxWealth) {
                maxWealth = tempWealth;
            }
        }
        return maxWealth;
    }
}

/*
Runtime: 161 ms, faster than 15.68% of C# online submissions for Richest Customer Wealth.
Memory Usage: 37.8 MB, less than 32.06% of C# online submissions for Richest Customer Wealth.
*/