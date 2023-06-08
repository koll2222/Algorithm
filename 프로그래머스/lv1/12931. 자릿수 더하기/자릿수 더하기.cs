using System;

public class Solution {
    public int solution(int n)
        {
            int answer = 0;
            string txt = n.ToString();
            for(int i = 0; i < txt.Length; i++)
            {
                answer += txt[i] - '0';
            }
            return answer;
        }
}