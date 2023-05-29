using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string tmp = n.ToString();
        for(int i = 0; i < tmp.Length; i++)
        {
            answer += tmp[i] - '0';
        }
        return answer;
    }
}