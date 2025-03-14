using System;
using System.Linq;
public class Solution {
    public int solution(int[] arr) {
            int answer = 0;
            int[] prevArr;

            while (true)
            {
                prevArr = arr.ToArray(); // 현재 상태 저장
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] >= 50 && arr[i] % 2 == 0)
                        arr[i] /= 2; // 짝수이면서 50 이상인 경우 2로 나눔
                    else if (arr[i] < 50 && arr[i] % 2 == 1)
                        arr[i] = arr[i] * 2 + 1; // 홀수이면서 50 미만인 경우 2배 후 +1
                }

                answer++;

                if (arr.SequenceEqual(prevArr)) // 이전 배열과 같으면 종료
                    return answer - 1; // 마지막 불필요한 증가 조정
            }
    }
}