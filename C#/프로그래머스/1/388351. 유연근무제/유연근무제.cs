using System;

public class Solution {
public int solution(int[] schedules, int[,] timelogs, int startday)
        {
            int answer = 0;

            for(int i = 0; i < schedules.Length; i++)
            {
                DateTime dt = ConvertT(schedules[i]).AddMinutes(10);
                int day = startday;
                bool check = true;

                for(int j = 0; j < timelogs.GetLength(1); j++)
                {
                    if (day == 6 || day == 7)
                    {
                        day++;
                        continue;
                    }
                    if (day > 7) day = 1;
                    DateTime Chkdt = ConvertT(timelogs[i, j]);
                    if(Chkdt> dt)
                    {
                        check = false;
                        break;
                    }
                    day++;
                }
                if (check) answer++;
            }

            return answer;
        }

        private DateTime ConvertT(int i)
        {
            string s = i.ToString().PadLeft(4, '0').Insert(2, ":");
            DateTime dt = Convert.ToDateTime(s);
            return dt;
        }
}