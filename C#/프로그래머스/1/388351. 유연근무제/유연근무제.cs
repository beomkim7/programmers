using System;

public class Solution {
public int solution(int[] schedules, int[,] timelogs, int startday)
        {
            int answer = 0;

            for(int i = 0; i < schedules.Length; i++)
            {
                            int sDay = startday;

                bool check = true;
                DateTime sWork = ConverTime(schedules[i].ToString()).AddMinutes(10);
                for(int j = 0;j < timelogs.GetLength(1); j++)
                {
                    if (sDay > 7) sDay = 1;
                    if (sDay == 6 || sDay == 7)
                    {
                        sDay++;
                        continue;
                    }

                    DateTime getWork = ConverTime(timelogs[i, j].ToString());
                    if (sWork < getWork)
                    {
                        check = false;
                        break;
                    }
                    sDay++;
                }
                if (check) answer++;

            }

            return answer;
        }

        public DateTime ConverTime(string s)
        {
            DateTime dt = Convert.ToDateTime(s.PadLeft(4, '0').Insert(2, ":"));
            return dt;
        }
}