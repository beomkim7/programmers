using System.Linq;
public class Solution {
    public string solution(string s) {
            string answer = "";
            string[] sArr = s.Split(' ');
            int[] nArr = new int[sArr.Length];
            for (int i = 0; i < sArr.Length; i++) 
                nArr[i] = int.Parse(sArr[i]);

            string max = nArr.Max().ToString();
            string min = nArr.Min().ToString();
            answer = string.Join(" ", min, max);
            return answer;
    }
}