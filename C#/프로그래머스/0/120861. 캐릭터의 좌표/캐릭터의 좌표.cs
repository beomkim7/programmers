using System;
using System.Collections.Generic;
public class Solution {
public int[] solution(string[] keyinput, int[] board) 
{
    int[] answer = new int[2];
    
    Dictionary<string, int[]> dict = new Dictionary<string, int[]>
    {
        { "left", new int[] { -1, 0 } },
        { "right", new int[] { 1, 0 } },
        { "up", new int[] { 0, 1 } },
        { "down", new int[] { 0, -1 } }
    };
    
    int limitX = (board[0] - 1) / 2;
    int limitY = (board[1] - 1) / 2;
    
    foreach (string st in keyinput)
    {
        int nx = answer[0] + dict[st][0];
        int ny = answer[1] + dict[st][1];
        
        if (Math.Abs(nx) <= limitX && Math.Abs(ny) <= limitY)
        {
            answer[0] = nx;
            answer[1] = ny;
        }
        // 넘어가면 이동 안 함
    }
    
    return answer;
}

}