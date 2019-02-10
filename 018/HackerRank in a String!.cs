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



    // Complete the hackerrankInString function below.
    static string hackerrankInString(string s) {

        /*

        주어진 단어에 hackerrank 가 존재하면 YES 아니면 NO 

        */
        
        string hackerrank = "hackerrank";   
        
        // 길이가 적으면 일단 NO
        if (s.Length < hackerrank.Length){
            return "NO";
        }
        
        int i = 0;

        // 주어진 string 을 item 에 넣으며 확인함 
        foreach(var item in s){
            if (item == hackerrank[i])
            {
                i++;
            }
            // 마지막 길이를 확인함.
            if (i == hackerrank.Length) 
            {
                break;
            }
        }
        // 길이가 같으면 YES 
        if (i == hackerrank.Length)
        {
            return "YES";
        }else{
            return "NO";
        }
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string s = Console.ReadLine();

            string result = hackerrankInString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}