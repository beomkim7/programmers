using System;

public class Solution {
    public int solution(int[] arr) {
            int answer = 0;
            while (true)
            {
                int check = 0;
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 50 && arr[i] % 2 == 0)
                    {
                        arr[i] /= 2;
                        check++;
                    }
                    else if (arr[i] < 50 && arr[i] % 2 == 1)
                    {
                        arr[i] = arr[i] * 2 + 1;
                        check++;
                    }
                }
                if (check == 0) break;
                answer++;
            }

            return answer;
    }
}