using System.Linq;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = strings.OrderBy(x=>x[n]).ThenBy(x=>x).ToArray();
        return answer;
    }
}