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

    // Complete the minimumNumber function below.
    static int minimumNumber(int n, string password) {
        // Return the minimum number of characters to make the password strong
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";

        int result = 0;

        bool numbers_X = true;
        bool lower_case_X = true;
        bool upper_case_X = true;
        bool special_characters_X = true;

        //한글자씩 비교 
        for(int i = 0; i < n ; i++){
            if (numbers.IndexOf(password.Substring(i,1)) != -1){
                numbers_X = false;
            }
            if (lower_case.IndexOf(password.Substring(i,1)) != -1){
                lower_case_X = false;
            }
            if (upper_case.IndexOf(password.Substring(i,1)) != -1){
                upper_case_X = false;
            }
            if (special_characters.IndexOf(password.Substring(i,1)) != -1){
                special_characters_X = false;
            }
        }
        //최대 4개가 더해짐 
        if (numbers_X){
            result++;
        }
        if (lower_case_X){
            result++;
        }
        if (upper_case_X){
            result++;
        }
        if (special_characters_X){
            result++;
        }
        // 마지막으로 리턴시 부족한 길이를 파악하고, 
        // 부족한 길이가 큰지 result 값이 큰지 비교하여 리턴함
        return Math.Max(6 - n, result);

            
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string password = Console.ReadLine();

        int answer = minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}