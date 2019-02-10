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

    // Complete the pangrams function below.
    static string pangrams(string s) {
        int cnt = 0;
        //전부 소문자로 변경, 띄어쓰기 제거
        char s2 = s.ToLower().Replace(" ","");
        while (s2.Length > 0)
        {
            s2 = s2.Replace(s2.Substring(0,1),"");
            cnt++;
        }
        return cnt < 26 ? "not pangram" : "pangram";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

