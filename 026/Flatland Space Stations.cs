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

    // Complete the flatlandSpaceStations function below.
    static int flatlandSpaceStations(int n, int[] c) {

        //첫번째 도시는 마지막 도시랑 연결이 되지 않음(순환X)
        //각각 1km의 길이로 연결되어 있음.
        //어느 도시에 있던 가장 가까운 정류장까지의 최대거리를 리턴

//케이스4
//20 5
//13 1 11 10 6

        Array.Sort(c); // 정렬

        int maxVal = c[0]; // 초기 최대 거리는 처음에 첫 번째 값이랑 동일.
        int defaultMaxVal = 0; // 기본 최대값 
        // 0을 최초 최대값으로 설정을 하여 1부터 시작 
        for(int i = 1; i < c.Length; i++)
        {   //두개의 거리의 차를 구하기 위해 나누기 2를 함 
            int disVal = (c[i] - c[i - 1]) / 2;
            // 만약 disVal 이 maxVal 보다 크면 변경함 
            if(disVal > maxVal){
                maxVal = disVal;       
            }
        }
        
        // 정류장을 뺸 나머지 도시를 모두 합치면 가장 기본 최대값이 나옴.

        defaultMaxVal = n - 1 - c[c.Length - 1];
        
        //return defaultMaxVal;
        //return maxVal;

        return defaultMaxVal > maxVal ? defaultMaxVal : maxVal;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = flatlandSpaceStations(n, c);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
