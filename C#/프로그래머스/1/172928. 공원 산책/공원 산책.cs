using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
 int[] answer = new int[2];

            int garo = park[0].Length;
            int sero = park.Length;

            int gaS = 0;
            int seS = 0;
            for(int i = 0; i < sero; i++)
            {
                if (park[i].Contains("S"))
                    for (int j = 0; j < garo; j++)
                        if (park[i][j] == 'S')
                        {
                            gaS = j;seS = i;
                            break;
                        }
            }

            foreach(string s in routes)
            {
                string[] sArr = s.Split(' ');
                string dir = sArr[0];

                int dx = 0;
                int dy = 0;
                int count = int.Parse(sArr[1]);

                switch (dir)
                {
                    case "E":dx++; break;
                    case "W":dx--; break;
                    case "S":dy++; break;
                    case "N":dy--; break;
                }

                int nextX = gaS + dx * count;
                int nextY = seS + dy * count;

                bool check = true;
                if (nextX < 0 || nextX >= garo || nextY < 0 || nextY >= sero)
                {
                    check = false;
                    continue;
                }
                else
                {
                    for (int i = 1; i <= count; i++)
                    {
                        if (park[seS + dy * i][gaS + dx * i] == 'X') 
                        {
                            check = false;
                            break;
                        }
                    }
                }

                if (check)
                {
                    gaS = nextX;
                    seS = nextY;
                }
            }
            answer[0] = seS;
            answer[1] = gaS;

            return answer;
    }
}