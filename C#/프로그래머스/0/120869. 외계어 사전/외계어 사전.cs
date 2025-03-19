using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
            int answer = 2;

            for(int i = 0; i < dic.Length;i++)
                for(int j = 0; j < spell.Length; j++)
                {
                    Console.Write(spell[j]);
                    if (dic[i].IndexOf(spell[j]) == -1) break;
                    else dic[i] = dic[i].Remove(dic[i].IndexOf(spell[j]), 1);
                    if (string.IsNullOrEmpty(dic[i])&& j==spell.Length-1) answer = 1;
                }

            return answer;
    }
}