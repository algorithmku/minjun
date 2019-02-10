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

    // Complete the angryProfessor function below.
    static string angryProfessor(int k, int[] a) {
/*
2

4 3
-1 -3 4 2

4 2
0 -1 2 1

2개 케이스 
4개 배열
3개가 0 이하 
2개가 0 이하 

*/
        int studentCnt = 0;

        for(int i = 0 ; i < a.Length ; i++){
            if(a[i] <= 0){
                studentCnt = studentCnt +1;
            }
        }

        if(studentCnt >= k){
            return "NO";
        }else{
            return "YES";
        }
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            string result = angryProfessor(k, a);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}