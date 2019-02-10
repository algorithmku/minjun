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

    // Complete the matchingStrings function below.
    static int[] matchingStrings(string[] strings, string[] queries) {
        //쿼리의 수만큼 배열 int 선언함.
        int[] arr = new int[queries.Length];
        int checkVal=0;
        //쿼리의 수만큼 돌림.
        for(int i = 0; i < queries.Length; i++){
            //strings 배열에 queries[i]의 값과 동일한게 있는지 체크하고 카운트함.
            foreach (string x in strings)
            {
                if (queries[i].Contains(x))
                {
                    checkVal++;
                }
            }
            arr[i] = checkVal;
            //초기화 떄리
            checkVal = 0;
        }
        return arr;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringsCount = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string [stringsCount];

        for (int i = 0; i < stringsCount; i++) {
            string stringsItem = Console.ReadLine();
            strings[i] = stringsItem;
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine());

        string[] queries = new string [queriesCount];

        for (int i = 0; i < queriesCount; i++) {
            string queriesItem = Console.ReadLine();
            queries[i] = queriesItem;
        }

        int[] res = matchingStrings(strings, queries);

        textWriter.WriteLine(string.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}