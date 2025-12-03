using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
long cost = 0;
            for(int i = 1; i <= count; i++)
            {
                cost += price * (long)i;
            }
            long total = money;

            if (cost > total) return Math.Abs(total-cost);
            else return 0;
    }
}