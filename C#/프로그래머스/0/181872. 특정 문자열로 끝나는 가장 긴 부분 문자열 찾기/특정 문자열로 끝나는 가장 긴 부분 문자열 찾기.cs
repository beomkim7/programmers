using System;
using System.Linq;
public class Solution {
    public string solution(string myString, string pat) {
        return new string(myString.Take(myString.LastIndexOf(pat)).ToArray())+pat;
    }
}