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

    // Complete the minimumDistances function below.
    static int minimumDistances(int[] a) {
        
        // 배열의 같은 숫자의 사이 값을 구함 
        // 사이값이 가장 작은 값을 결과값으로 
        // 7 1 3 4 1 7 에는 
        // 1이 2개 있고 7이 2개 있음
        // 1와 1 사이에는 3,4가 있고 그것을 칸으로 보면 1,3,4 총 3칸 index
        // 7과 7 사이에는 1,3,4,1 가 있고 그것을 칸으로 보면 7,1,3,4,1 총 5칸 index
        // 조건상 최대값  10^5 = 100000
        // If no such value exists, print -1 같은거 없으면 -1
        
        int minVal = 100000;
        
        for (int i = 0 ; i < a.Length ; i ++){
            for(int j = i + 1 ; j < a.Length ; j++){
                if (a[i] == a[j]){
                    if (minVal > j-i) {
                        minVal = j-i;
                    } else{
                        minVal = minVal;
                    }
                }
            }
        }
        if (minVal == 100000){
            return -1;
        }else{
            return minVal;
        }
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int result = minimumDistances(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
