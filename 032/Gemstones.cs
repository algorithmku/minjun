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

    // Complete the gemstones function below.
    static int gemstones(string[] arr) {

        int result = 0;
        // 0번 값을 잘라서 list 에 넣음 
        List<string> slice = new List<string>();
        foreach (var item in arr[0])
        {
            slice.Add(item.ToString());
        }
        //중복을 제거함.
        List<string> loopset = slice.Distinct().ToList<string>();
        //list 에 있는 값들에 대해 반복문을 돌림
        foreach (var check in loopset)
        {
            //arr 의 0번을 제외한 1번부터 ~ 돌림
            for(int i=1; i < arr.Length; i++){
                //indexOf 로 각 알파벳 존재 여부 확인함.
                if (arr[i].ToString().IndexOf(check.ToString()) > -1)
                {
                  //만약 모든 배열에 있다면 0번배열을 뺀 배열의 카운트값과 i의 값이 동일할것임
                    //이떄 result를 ++ 해줌 
                    if (arr.Length -1 == i){
                        result++;
                    }
                    //같은 글씨에 대해 체크할것을 방지하여 컨티뉴로 넘겨줌 
                    continue;
                }else{
                    //없으면 걍 멈추고 다음 바퀴 돌기 
                    break;
                }
            }
        }

        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string[] arr = new string [n];

        for (int i = 0; i < n; i++) {
            string arrItem = Console.ReadLine();
            arr[i] = arrItem;
        }

        int result = gemstones(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}