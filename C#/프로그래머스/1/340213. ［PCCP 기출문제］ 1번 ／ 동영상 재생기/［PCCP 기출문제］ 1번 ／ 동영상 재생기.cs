using System;

public class Solution {
 public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
        {
            string answer = "";

            int len = toSecond(video_len);
            int now = toSecond(pos);
            int opS = toSecond(op_start);
            int opE = toSecond(op_end);
                            if (now >= opS && now <= opE)
                    now = opE;
            foreach(string s in commands)
            {

                if (s == "next")
                {

                    now = Math.Min(now + 10, len);
                }
                else
                {
                    now = Math.Max(now - 10, 0);
                }
                            if (now >= opS && now <= opE)
                    now = opE;
            }
            answer = getSecond(now);

            return answer;
        }

        public int toSecond(string s)
        {
            string[] parseS = s.Split(':');
            return int.Parse(parseS[0]) * 60 + int.Parse(parseS[1]);
        }

        public string getSecond(int i)
        {
            return $"{i / 60:D2}:{i % 60:D2}";
        }
}