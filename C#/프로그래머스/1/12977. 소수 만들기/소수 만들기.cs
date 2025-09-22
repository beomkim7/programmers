using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

            for(int i = 0; i < nums.Length - 2; i++)
            {
                
                for(int j = i+1;j < nums.Length - 1; j++)
                {
                    for(int z = j + 1; z < nums.Length; z++)
                    {
                        bool check = true;
                        int sum = nums[i] + nums[j] + nums[z];

                        for(int num = 2; num <= Math.Sqrt(sum); num++)
                        {
                            if (sum % num == 0)
                            {
                                check = false;
                                break;
                            }                            
                        }
                        if (check) answer++;
                    }
                }
                
            }

            return answer;
    }
}