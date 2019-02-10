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

    // Complete the workbook function below.
    static int workbook(int n, int k, int[] arr) {
        
        
/*
n = 챕터
k = 페이지당 맥스 문제
arr = 챕터별 문제수 
*/
        int page_index = 1;
        int spc_pro = 0;

        for (int i = 0; i < n; i++)
        {
            int chapter_page_cnt = k;
            for (int j = 1; j <= arr[i]; j++)
            {
                if (j == page_index)
                {
                    spc_pro++;
                }
                if (j < arr[i] && j == chapter_page_cnt)
                {
                    page_index++;
                    chapter_page_cnt += k;
                }
            }
            page_index++;
        }
        return spc_pro;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = workbook(n, k, arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
