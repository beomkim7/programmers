using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string[] strArr) {
                    return strArr.GroupBy(x => x.Length).Max(x=>x.Count());
    }
}