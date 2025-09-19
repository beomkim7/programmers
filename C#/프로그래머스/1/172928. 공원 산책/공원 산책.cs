using System;
using System.Linq;
public class Solution {
public int[] solution(string[] park, string[] routes)
        {
            int garo = park[0].Length;
            int sero = park.Length;

            int gaS = 0;
            int seS = 0;
            for(int i = 0; i < sero; i++)
            {
                if (park[i].Contains("S"))
                {
                    gaS = park[i].IndexOf('S');
                    seS = i;
                    break;
                }
            }
            int[] answer = new int[] {seS,gaS};
            
            foreach(string s in routes)
            {
                string[] sArray = s.Split(' ').ToArray();
                string dir = sArray[0];
                int distance = int.Parse(sArray[1]);

                int dx = 0;
                int dy = 0;
                switch (dir)
                {
                    case "E": dx++; break;
                    case "W": dx--; break;
                    case "S": dy++; break;
                    case "N": dy--; break;
                }

                int nextX = answer[1] + dx * distance;
                int nextY = answer[0] + dy * distance;

                bool check = true;
                if(nextX < 0 || nextX >= garo || nextY < 0 || nextY >= sero) check = false;
                else
                {
                    for (int i = 1; i <= distance; i++)
                    {
                        if (park[answer[0] + dy * i][answer[1] + dx * i] == 'X')
                        {
                            check = false;
                            break;
                        }
                    }
                }
                

                if (check)
                {
                    answer[0] = nextY;
                    answer[1] = nextX;
                }
                
            }


            return answer;
        }
}