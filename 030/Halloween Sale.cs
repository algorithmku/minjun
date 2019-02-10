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

    // Complete the howManyGames function below.
    static int howManyGames(int p, int d, int m, int s) {
        // Return the number of games you can buy
        // 할로윈에 세일판매를 한다.
        // 시작은 p달러로 시작 두개를 사면 p에서 d를 뺸 급액으로 
        // 또 하나 더 사면 p에서 d를 뺀금액으로 쭈욱 할인을 해서 판매한다.
        // 최소 m달러 까지만 할인하고 그다음부터는 계속 m, m, m 달러의 가격으로 판매함
        // s달러를 가지고 몇개를 살수 있는가 ?
        
        //카운트
        int cnt = 0;
        //반복 돌리기
        while (s >= p)
        {
            cnt++;
            s -= p;
            p = Math.Max(p - d, m);
        }
        return cnt;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] pdms = Console.ReadLine().Split(' ');

        int p = Convert.ToInt32(pdms[0]);

        int d = Convert.ToInt32(pdms[1]);

        int m = Convert.ToInt32(pdms[2]);

        int s = Convert.ToInt32(pdms[3]);

        int answer = howManyGames(p, d, m, s);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}