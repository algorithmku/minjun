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
    //배열에 있는 값중에 같은값들을 남겨두고 삭제하는 갯수 리턴
    //가장 많은 중복값만 남기고 삭제할 갯수 (최소삭제값)구하기

    // Complete the equalizeArray function below.
    static int equalizeArray(int[] arr) {
        //중복 제거하고 몇개의 숫자가 들어있는지 확인함.
        //int num = arr.Distinct().Count();
        //리스트를 선언함 
        List<int> number = new List<int>(); 
        //중복 제거 하고 foreach 를 돌림 
        foreach (int i in arr.Distinct().ToArray())
        {
            //리스트에 각 숫자별 카운트를 더함.
            number.Add(arr.Count(n => n == i));
        }
        //전체 길이에서 빼기를 하면 삭제할 카운트 나옴.
        return arr.Length - number.Max();
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = equalizeArray(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}