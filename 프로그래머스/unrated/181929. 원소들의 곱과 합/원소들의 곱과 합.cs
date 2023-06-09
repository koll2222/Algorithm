using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        int mul = 1;
        int sum = num_list.Sum() * num_list.Sum();
        foreach(int n in num_list)
            mul *= n;
        
        return mul < sum ? 1 : 0;
    }
}