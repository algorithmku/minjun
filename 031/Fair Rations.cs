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

    // Complete the fairRations function below.
    // NO 를 리턴하는 경우가 있는데 int 로 선언되어 있음.
    // string 으로 변경함 
//    static int fairRations(int[] B) {
    static string fairRations(int[] B) {
        // 빵을 분배하는데 짝수로 줘야함
        // 만약 홀수가 있으면 짝수로 변경하기위해 빵을 1개 줘야하는데 근접한 1명에게도 빵을 줘야함
        // 즉, 앞사람이나 뒷사람에게도 1개 빵을 주는것.
        // 총 몇개의 빵을 주었는지 그게 짝수인지 

        var cnt = 0;
        // 배열의 합이 홀수이면 빵을 2개씩 나눠줘도 계속 홀수라서 NO가 리턴
        int sum = B.Sum();
        string returnVal="";

        if (sum % 2 !=0){
            returnVal = "NO";
        }
        // 만약 합이 홀수가 아니라면 
        else{
            // 반복 돌림
            for (var i = 0; i < B.Length - 1; i++)
            {
                //만약 홀수라면 
                if (B[i] % 2 == 1)
                {
                    // 현재것과 뒤의 것을 1 더한다.
                    B[i]++;
                    B[i + 1]++;
                    // 2개를 1씩 더했으니 카운트를 +2 한다.
                    cnt += 2;
                }
            }
            returnVal = cnt.ToString();

        }

        return returnVal;

        

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int N = Convert.ToInt32(Console.ReadLine());

        int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp))
        ;
    // NO 를 리턴하는 경우가 있는데 int 로 선언되어 있음.
    // string 으로 변경함 
        //int result = fairRations(B);
        string result = fairRations(B);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
