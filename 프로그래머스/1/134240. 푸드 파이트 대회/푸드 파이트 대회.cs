using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution {
    public string solution(int[] food) {
            string answer = "";
            string st = "";
            for(int i = 1; i < food.Length; i++)
            {
                int cnt = food[i]/2;
                for(int j = 0;j<cnt;j++) st+=i.ToString();
            }

            answer = st + "0" + string.Concat(st.Reverse());
            return answer;
    }
}