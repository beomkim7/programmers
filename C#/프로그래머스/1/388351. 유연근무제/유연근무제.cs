using System;

public class Solution {
public int solution(int[] schedules, int[,] timelogs, int startday)
        {
            int answer = 0;

            int length = schedules.Length;
            
            for(int i = 0; i < length; i++)
            {
                bool check = true;
                int pixD = startday;
                DateTime schedule = convertT(schedules[i].ToString()).AddMinutes(10);

                for(int j = 0; j < timelogs.GetLength(1); j++)
                {
                    if (pixD > 7) pixD = 1;

                    if (pixD == 6 || pixD == 7)
                    {
                        pixD++;
                        continue;
                    }
                    
                    DateTime time = convertT(timelogs[i, j].ToString());
                    if (schedule < time)
                    {
                        check = false;
                        break;
                    }
                    pixD++;
                }

                if (check) answer++;
                
            }

            return answer;
        }

        public DateTime convertT(string s)
        {
            DateTime dt = Convert.ToDateTime(s.ToString().PadLeft(4, '0').Insert(2, ":"));
            return dt;
        }
}