using System.Linq;
public class Solution {
    public string solution(string s) {
            string answer = "";
            string[] sArr = s.Split(' ');

            sArr = sArr.OrderByDescending(x => int.Parse(x)).ToArray();

            answer = string.Join(" ", sArr[sArr.Length-1], sArr[0]);
            return answer;
    }
}