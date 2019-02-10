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

    // Complete the maxMin function below.
    static int maxMin(int k, int[] arr) {


        Array.Sort(arr);
        //1차시도 단순한 계산 실패
        /*
        int min = arr[0];
        int max = arr[k-1];
        int result = max - min;
        */
        
        int result = int.MaxValue;
/*
10
4

1
2
3
4
10
20
30
40
100
200
     */       
        for (int i = 0; i <= arr.Length - k; i++) {
            int x = arr[i + k - 1] - arr[i];
            /* 
            
            10 - 4 = 6 돌아감 
            arr[0+4-1] - arr[0] 
            
            4개씩 묶었을때 
            최대값 - 최소값이 나옴 
            3 2 1 0 으로 4개 라면 
            3 - 0 순서로 뺴는것과 동일하게 for 문을 이용함.
            
            arr[3] - arr[0] = 4 - 1 = 3 
            arr[4] - arr[1] = 10 - 2 = 8
            arr[5] - arr[2] = 20 - 3 = 17
            arr[6] - arr[3] = 30 - 4 = 26
            arr[7] - arr[4] = 40 - 10 = 30 
            arr[8] - arr[5] = 100 - 20 = 80 
            
            
            */ 
            
            //실제로 진행해보면 int의 맥스값으로 비교를 하지 않고 진행하면 오류가남
            if (x < result){
                result = x;
            }
        }
        
        
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int k = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int [n];

        for (int i = 0; i < n; i++) {
            int arrItem = Convert.ToInt32(Console.ReadLine());
            arr[i] = arrItem;
        }

        int result = maxMin(k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
