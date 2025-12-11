using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] friends, string[] gifts) {
int answer = 0;

            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < friends.Length; i++) dict[friends[i]] = i;

            int n = friends.Length;
            int[,] gift = new int[n, n];

            for(int i = 0; i < gifts.Length; i++)
            {
                string[] giftArr = gifts[i].Split(' ');
                int A = dict[giftArr[0]];
                int B = dict[giftArr[1]];

                gift[A, B]++;
            }

            int[] score = new int[n];
            for(int i = 0; i < score.Length; i++)
            {
                int give = 0, take = 0;
                for (int j = 0; j < score.Length; j++)
                {
                    give += gift[i, j];
                    take += gift[j, i];
                }
                score[i] = give - take;
            }

            int[] receiveNext = new int[n];

            for(int i = 0; i < n;i++)
                for(int j = i + 1; j < n; j++)
                {
                    int giveA = gift[i, j];
                    int giveB = gift[j, i];

                    if (giveA > giveB) receiveNext[i]++;
                    else if(giveA < giveB) receiveNext[j]++;
                    else
                    {
                        if (score[i] > score[j]) receiveNext[i]++;
                        else if(score[i] < score[j]) receiveNext[j]++;
                    }
                }
            answer = receiveNext.Max();    

            return answer;
    }
}