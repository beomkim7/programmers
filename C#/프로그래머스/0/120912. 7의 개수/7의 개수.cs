using System;

public class Solution {
    public int solution(int[] array) {
                int answer = 0;
                string chage = "";

                for (int i = 0; i < array.Length; i++) chage += array[i].ToString();
                for (int i = 0; i < chage.Length; i++) if (chage[i].ToString() == "7") answer++;
                

                return answer;
    }
}