using System;using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
            List<int> answer = new List<int>();

            switch (n)
            {
                case 1:
                    for (int i = 0; i <= slicer[1]; i++)
                        answer.Add(num_list[i]);
                    break;
                case 2:
                    for (int i = slicer[0]; i < num_list.Length; i++)
                        answer.Add(num_list[i]);
                    break;
                case 3:
                    for (int i = slicer[0]; i <= slicer[1]; i++)
                        answer.Add(num_list[i]);
                        break;
                case 4:
                    for (int i = slicer[0]; i <= slicer[1]; i +=slicer[2])
                        answer.Add(num_list[i]);
                    break;
            }

            return answer.ToArray();
    }
}