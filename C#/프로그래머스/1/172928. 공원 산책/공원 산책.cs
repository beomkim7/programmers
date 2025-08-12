using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
int[] answer = new int[2];

            int rows = park.Length;
            int cols = park[0].Length;

            for(int y = 0; y < rows;y++)
                for(int x = 0; x < cols;x++)
                    if(park[y][x] == 'S')
                    {
                        answer[0] = y;
                        answer[1] = x;
                    }

            foreach(string s in routes)
            {
                int ny = answer[0];
                int nx = answer[1];

                string[] split = s.Split(' ');
                string dir = split[0];
                int move = int.Parse(split[1]);

                bool Canmove = true;

                switch (dir)
                {
                    case "N":
                        ny -= move;
                        if (ny >= 0)
                        {
                            for (int i = 1; i <= move; i++)
                            {
                                if (park[answer[0] - i][answer[1]] == 'X')
                                    Canmove = false;
                            }
                        }
                        else 
                            Canmove = false;

                        break;

                    case "S":
                        ny += move;
                        if (ny < rows)
                        {
                            for (int i = 1; i <= move; i++)
                                if (park[answer[0] + i][answer[1]] == 'X')
                                    Canmove = false;
                        }
                        else 
                            Canmove = false;
                        break;

                    case "W":
                        nx -= move;
                        if (nx >= 0)
                        {
                            for (int i = 1; i <= move; i++)
                            {
                                if (park[answer[0]][answer[1] - i] == 'X') Canmove = false;

                            }
                        }
                                
                        else Canmove = false;

                        break;

                    case "E":
                        nx += move;
                        if (nx < cols)
                        {
                            for (int i = 1; i <= move; i++)
                                if (park[answer[0]][answer[1] + i]=='X') Canmove = false;
                        }
                        else Canmove = false;
                        break;

                }
                if (Canmove)
                {
                    answer[0] = ny;
                    answer[1] = nx;
                }

            }


            return answer;
    }
}