using System;

public class Solution {
public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
        {
            string answer = "";
            int len = convertToSec(video_len);
            int now = convertToSec(pos);
            int start = convertToSec(op_start);
            int end = convertToSec(op_end);
            if (now >= start && now < end) now = end;

            foreach (string s in commands)
            {
                if (s == "next")
                {
                    now += 10;
                    now = result(len, now, start, end);                    
                }
                else
                {
                    now -= 10;
                    now = result(len, now, start, end);
                }
            }
            answer = ((now / 60).ToString().PadLeft(2, '0') + (now % 60).ToString().PadLeft(2, '0')).Insert(2, ":");
            return answer;
        }
        public int result(int len,int now,int start,int end)
        {            
            if (now < 0) now = 0;
            if (now > len) now = len;
            if (now >= start && now < end) now = end;
            return now;
        }

        public int convertToSec(string s)
        {
            string[] sParse = s.Split(':');
            return int.Parse(sParse[0]) * 60 + int.Parse(sParse[1]);
        }
}