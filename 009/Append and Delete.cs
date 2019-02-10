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

    // Complete the appendAndDelete function below.
    static string appendAndDelete(string s, string t, int k) {

          /*
        
            s = 기존
            t = 변경
            k = 변경 행위 카운트

            */
            string result = "No";

            int sameIndex = 0;

            // 같은 글씨 체크 
            for (int j = 1; j < t.Length; j++)
            {
                if (sameIndex > 0 || j == 1)
                {
                    if (s.Length > j)
                    {
                        if (s.IndexOf(t.Substring(0, j)) == 0)
                        {
                            sameIndex = j;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
            // 체크한 글씨 를 뺸 나머지 Length 를 구함 
            string s_slice = s.Substring(sameIndex, s.Length - (sameIndex));
            string t_slice = t.Substring(sameIndex, t.Length - (sameIndex));
            int word_len = s_slice.Length + t_slice.Length;

            // 같은 글씨를 제외한 나머지 글씨들의 길이값은 k보다 작아야함.
            if (sameIndex > 0)
            {
                if (word_len <= k)
                {
                    if ((word_len % 2 == k % 2) || (s_slice.Length == 0))
                    {
                        result = "Yes";
                    }

                }
            }
            else
            {
                if (word_len <= k)
                {
                    result = "Yes";
                }
            }
           
        if(s==t && k > t.Length){
            result="Yes";
        }

            return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}