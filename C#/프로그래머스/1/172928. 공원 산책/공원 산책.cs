using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
int[] answer = new int[2];
int rows = park.Length;
int cols = park[0].Length;

// 시작 위치 찾기
for (int y = 0; y < rows; y++)
{
    for (int x = 0; x < cols; x++)
    {
        if (park[y][x] == 'S')
        {
            answer[0] = y; // y좌표
            answer[1] = x; // x좌표
        }
    }
}

foreach (string route in routes)
{
    string[] split = route.Split(' ');
    string dir = split[0];
    int move = int.Parse(split[1]);

    int ny = answer[0];
    int nx = answer[1];
    bool canMove = true;

    switch (dir)
    {
        case "N":
            ny -= move;
            if (ny >= 0)
            {
                for (int i = 1; i <= move; i++)
                    if (park[answer[0] - i][answer[1]] == 'X') canMove = false;
            }
            else canMove = false;
            break;

        case "S":
            ny += move;
            if (ny < rows)
            {
                for (int i = 1; i <= move; i++)
                    if (park[answer[0] + i][answer[1]] == 'X') canMove = false;
            }
            else canMove = false;
            break;

        case "W":
            nx -= move;
            if (nx >= 0)
            {
                for (int i = 1; i <= move; i++)
                    if (park[answer[0]][answer[1] - i] == 'X') canMove = false;
            }
            else canMove = false;
            break;

        case "E":
            nx += move;
            if (nx < cols)
            {
                for (int i = 1; i <= move; i++)
                    if (park[answer[0]][answer[1] + i] == 'X') canMove = false;
            }
            else canMove = false;
            break;
    }

    if (canMove)
    {
        answer[0] = ny;
        answer[1] = nx;
    }
}

return answer;
    }
}