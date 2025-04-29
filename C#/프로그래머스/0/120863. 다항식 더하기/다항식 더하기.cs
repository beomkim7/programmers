using System;
using System.Linq;
public class Solution {
        public string solution(string polynomial)
        {
            string answer = "";

            string[] stArr = polynomial.Split(new string[] { " + " }, StringSplitOptions.RemoveEmptyEntries);
            
            string[] xArr = stArr.Where(x => x.Contains("x")).ToArray();
            string[] numArr = stArr.Where(x => !x.Contains("x")).ToArray();

            int xValue = 0;
            for (int i = 0; i < xArr.Length; i++)
                xValue += xArr[i] == "x" ? 1 : Change(xArr[i]);

            int numValue = numArr.Select(x => int.Parse(x)).Sum();

            string st_X = xValue == 0 ? "" : xValue == 1 ? "x" : xValue + "x";
            string st_num = numValue == 0 ? "" : numValue.ToString();

            if (!string.IsNullOrEmpty(st_X) && !string.IsNullOrEmpty(st_num)) answer = st_X + " + " + st_num;
            else answer = st_X +  st_num;

            return answer;
        }

        public int Change(string X)
        {
            Console.WriteLine(X);
            return int.Parse(X.Remove(X.IndexOf("x"), 1));
        }
}