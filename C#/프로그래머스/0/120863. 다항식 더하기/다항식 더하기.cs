using System;
using System.Linq;
public class Solution {
    public string solution(string polynomial) {
            string answer = "";

            string[] arr = polynomial.Split(new string[] { " + " }, StringSplitOptions.RemoveEmptyEntries);

            string[] arrX = arr.Where(x => x.Contains("x")).ToArray();
            string[] arrNum = arr.Where(x => !x.Contains("x")).ToArray();

            string StrX = "";
            string StrNum = "";

            int xnum = 0;
            for (int i = 0; i < arrX.Length; i++)
                xnum += arrX[i].Replace("x", "") == "" ? 1 : int.Parse(arrX[i].Replace("x", ""));

            StrX = xnum == 0 ? "" : xnum == 1? "x": xnum.ToString() +"x";

            int num = arrNum.Select(x => int.Parse(x)).Sum();
            StrNum = num == 0 ? "" : num.ToString();

            if (!string.IsNullOrEmpty(StrX) && !string.IsNullOrEmpty(StrNum)) answer = StrX + " + " + StrNum;
            else answer = StrX + StrNum;

            return answer;
    }
}