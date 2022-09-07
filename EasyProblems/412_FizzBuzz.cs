/*
Given an integer n, return a string array answer (1-indexed) where:

answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
answer[i] == "Fizz" if i is divisible by 3.
answer[i] == "Buzz" if i is divisible by 5.
answer[i] == i (as a string) if none of the above conditions are true.
*/

public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> answer = new List<String>();
        
        for(int i = 1; i <= n; i++) {
            
            if(i % 3 == 0 && i % 5 == 0) {
                answer.Add("FizzBuzz");
            }
            
            else if(i % 3 == 0) {
                answer.Add("Fizz");
            }
            
            else if (i % 5 == 0) {
                answer.Add("Buzz");
            }
            
            else {
                answer.Add(i.ToString());
            }
        }
        
        return answer;
    }
}

/*
Runtime: 283 ms, faster than 5.68% of C# online submissions for Fizz Buzz.
Memory Usage: 46.7 MB, less than 97.62% of C# online submissions for Fizz Buzz.
*/