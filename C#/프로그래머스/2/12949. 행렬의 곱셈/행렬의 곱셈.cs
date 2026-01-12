using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
            int row1 = arr1.GetLength(0);
            int col1 = arr1.GetLength(1);
            int col2 = arr2.GetLength(1);

            int[,] answer = new int[row1,col2];
            for(int i = 0; i<row1;i++)
                for(int j = 0; j <col2;j++)
                    for(int z = 0; z < col1; z++)
                    {
                        answer[i, j] += arr1[i, z] * arr2[z, j];
                    }


            return answer;
    }
}