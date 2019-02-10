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

    // Complete the saveThePrisoner function below.
    /*

    감옥에 죄수들이 있음.
    간수는 죄수들에게 사탕을 나눠줌.
    근데 맛없는 사탕이 섞여있음. 장난질침
     
    죄수들을 숫자에 맞춰 앉혀두고 순서대로 사탕을 주는데
    맛없는 사탕걸리는 죄수의 숫자를 찾는거임



    1번줄은 케이스
    
    첫번재는 n 
    두번째는 m 
    세번째는 s 
    
    n 은 죄수(인원) 
    m 은 사탕의 갯수 
    s 는 사탕을 나눠주기 시작하는 번호 


    예시에서 나오기를 
    n 은 4 -> 4명의 죄수
    m 은 6 -> 6개의 사탕
    s 는 2 -> 2번부터 시작함 

    2, 3, 4, 1, 2, 3 
    
    맛없는 사탕은 3번 죄수가 걸림 (마지막에 걸리는놈)

    샘플 

    2
    5 2 1 
    5 2 2 

    5명 죄수
    2개 사탕
    1번부터 시작 
    1 , 2 

    -> 2 (마지막에 걸리는놈)


    5명의 죄수
    2개의 사탕
    2번부터 시작 

    2, 3 

    -> 3 (마지막에 걸리는놈)


     */


    static int saveThePrisoner(int n, int m, int s) {

        /*
        
        n 은 죄수(인원)
        m 은 사탕의 갯수 
        s 는 사탕을 나눠주기 시작하는 번호  

        */
        
        // 사탕의 갯수 + 사탕을 주기 시작하는번호 -1 나누기 죄수의 숫자의 나머지
        // -1을 하는이유는 index 가 1부터 시작하기 때문에 

        // 5 2 2 
        // 2 + 2 = 4 
        // 4 - 1 = 3 
        // 3 % 5 = 0 

        // 4 6 2 
        // 6 + 2 = 8 
        // 8 - 1 = 7
        // 7 % 4 = 3 

        int result = (m + s - 1) % n;
        // 0번의 자리는 없기 때문에 마지막점임 (index 가 1부터 시작하기 때문에)
        if (result == 0)
        {
            return n;
        }
        else{
            return result;
        }



    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] nms = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nms[0]);

            int m = Convert.ToInt32(nms[1]);

            int s = Convert.ToInt32(nms[2]);

            int result = saveThePrisoner(n, m, s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}