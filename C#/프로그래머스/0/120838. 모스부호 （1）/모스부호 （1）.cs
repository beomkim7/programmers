using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string letter) {
            string answer = "";

            Dictionary<string, string> dict = new Dictionary<string, string>();
string morse = @"'.-':'a','-...':'b','-.-.':'c','-..':'d','.':'e','..-.':'f','--.':'g','....':'h','..':'i','.---':'j','-.-':'k','.-..':'l','--':'m','-.':'n','---':'o','.--.':'p','--.-':'q','.-.':'r','...':'s','-':'t','..-':'u','...-':'v','.--':'w','-..-':'x','-.--':'y','--..':'z'";

            string[] moresArr = morse.Replace(@"'", "").Split(',');

            for (int i = 0; i < moresArr.Length; i++)
            {
                dict.Add(moresArr[i].Split(':')[0], moresArr[i].Split(':')[1]);
            }

            string[] letterArr = letter.Split(' ');
            foreach(var x in letterArr)
            {
                answer += dict[x];
            }


            return answer;
    }
}