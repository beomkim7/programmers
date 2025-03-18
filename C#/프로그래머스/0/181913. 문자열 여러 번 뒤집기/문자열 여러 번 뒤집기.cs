using System;

public class Solution {
    public string solution(string my_string, int[,] queries) {
            string answer = "";

            for(int i = 0; i < queries.GetLength(0); i++)
            {
                int start = queries[i, 0];
                int end = queries[i, 1];
                string arr = "";
                string reverseArr = "";

                for (int j = start; j <= end; j++) arr += my_string[j];
                for (int k = arr.Length - 1; k >= 0; k--) reverseArr += arr[k];

                my_string = my_string.Remove(start, end-start+1);
                my_string = my_string.Insert(start, reverseArr) ;

            }

            return my_string;
    }
}