using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
int arr1ga = arr1.GetLength(0);
            int arr1se = arr1.GetLength(1);
            int arr2se = arr2.GetLength(1);
            Console.WriteLine(arr1ga);
            Console.WriteLine(arr1se);

            int[,] answer = new int[arr1ga, arr2se];

            for(int i = 0; i < arr1ga; i++)
                for(int j = 0; j < arr2se;j++)
                    for(int z= 0; z < arr1se; z++)
                    {
                        answer[i, j] += arr1[i, z] * arr2[z, j];
                    }

            return answer;
    }
}