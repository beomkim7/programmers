using System;

public class Solution {
    public string solution(string my_string, int[,] queries) {
        
        char[] arr = my_string.ToCharArray();
        for(int i = 0 ; i <queries.GetLength(0);i++){
            int start = queries[i,0];
            int end = queries[i,1];
            Array.Reverse(arr,start,end-start+1);
        }
        
        return new string(arr);
    }
}