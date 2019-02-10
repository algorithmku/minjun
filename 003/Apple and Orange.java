/*
Apple and Orange
https://www.hackerrank.com/challenges/apple-and-orange/problem
*/
import java.io.*;
import java.math.*;
import java.text.*;
import java.util.*;
import java.util.regex.*;

public class Solution {

    /*
     * Complete the countApplesAndOranges function below.
     */
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        /*
         * Write your code here.
         */
        
        // 샘 집에 있는 래리와 롭 
        // 수평선 풀이 
        // 7과 10은 s 와 t 의 값 즉 유효범위 값 
        // 5와 15는 a 와 b 의 위치 5는 사과 15는 오렌지
        // apples 와 oranges 는 각자 던진 갯수 
        
  
        int a_point = 0;
        int b_point = 0; 
        
        for (int i = 0 ; i < apples.length ; i++){
            if (s <= a + apples[i] && t >= a + apples[i]){
                a_point += 1;
            }
        }
        for (int j = 0 ; j < oranges.length ; j++){
            if (s <= b + oranges[j] && t >= b + oranges[j]){
                b_point += 1;
            }
        }
        
        System.out.printf(Integer.toString(a_point) + "\n");
        System.out.printf(Integer.toString(b_point));
    }

    private static final Scanner scan = new Scanner(System.in);

    public static void main(String[] args) {
        String[] st = scan.nextLine().split(" ");

        int s = Integer.parseInt(st[0].trim());

        int t = Integer.parseInt(st[1].trim());

        String[] ab = scan.nextLine().split(" ");

        int a = Integer.parseInt(ab[0].trim());

        int b = Integer.parseInt(ab[1].trim());

        String[] mn = scan.nextLine().split(" ");

        int m = Integer.parseInt(mn[0].trim());

        int n = Integer.parseInt(mn[1].trim());

        int[] apple = new int[m];

        String[] appleItems = scan.nextLine().split(" ");

        for (int appleItr = 0; appleItr < m; appleItr++) {
            int appleItem = Integer.parseInt(appleItems[appleItr].trim());
            apple[appleItr] = appleItem;
        }

        int[] orange = new int[n];

        String[] orangeItems = scan.nextLine().split(" ");

        for (int orangeItr = 0; orangeItr < n; orangeItr++) {
            int orangeItem = Integer.parseInt(orangeItems[orangeItr].trim());
            orange[orangeItr] = orangeItem;
        }

        countApplesAndOranges(s, t, a, b, apple, orange);
    }
}