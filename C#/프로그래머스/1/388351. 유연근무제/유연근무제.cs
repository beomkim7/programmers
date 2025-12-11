using System;

public class Solution {
public int solution(int[] schedules, int[,] timelogs, int startday)
        {
            int answer = 0;

            for(int i = 0; i < schedules.Length; i++)
            {
                DateTime checkT = ConverTotime(schedules[i]).AddMinutes(10);
                int day = startday;
                bool finish = true;
                for(int j = 0; j < timelogs.GetLength(1); j++)
                {
                    if (day > 7) day = 1;
                    if (day == 6 || day == 7)
                    {
                        day++;
                        continue;
                    }

                    DateTime logTime = ConverTotime(timelogs[i, j]);

                    if (checkT < logTime)
                    {
                        finish = false;
                        break;
                    }
                    day++;
                }
                if (finish) answer++;
            }

            return answer;
        }

        public DateTime ConverTotime(int i)
        {
            DateTime dt = Convert.ToDateTime(i.ToString().PadLeft(4, '0').Insert(2, ":"));
            return dt;
        }
}