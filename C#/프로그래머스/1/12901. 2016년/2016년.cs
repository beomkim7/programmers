public class Solution {
    public string solution(int a, int b) {
            string answer = "";

            string[] weekArr = new string[] { "THU" ,"FRI", "SAT", "SUN", "MON", "TUE", "WED" };
            int[] daysInMonth = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int days = 0;
            for (int i = 0; i < a - 1; i++) 
            {
                days += daysInMonth[i];
            }
            days += b;
            answer = weekArr[days % 7];

            return answer;
    }
}