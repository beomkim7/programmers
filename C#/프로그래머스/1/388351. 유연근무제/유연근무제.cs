using System;

public class Solution {
public int solution(int[] schedules, int[,] timelogs, int startday)
        {
            int answer = 0;
            
            for(int i = 0; i < schedules.Length; i++)
            {
                bool check = true;
                int day = startday;
                DateTime checkDT = ConverT(schedules[i].ToString()).AddMinutes(10);

                for (int j = 0; j < timelogs.GetLength(1); j++)
                {
                    if (day > 7) day = 1;
                    if(day ==6 || day == 7)
                    {
                        day++;
                        continue;
                    }

                    DateTime LogTime = ConverT(timelogs[i, j].ToString());
                    if (checkDT < LogTime)
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

        public DateTime ConverT(string s)
        {
            DateTime dt = Convert.ToDateTime(s.PadLeft(4, '0').Insert(2, ":"));
            return dt;
        }
}