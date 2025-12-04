using System;

public class Solution {
    public int solution(string[] babbling) {
int answer = 0;
            string[] st = new string[] { "aya", "ye", "woo", "ma" };

            foreach(string s in babbling)
            {
                string temp = s;
                string prev = "";
                bool possible = true;
                
                while (temp.Length>0)
                {
                    bool match = false;
                    for(int i = 0; i < st.Length; i++)
                    {
                        if (temp.StartsWith(st[i]))
                        {
                            if (st[i] == prev)
                            {
                                possible = false;
                                match = false;   
                                break;
                            }
                            match = true;
                            prev = st[i];
                            temp = temp.Substring(st[i].Length);
                        }
                    }
                    if (!match)
                    {
                        possible = false;                    
                        break;
                    }
                }
                if (possible) answer++;
            }

            return answer;
    }
}