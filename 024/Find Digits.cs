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

    // Complete the findDigits function below.
    static int findDigits(int n) {
        // 결과값
        int cnt = 0;
        // 자를 값
        int sliceNum = n;
        // 잘라서 넣을 LIST
        List<int> slice = new List<int>();
        // 10단위로 나눠서 잘라 넣기 
        while (sliceNum > 0)
        {
            slice.Add(sliceNum % 10);
            sliceNum = sliceNum / 10;
        }
        
        for (int i = 0; i < slice.Count; i++)
        {
            if (slice[i] == 0)
            {
                continue;
            }
            else
            {
                if (n % slice[i] == 0)
                {
                    cnt++;
                }
            }
        }

        return cnt;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = findDigits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}