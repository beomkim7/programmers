using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] ingredient) {
            int answer = 0;
            Stack<int> stack = new Stack<int>();

            foreach(int i in ingredient)
            {
                stack.Push(i);
                if(stack.Count >= 4)
                {
                    int[] check = stack.Take(4).Reverse().ToArray();
                    if(check[0]==1&& check[1] == 2 && check[2] ==3 && check[3] == 1)
                    {
                        for (int j = 0; j < 4; j++) stack.Pop();
                        answer++;
                    }
                }
            }

            return answer;
    }
}