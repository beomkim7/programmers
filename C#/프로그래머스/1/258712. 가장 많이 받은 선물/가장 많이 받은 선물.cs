using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string[] friends, string[] gifts){
            int answer = 0;
            int n = friends.Length;

            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < n; i++) dict[friends[i]] = i;

            int[,] receiver = new int[n, n];
            for(int i = 0; i < gifts.Length; i++)
            {
                string[] giftArr = gifts[i].Split(' ');
                int A = dict[giftArr[0]];
                int B = dict[giftArr[1]];

                receiver[A, B]++;
            }

            //for (int i = 0; i < receiver.GetLength(0); i++)
            //{
            //    for (int j = 0; j < receiver.GetLength(1); j++)
            //        Console.Write(receiver[i, j]);
            //    Console.WriteLine();
            //}

            int[] grade = new int[n];
            for(int a = 0; a < n; a++)
            {
                int give = 0, take = 0;
                for(int b= 0; b < n; b++)
                {
                    give += receiver[a, b];
                    take += receiver[b, a];
                }
                grade[a] += give - take;
            }
            //Console.WriteLine(string.Join(",", grade));

            int[] final = new int[n];
            for(int a= 0; a < n; a++)
            {
                for(int b = a + 1; b < n; b++)
                {
                    if (receiver[a, b] > receiver[b, a]) final[a]++;
                    else if(receiver[a, b] < receiver[b, a]) final[b]++;
                    else
                    {
                        if (grade[a] > grade[b]) final[a]++;
                        else if (grade[a] < grade[b]) final[b]++;
                    }
                }
            }
            
            answer = final.Max();
            return answer;
        }
}