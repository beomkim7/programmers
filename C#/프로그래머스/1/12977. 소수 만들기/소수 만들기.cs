using System;

class Solution
{
    public int solution(int[] nums)
        {
                        int answer = 0;

            for(int i = 0; i <nums.Length-2;i++)
                for(int j = i+1;j<nums.Length-1;j++)
                    for(int k = j+1; k < nums.Length; k++)
                    {
                        if (check(nums[i] + nums[j] + nums[k]) == 2) answer++;
                    }
            

            return answer;
        }

        public int check(int i)
        {
            int result = 0;
            for(int j = 1; j <= i ; j++)
            {
                if (i % j == 0) result++;
            }

            return result;
        }
}