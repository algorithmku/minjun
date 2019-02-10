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

    // Complete the pickingNumbers function below.
    static int pickingNumbers(int[] a) {

        int result = 0; // 결과값

        for(int i = 0; i < a.Length ; i++){ //기준 숫자
            int currentCnt = 0; //기준 숫자별 카운트용
            for(int j = 0 ; j < a.Length ; j++){ // 같은 배열 하나씩 비교
                if(a[i] == a[j] || a[i] +1 == a[j]){ // 자기랑 똑같거나 차이가 +1인것은 카운트 
                    currentCnt = currentCnt +1;
                }
            }
            if(result < currentCnt){ // 가장 수가 높은게 결과로 나와야함
                result = currentCnt;
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        //int result = pickingNumbers(a[n]);
        int result = pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}