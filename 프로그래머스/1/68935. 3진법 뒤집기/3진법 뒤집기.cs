using System;

public class Solution {
    public int solution(int n) {
            int answer = 0;
            string st = "";
            while (n > 0)
            {
                st +=n%3;
                n /=3;
            }
            
            int cnt = 0;
            for(int i = 0 ; i < st.Length; i++)
            {
                if(st[i] == '0')cnt++;
                else break;
            }
            st = st.Substring(cnt,st.Length-cnt);
            Console.WriteLine(st);
            for(int i = 0; i < st.Length; i++)
            {
                Console.WriteLine((int)Math.Pow(3, i) * (st[i]-'0'));


                answer += (int)Math.Pow(3,st.Length-1-i)*int.Parse(st[i].ToString());
            }
            return answer;
    }
}