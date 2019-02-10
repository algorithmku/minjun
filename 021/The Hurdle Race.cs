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
/*

댄이 장애물 경주 게임을 함.
장애물 높이는 각각 다르며, 댄은 최대 점프 높이가 정해져있음.
근데 약빨고 뛰면 키가 1씩 증가하는데. 얼마나 약을 빨아야 하는지 알아내야함.

높이배열이 있고 댄이 최대 뛸수있는 높이가 k임

1,2,3,2 라는 장애물들이 있으면, 댄이 1을 뛸수 있으면

최대 크기인 장애물 3 빼기 기본 댄이 뛸수있는 높이 1을 뺴면 2개의 약을 빨아야함.

 */
    // Complete the hurdleRace function below.
    static int hurdleRace(int k, int[] height) {
        //정렬 
        Array.Sort(height);
        //정렬한거 뒤집기
        Array.Reverse(height);
        //그럼0이 젤큰놈
        if (k > height[0]){
            return 0;
        }else{
            return height[0] - k;
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
        ;
        int result = hurdleRace(k, height);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}