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

    // Complete the stones function below.
    //배열을 사용하지 않을것이기 때문에 string 로 변경함
    //static int[] stones(int n, int a, int b) {
    static string stones(int n, int a, int b) {
        
        int stone_A = a;
        int stone_B = b;
        var stone_List = new List<int>();
        // n = n - 1 
        // n - 1 = 3 
        for (int i = 0; i <= n - 1; i++) //초기 스톤은 무조건 0이기 때문에 -1 해줌
        {
            // ((4-1) - 0) * 10 = 30
            // 0 * 100 = 0
            // -> 30
            
            // ((4-1) - 1) * 10 = 20
            // 1 * 100 = 100 
            // -> 120 
            
            // ((4-1) - 2) * 10 = 10
            // 2 * 100 = 200
            // -> 210
            
            // ((4-1) - 3) * 10 = 0
            // 3 * 100 = 300 
            // -> 300
            
            
            var a_Max = ((n - 1) - i) * stone_A;
            var b_Max = i * stone_B;
            stone_List.Add(a_Max + b_Max);
        }
        
        //배열을 사용하지 않을것이기 때문에 string 로 변경함
        return string.Join(" ", stone_List.Distinct().OrderBy(x => x).ToList());
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine());

        for (int TItr = 0; TItr < T; TItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            //int[] result = stones(n, a, b);
            //배열을 사용하지 않을것이기 때문에 string 로 변경함
            string result = stones(n, a, b);

            textWriter.WriteLine(string.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
