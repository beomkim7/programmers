public class Solution {
    public int solution(int n) {
    bool[] isNotPrime = new bool[n + 1]; // false면 소수
    int answer = 0;

    for (int i = 2; i <= n; i++)
    {
        if (!isNotPrime[i])
        {
            answer++;

            for (int j = i * 2; j <= n; j += i)
            {
                isNotPrime[j] = true;
            }
        }
    }

    return answer;
    }
}