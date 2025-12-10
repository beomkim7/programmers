using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
int[] answer = new int[2];

            int limitGaro = park[0].Length - 1;             //2
            int limitSero = park.Length - 1;                //4


            for(int i = 0; i < park.Length; i++)
            {
                if (park[i].Contains("S"))
                {
                    answer[1] = park[i].IndexOf("S");       //1
                    answer[0] = i;                          //0
                    break;
                }
            }

            for(int i = 0; i< routes.Length; i++)
            {
                string[] parseR = routes[i].Split(' ');     //["E 2","S 3","W 1"]

                string direction = parseR[0];               // E
                int move = int.Parse(parseR[1]);            // 2

                int garo = answer[1];                       //1
                int sero = answer[0];                       //0

                bool finishC = false;

                switch (direction)
                {
                    case "E":
                        if (garo + move > limitGaro) break;     //2 + 1 > 2

                        while (move > 0)
                        {
                            garo++; move--;
                            if (park[sero][garo] == 'X')
                            {
                                finishC = true;
                                break;
                            }
                        }
                        if (!finishC) answer[1] = garo;
                        break;
                    case "W":
                        if (garo - move < 0) break;

                        while (move > 0)
                        {
                            garo--; move--;
                            if (park[sero][garo] == 'X')
                            {
                                finishC = true;
                                break;
                            }
                        }
                        if (!finishC) answer[1] = garo;
                        break;
                    case "S":
                        if (sero + move > limitSero) break;

                        while (move > 0)
                        {
                            sero++; move--;
                            if (park[sero][garo] == 'X')
                            {
                                finishC = true;
                                break;
                            }
                        }
                        if (!finishC) answer[0] = sero;
                        break;
                    case "N":
                        if (sero - move < 0) break;

                        while (move > 0)
                        {
                            sero--; move--;
                            if (park[sero][garo] == 'X')
                            {
                                finishC = true;
                                break;
                            }
                        }
                        if(!finishC) answer[0] = sero;
                        break;
                }
            }


            return answer;
    }
}