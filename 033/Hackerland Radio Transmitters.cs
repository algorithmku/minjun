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

    // Complete the hackerlandRadioTransmitters function below.

    /*
    x는 배열
    k는 수신기의 범위

    만약 x가 1,2,3 
    k 가 1 이면 
    2에 꼽으면 

    범위는 1칸씩이기 때문에 

    2-1 = 1 
    2+1 = 3 

    으로 2에 한개만 꼽으면 모든 범위가 가능해짐

    x는 숫자 순서가 랜덤인데 
    예제의 다이어그램처럼 순서정렬이 먼저 필요하다.

    만약 2,1,3 으로 들어올수도 있다.
    그럼 정렬을 하여 1,2,3 으로 만들어서 2에 중심을 맞추면 
    1,3 이 범위내(k)에 들어오기때문에 값을 구할수 있다.

    중간중간 빈 숫자가 있는데 그 숫자는 수신하지 않겠다는 집의 위치이다.
    1,3,4,5 라고 입력 받았으면 2는 수신안해도 된다는것
    그럼 1에 수신기 1개 
    4에 수신기 한개 (+1 = 3 , -1 = 5 )
    즉 2개로 끝



     */
    static int hackerlandRadioTransmitters(int[] x, int k) {

        List<int> xList = x.ToList();
        int result = 0;
        int check=0;
        xList = xList.Distinct().ToList();
        xList = xList.OrderBy(item => item).ToList();
        for (int i = 0; xList.Count() > 0;)
        {
            check = xList[i];
            check = xList.FindLast(item => item <= check + k);
            xList.RemoveAll(item => item <= check + k);
            ++result;
        }
        return result;

        /*
        
        int result = 0;
        x = x.Distinct().ToArray();
        Array.Sort(x);

        Console.WriteLine("최초 정렬한 배열의 값 " + string.Join(",", x));

        int loop = x.Max();
        int start = x.Min();
        Console.WriteLine("시작값"+start);
        Console.WriteLine("루프값"+loop);

        if (x.Length <= k){
            result++;
        }else{

            for (int i=start; i <= loop; i++){
                int check = i + k;
                Console.WriteLine("1# 확인 할 값 " + check);
                if (x.Contains(check)){
                    i = check;
                    check += k;
                    Console.WriteLine("1# 확인 완료 값 " + i);

                    Console.WriteLine("2# 확인 할 값 " + check);

                    if (x.Contains(check)){
                        i = check;
                        Console.WriteLine("2# 확인 완료 값" + i);
                    }
                }
                result++;
                Console.WriteLine("3# 결과값 증가" + result);
            }


        }
        return result;

        */
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] x = Array.ConvertAll(Console.ReadLine().Split(' '), xTemp => Convert.ToInt32(xTemp))
        ;
        int result = hackerlandRadioTransmitters(x, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

 
 	