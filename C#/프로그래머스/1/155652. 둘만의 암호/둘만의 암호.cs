using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Solution {
    public string solution(string s, string skip, int index) {
StringBuilder sb = new StringBuilder();
HashSet<char> skipSet = new HashSet<char>(skip);

foreach (char c in s)
{
    int check = 0;
    char upc = c;

    while (check < index)
    {
        upc++;
        if (upc > 'z') upc = 'a';
        if (!skipSet.Contains(upc)) check++;
    }

    sb.Append(upc);
}

return sb.ToString();
    }
}