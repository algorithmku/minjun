using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the stockmax function below.
    // static int stockmax(int[] prices) {
    // 문제가 이상함 int 에서 long 으로 변경 
    static long stockmax(int[] prices) {

        long maxVal = 0;
        long result = 0;
        
        // 큰 값부터 비교
        for (int i = prices.Length-1; i >= 0; --i)
        {   
            // 차이값 선언 및 초기화
            long diffVal = 0;
            // 가장 큰 값과 현재 배열의 값과 비교하여 넣음 
            maxVal = Math.Max(maxVal, prices[i]);
            // 가장 큰 값에서 현재 값을 뺌
            diffVal = maxVal - prices[i];
            // result 에 더하기
            result += diffVal;
        }
        
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
            ;
            // 문제가 이상함 int 에서 long 으로 변경 
            //int result = stockmax(prices);
            long result = stockmax(prices);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}