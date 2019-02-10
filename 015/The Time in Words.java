import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    private final static String[] lut = {
            "zero"
            , "one"
            , "two"
            , "three"
            , "four"
            , "five"
            , "six"
            , "seven"
            , "eight"
            , "nine"
            , "ten"
            , "eleven"
            , "twelve"
            , "thirteen"
            , "fourteen"
            , "fifteen"
            , "sixteen"
            , "seventeen"
            , "eighteen"
            , "nineteen"
            , "twenty"
            , "twenty one"
            , "twenty two"
            , "twenty three"
            , "twenty four"
            , "twenty five"
            , "twenty six"
            , "twenty seven"
            , "twenty eight"
            , "twenty nine"
            , "thirty"
    };
    
    // Complete the timeInWords function below.
    static String timeInWords(int h, int m) {

        StringBuilder result = new StringBuilder();

        if (m != 0) {
            if (m == 30) {
                result.append("half past ");
            }else if (m == 15){
                result.append("quarter past ");
            } else if (m == 45) {
                result.append("quarter to ");
                h = (h + 1) % 12;
            } else if (m < 30) {
                result.append(lut[m]);
                if (m == 1) {
                    result.append(" minute past ");
                } else {
                    result.append(" minutes past ");
                }
            } else if (m > 30) {
                m = 60 - m;

                result.append(lut[m]);
                
                if (m == 1) {
                    result.append(" minute to ");
                } else {
                    result.append(" minutes to ");
                }

                h = (h + 1) % 12;
            }
        }
        
        result.append(lut[h]);
        
        if (m == 0) {
        result.append(" o' clock");
        }
        
        return result.toString();
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int h = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        int m = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        String result = timeInWords(h, m);

        bufferedWriter.write(result);
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}