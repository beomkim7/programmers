using System;

class Solution
{
    public int solution(int[] nums)
        {
            int answer = 0;

            for(int i = 0; i <nums.Length-2;i++)
                for(int j = i+1;j<nums.Length-1;j++)
                    for(int z= j + 1; z < nums.Length; z++)
                    {
                        if(check(nums[i] + nums[j] + nums[z])==2) answer++;

                    }
            return answer;
        }

        public int check(int num)
        {
            int result = 0;
            for (int i = 1; i <= num; i++)
                if (num % i == 0) result++;
            return result;
        }
}