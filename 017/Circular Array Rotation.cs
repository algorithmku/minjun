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
      /*
      
        존 왓슨은 셜록을 실험하기 위해 문제를 냄.

        초기 배열 값 a = 3 
        회전 수 k = 2 
        queries 의 개수 = 3

        queries 의 값 = 1 2 3
        queries 의 배열1 = 0
        queries 의 배열2 = 1
        queries 의 배열3 = 2
        
        a 배열의 값을 1개씩 뒤로 순서를 바꿈 
        
        K만큼 회전 -> queries 에 담긴 값에 맞는 배열값을 결과값으로 리턴
                
        1바퀴 1 2 3
        2바퀴 2 3 1

        queries의 값은 0번째, 1번쨰, 2번째 를 뽑아라..
        
        결과 
        
        2
        3
        1
        
        만약 0번째,2번째 라면 
        
        2
        1
        

        */
    // Complete the circularArrayRotation function below.
    static int[] circularArrayRotation(int[] a, int k, int[] queries) {
  
        // 결과 값 배열 선언 
        int[] returnVal = new int [queries.Length];

        // 1. 그냥 k 만큼 right shift 시켜보자
        
        int[] Arr_Shift_Right = new int [a.Length];
        for (int j = 0; j < a.Length; j++) {
            Arr_Shift_Right[(j+k) % Arr_Shift_Right.Length] = a[j];
        } 
        for (int z = 0; z < queries.Length; z++) {
            returnVal[z] = Arr_Shift_Right[queries[z]]; 
        } 
        
        // 2. LINQ 를 써보자..
        
        /*
        int[] Arr_Shift_Right = new int [a.Length];
        Arr_Shift_Right = a.Skip(a.Length - k).Concat(a.Take(a.Length - 1)).ToArray();
        
        for (int z = 0; z < queries.Length; z++) {
            returnVal[z] = Arr_Shift_Right[queries[z]]; 
        } 
        */
        
       // return Arr_Shift_Right;
        return returnVal;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nkq = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nkq[0]);

        int k = Convert.ToInt32(nkq[1]);

        int q = Convert.ToInt32(nkq[2]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] queries = new int [q];

        for (int i = 0; i < q; i++) {
            int queriesItem = Convert.ToInt32(Console.ReadLine());
            queries[i] = queriesItem;
        }

        int[] result = circularArrayRotation(a, k, queries);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}