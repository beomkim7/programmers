using System;
using System.Globalization;
public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday)
        {
            int answer = 0;

            for (int i = 0; i < schedules.Length; i++)
            {
                bool check = true;
                int checkday = startday;

                for (int j = 0; j < timelogs.GetLength(1); j++)  // 열 순회인지 행 순회인지 확인 필요
                {
                    checkday = checkday > 7 ? 1 : checkday;

                    if (checkday == 6 || checkday == 7)
                    {
                        checkday++;
                        continue;
                    }

                    
                    string startT = schedules[i].ToString();
                    DateTime startDateTime = parseDT(startT).AddMinutes(10);

                    
                    string checkT = timelogs[i, j].ToString();
                    DateTime checkDateTime = parseDT(checkT);

                    if (startDateTime < checkDateTime)
                    {
                        check = false;
                        break;
                    }

                    checkday++;
                }

                if (check) answer++;
            }

            return answer;

        }

        public DateTime parseDT(string st)
        {
            
            if (st.Length == 3) st = "0" + st;
            st = st.Insert(st.Length - 2, ":");            
            return DateTime.ParseExact(st,"HH:mm",CultureInfo.InvariantCulture);
        }
}