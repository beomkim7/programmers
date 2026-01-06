using System;
public class Solution {
    public long solution(int n) {
            if (n == 1) return 1;
            if (n == 2) return 2;


            long[] check = new long[n + 1];
            check[1] = 1;
            check[2] = 2;
            
            for (int i = 3; i <= n; i++)
            {
                check[i] = (check[i - 1] + check[i - 2]) % 1234567;
            }
            

            return check[n];
    }
}