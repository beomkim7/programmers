
using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string[] seoul) {
            int check = seoul.Select((name, index) => new { name, index })
                            .Where(x => x.name.Contains("Kim"))
                            .Select(x => x.index).FirstOrDefault();
                                

            string answer = $"김서방은 {check}에 있다";


            return answer;
    }
}