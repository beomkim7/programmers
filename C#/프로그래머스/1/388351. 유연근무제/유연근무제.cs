using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
            Console.WriteLine(timelogs.GetLength(1));
            for(int i = 0; i < schedules.Length; i++)
            {
                int clearD = startday;
                bool check = true;
                DateTime checkSch = convertDT(schedules[i]).AddMinutes(10);
                for(int j = 0; j < timelogs.GetLength(1); j++)
                {
                    if (clearD > 7) clearD = 1;
                    if (clearD == 6 || clearD == 7)
                    {
                        clearD++;
                        continue;
                    }
                    DateTime timeC = convertDT(timelogs[i, j]);
                    if (checkSch < timeC)
                    {
                        check = false;
                        break;
                    }
                    clearD++;
                }
                if (check) answer++;
            }

            return answer;
        }

        public DateTime convertDT(int i)
        {
            DateTime dt = Convert.ToDateTime(i.ToString().PadLeft(4, '0').Insert(2,":"));
            return dt;
        }
}