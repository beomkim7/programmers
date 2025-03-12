using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
                       List<int> lst = new List<int>();
            switch (n)
            {
                case 1:
                    for (int i = 0; i <= slicer[1]; i++)
                        lst.Add(num_list[i]);
                    break;
                case 2:
                    for (int i = slicer[0]; i < num_list.Length; i++)
                        lst.Add(num_list[i]);
                    break;
                case 3:
                    for (int i = slicer[0]; i <= slicer[1]; i++)
                        lst.Add(num_list[i]);
                    break;
                case 4:
                    for (int i = slicer[0]; i <= slicer[1]; i=i+slicer[2])
                        lst.Add(num_list[i]);
                    break;

            }

            return lst.ToArray();
    }
}