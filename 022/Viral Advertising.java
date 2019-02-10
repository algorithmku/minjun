import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the viralAdvertising function below.
    static int viralAdvertising(int n) {
        //광고는 한번만 받음 
        //친구랑 공유함
        //누적된 좋아요 숫자 체크 
        
        // 1일차는 고정 5명중 2명이 좋아요 
        // 2명이 3명씩 공유 
        // 6명중 3명이 좋아요 
        // 둘째날 좋아요 누른 3명이 또 3명씩 공유 
        
            
        //1일차 뺴고 계산 
        n = n - 1;
        // 1일 좋아요 2로 시작 
       int like = 2;
       // 결과 합 (첫날은 2개 고정)
       int sum = 2;
        //공유
       int sharecnt = 0;
        //둘재날부터 체크
       while (n>0)
       {
           //3명 공유
           sharecnt = like * 3;
           //좋아요 체크 - 절반이 좋아함 
           //좋아요 한사람만 또 공유 함 3명에게 
           like = sharecnt/2;
           --n;
           sum += like;
       }
        
        return sum;

    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int result = viralAdvertising(n);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
