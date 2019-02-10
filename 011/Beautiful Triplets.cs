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

    // Complete the beautifulTriplets function below.
    static int beautifulTriplets(int d, int[] arr) {
/*
7 3
1 2 4 5 7 8 10

배열의 값들을 각각 빼기(혹은 더하기)를 했을때 3이 되는숫자들을 정렬하여 순서대로 +3 씩 나옴

*/
        int result = 0;

        for(int i = 0 ; i < arr.Length ; i++){
            int nextVal = arr[i];
            int arrayCnt = 0;
            for(int j = 0 ; j < arr.Length ; j++){
                if(nextVal + d == arr[j]){
                    nextVal = arr[j];
                    arrayCnt++;
                }
                if(arrayCnt == 2){
                    result++;
                    break;
                }
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = beautifulTriplets(d, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}