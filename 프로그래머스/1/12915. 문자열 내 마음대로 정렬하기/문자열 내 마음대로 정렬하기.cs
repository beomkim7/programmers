public class Solution {
    public string[] solution(string[] strings, int n) {
            string[] answer = new string[] { };

            for(int i = 0; i < strings.Length - 1; i++)
            {
                for(int j = i+1 ; j < strings.Length; j++)
                {
                    if (strings[i][n] > strings[j][n])
                    {
                        string temp = strings[i];
                        strings[i] = strings[j];
                        strings[j] = temp;
                    }
                    else if(strings[i][n] == strings[j][n])
                    {
                        if (string.Compare(strings[i], strings[j]) > 0)
                        {
                            string temp = strings[i];
                            strings[i] = strings[j];
                            strings[j] = temp;
                        }
                    }
                }
            }
            return strings;
    }
}