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

   static string[] weightedUniformStrings(string s, int[] queries) {
    //static int[] weightedUniformStrings(string s, int[] queries) {
        // 결과 배열 선언
        string[] result = new string[queries.Length];
        // 입력된 값으로 만들수 있는 경우의 수를 동원하여 숫자를 넣기 
        int[] test = new int[s.Length];
        for(int i = 0 ; i < s.Length ; i++){
            // 일단 값 그대로 알파벳의 숫자로 넣기
            test[i] = s[i] - 96;
            // 두번째것 부터 
            if (i > 0){
                // 만약 이전값과 같다면 
                if(s[i] == s[i-1]){
                    test[i] = test[i-1] + s[i] - 96;
                }
            }
        }
       
      // byte[] bytes = test.Select(x => (byte)x).ToArray();
      // byte[] bytes2 = queries.Select(y => (byte)y).ToArray();
       


        // queries 의 값이 있는지 
        for (int j = 0; j < queries.Length ; j++){
            //존재 하지 않다면 
            //if (test.Contains(queries[j])){
            /*
            
            if (Array.IndexOf(test, queries[j]) > -1){
                result[j] = "Yes";
            }else{
                result[j] = "No";
            }
            
            */
            /*
            if (Array.IndexOf(bytes, bytes2[j]) > -1){
                result[j] = "Yes";
            }else{
                result[j] = "No";
            }
       */
            
            // 타임아웃..
            // 초기값 No
            
            int k = 0;
            while(k < test.Length){
                    result[j] = "No";
                if (test[k] != queries[j]){
                    result[j] = "No";
                    k++;
                }else{
                    result[j] = "Yes";
                    break;
                }
            }
            
            
        }
        return result;
        //return test;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int queriesCount = Convert.ToInt32(Console.ReadLine());

        int[] queries = new int [queriesCount];

        for (int i = 0; i < queriesCount; i++) {
            int queriesItem = Convert.ToInt32(Console.ReadLine());
            queries[i] = queriesItem;
        }

        //int[] result = weightedUniformStrings(s, queries);
        string[] result = weightedUniformStrings(s, queries);

        
        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
