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
    최초 에너지는 100
    
    그냥구름과 먹구름이 있음
    
    그냥 구름 = 0 
    먹구름 = 1 
    
    //////////그냥 구름에서는 -1이 됨 
    //////////먹구름에서는 -2가 되고 
    
    그냥 일단 한번 액션을 하면 -1이 됨
    근데 도착한게 먹구름이면 -2가 더 해짐 

    
    1행 - 구름의 숫자를 먼저 주고 점프할 숫자를 그다음에 줌 
    2행 - 구름에 대한 배열값을 줌 
    
    시작점에 도달했을때 남은 에너지의 값은?
    
    
    */
    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c, int k) {

        //현재 위치 0으로 지정 
        int now = 0;
        //에너지 기본 100 
        int e = 100;

        do{
            //k 만큼 이동 
            now += k;
            // 현재 위치가 구름의 갯수보다 크면 
            if (now > c.Length - 1){
                // 시작점으로 초기화
                now = 0;
            }else{
                // e를 -1씩 줄임 
                e--;
                // 만약 현재 구름이 먹구름이면 -2를 함 
                if (c[now] == 1){
                    e = e - 2;
                }
            }
            
            //시작점에 다시 도착 할때까지~
        } while (now != 0);

        return e;
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}