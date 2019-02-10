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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {

        /*
            n = 양말의 갯수
            ar = 양말의 숫자
            같은 양말끼리 묶을수 있음
            몇 쌍이 나오는가 ? 

        */
        int cnt = 0;
        // 일단 중복을 제거해서 뭐뭐 있다 배열에 넣어보자.
        int[] a = ar.Distinct().ToArray();
        
        for(int i = 0 ; i < a.Length ; i++){
            int cnt_a = ar.Where(num => num == a[i]).Count();
            if (cnt_a/2 > 0){
                cnt += cnt_a/2;
            }
        }
        
        return cnt;



    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
