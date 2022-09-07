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
            bool div3 = i % 3 == 0;
            bool div5 = i % 5 == 0;
            
            if(div3 && div5) {
                answer.Add("FizzBuzz");
            }
            
            else if(div3) {
                answer.Add("Fizz");
            }
            
            else if (div5) {
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
#1 try
Runtime: 283 ms, faster than 5.68% of C# online submissions for Fizz Buzz.
Memory Usage: 46.7 MB, less than 97.62% of C# online submissions for Fizz Buzz.

#2 try
Runtime: 268 ms, faster than 9.54% of C# online submissions for Fizz Buzz.
Memory Usage: 46.8 MB, less than 93.20% of C# online submissions for Fizz Buzz.
*/
