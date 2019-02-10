/*
Divisible Sum Pairs 
https://www.hackerrank.com/challenges/divisible-sum-pairs/problem
*/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    static int divisibleSumPairs(int n, int k, int[] ar) {
        // Complete this function
        // 배열에 있는 숫자를 2개씩 합하여 k로 나누어 떨어지는지 확인.
        // 결과값 선언
        int result = 0;
        // 이중 포문을 돌림 [0,1] [0,2]............. 
        for(int i = 0 ; i < n ; i++){        
            for(int j = i + 1; j < n ; j++){
                if((ar[i] + ar[j]) % k == 0){
                    result++;
                }        
            }
        }
        return result;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int k = in.nextInt();
        int[] ar = new int[n];
        for(int ar_i = 0; ar_i < n; ar_i++){
            ar[ar_i] = in.nextInt();
        }
        int result = divisibleSumPairs(n, k, ar);
        System.out.println(result);
    }
}