using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] ingredient) {
int answer = 0;
            Stack<int> st = new Stack<int>();

            foreach(int num in ingredient)
            {
                st.Push(num);
                if (st.Count >= 4)
                {
                    int[] check = st.Take(4).Reverse().ToArray();
                    if (check[0] == 1 && check[1] == 2 && check[2] == 3 && check[3] == 1)
                    {
                        for (int i = 0; i < 4; i++) st.Pop();
                        answer++;
                    }
                }
            }

            return answer;
    }
}