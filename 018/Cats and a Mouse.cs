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

    냥이 2마리
    쥐새끼 1마리 

    일렬로 서있고 출발위치는 각각 지정됨
    쥐새끼는 못움직이고 냥이 2마리는 같은속도로 움직임
    그때 어떤 냥이가 먼저 도착하는지 ???
    단, 냥이 2마리가 동시에 도착하면 지들끼리 싸우고 쥐새끼는 그때 도망감 


    결과 값은 아래 값으로만 뿌림 

    A냥이가 먼저 도착하면
    Cat A 
    B냥이가 먼저 도착하면
    Cat B 
    A,B 동시에 도착하면
    Mouse C

    인풋
    1줄 - 케이스
    2줄 - A(x), B(y), C(z) 순 
    2
    1 2 3
    1 3 2

    123 결과 Cat B -> 3이 2랑 제일 가까움
    132 결과 Mouse C -> 2랑 1,3은 1개씩 차이남 냥이들 동시 도착 


 */
    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z) {
        if (Math.Abs(x - z) > Math.Abs(y - z)){
            return "Cat B";
        }else if (Math.Abs(x - z) < Math.Abs(y - z)){
            return "Cat A";
        }else{
            return "Mouse C";
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}