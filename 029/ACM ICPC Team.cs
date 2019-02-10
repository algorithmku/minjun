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

// 첫번째 입력 4명의 참가자
// 첫번째 입력 5문제 
// 두번째 입력 부터는 각 참가자가 알고 있는 주제의 숫자 
// 11111 이면 5개의 문제의 주제를 알고 있는것
// 10111 이면 4개의 문제의 주레를 알고 있는것

// 10101 의 주제를 알고있는 사람과 01010 을 알고 있는 사람이 만나면
//  10101 
// +01010
// -------------
//  11111 -> 5개 

// 개념상으론 O , X 랑 똑같음...
// OXOXO
// XOXOX
// OOOOO

// OR 연산으로 진행.
 


class Solution {
    #region 실패작....
    // 아래 방법으로 처음에 풀었으나 overflow 나와서 문자열을 비교하는것으로 다시 변경함.
    // Complete the acmTeam function below.
    /*
    static int[] acmTeam(string[] topic) {
        // 결과 값 선언
        int[] result = new int[2];
        // 결과를 담을 List 
        List<long> number = new List<int>(); 
        // 2중 포문 돌리기
        int max = 0;
        //int cnt = 0;

        for (int i = 0; i < topic.Length ; i++){
            for(int j = i+1; j < topic.Length; j++){
                
                int a_t = Convert.ToInt32(topic[i], 2);
                int b_t = Convert.ToInt32(topic[j], 2);
                // or 로 연산함 
                int or_result = (a_t | b_t);
                //Console.WriteLine(a_t);
                // 나온 결과값을  push 함 
                //Console.WriteLine("a_t : " + a_t + "// b_t = : "+ b_t);
                // 리스트에 박아버리기
                number.Add((int)or_result);
                
                //2진수로 or 연산이 잘 나오나 확인.
                //string str2 = Convert.ToString(or_result, 2);
                //Console.WriteLine(str2);


            }
        }
        //string str2 = Convert.ToString(number.Max(), 2);
        //Console.WriteLine(str2);
        int cnt = (int)Convert.ToString(number.Max(), 2).Count(f => f == '1');
        int cnt2 = (int)number.Count(k => k == number.Max());
        //Console.WriteLine(cnt);

        result[0] = cnt;
        result[1] = cnt2;
        return result;


    }
 */
    #endregion

   // Complete the acmTeam function below.
    static int[] acmTeam(string[] topic) {
        int[] result = new int[2];
        int max = 0;
        int cnt = 0;

        for (int i = 0; i < topic.Length ; i++){
            for(int j = i+1; j < topic.Length; j++){
                int val = 0;
                for (int k = 0; k < topic[i].Length; k++) {
                    if (topic[i][k] == '1' || topic[j][k] == '1') {
                        val++;
                    }
                }
                if (max < val) {
                    max = val;
                    cnt = 1;
                } else if (max == val) {
                    cnt++;
                }
            }
        }
        result[0] = max;
        result[1] = cnt;
        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        string[] topic = new string [n];

        for (int i = 0; i < n; i++) {
            string topicItem = Console.ReadLine();
            topic[i] = topicItem;
        }

        int[] result = acmTeam(topic);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}