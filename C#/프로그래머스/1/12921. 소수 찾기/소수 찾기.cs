public class Solution {
        public int solution(int n)
        {
            int answer = 0;
            bool[] check = new bool[n + 1];

            for(int i =2; i <= n; i++)
            {
                if (!check[i])
                {
                    answer++;
                    for (int j = i; j <= n; j += i) check[j] = true;
                }
            }

            return answer;
        }
}