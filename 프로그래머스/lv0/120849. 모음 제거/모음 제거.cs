using System;

public class Solution {
    public string solution(string my_string) {
        string[] replaceText = new string[] { "a", "e", "i", "o", "u" };
        string answer = my_string;
        foreach(string str in  replaceText)
        {
            answer = answer.Replace(str, "");
        }
        return answer;
    }
}