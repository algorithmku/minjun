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

    // Complete the taumBday function below.
    /*
    
    딕샤의 생일 선물을 구매할껀데 ,딕샤는 탐에게 검정색과 흰색 선물을 달라고함.
    
    검은색 선물의 가격 단위는 bc(개당)
    흰색 선물 가격 단위는 wc(개당)
    변환하는데 쓰이는 비용 단위는 z (흰색<->검은색)
    여기서 변환이란 흰색은 검은색으로 변환할수 있고,
    검은색은 흰색으로 변환할수 있는데, 그에따른 금액은 z원이 들어간다.

    딕샤한테 선물사는데 필요한 최소한의 양을 구해야함
    
    첫번째 줄 테스트
    
    각 테스트 케이스마다 2줄씩 있음.
    첫번째 줄 정수 b, w 값 
    두번째 줄 bc, wc, z 값 

5

case 1

b10 w10
bc1 wc1 z1

개당 1원 , 1원 이니깐 

b * bc + w * wc = 답
10 * 1 + 10 * 1 = 20 

심플하게 계산 
----------------------------------------------
case 2

b5 w9
bc2 wc3 z4

개당 2원 개당 3원
동일하게 심플하게 계산 가능  

b * bc + w * wc = 답
5 * 2 + 9 * 3 = 10 + 27 = 37
----------------------------------------------
case 3

b3 w6
bc9 wc1 z1

개당 9원인데 3개를 갖고 싶다..
개당 1원인데 6개가 갖고 싶다..
변환 금액이 더 싸다. 그러면 흰색을 사서 변환하는게 더 싸다.

bc9 > wc1+z1 
9 > 2 

흰색선물 단가랑 변환금액을 더한 값이 bc 보다 크다면 
그냥 w가격대로 1원으로 원하는 수량을 구매한다면 

b + w = 3 + 6
총 9개 수량을 구매해야하고,

그중에 3개에 대해선 1원씩 3원이 들어가 변환한다.
색구분없이 9개 1원으로 사고
3개를 b 로 돌려야 하니깐 3*1
그럼 12가 나옴

(9 * 1) + 3 * 1  = 12 

----------------------------------------------
case 4

b7 w7
bc4 wc2 z1

검은선물이 4원이고
흰색선물이 2원이다.
변환비용이 1원이다.

wc + z = 2+1 = 3 

7*3 + 7 * 2 = 35


----------------------------------------------
case 5

b3 w3
bc1 wc9 z2

b의 개당 가격은 1원 
w의 개당 가격은 9원 
변환금액 2원 

w의 개당금액은 b의 개당금액 + 2 보다 크다 
b를 개당으로 구매해서 +2씩 하여 흰색으로 바꾸는게 더 싸다.
  
    */
    //long 로 바꿈 해커랭크 돌려보면 int 크기 벗어남
    static long taumBday(int b, int w, int bc, int wc, int z) {
        
        long white_cost, black_cost, result;
        // 검은색 선물 가격이 흰색선물 + 변환비용 보다 작다면 
        if(bc < wc + z){
            // 검은색 선물 가격 그대로 진행 
            black_cost = bc;
        }else{
            //만약 다르면 흰색 선물 + 교환비용으로 검은색 선물 가격 대체 
            black_cost = wc + z;
        }

        // 흰색 선물 가격이 검은색 선물 + 변환비용 보다 작다면 
        if(wc < bc + z){
            white_cost = wc;
        }else{
            white_cost = bc + z;
        }
        
        // 공통적인 공식 bc * b + wc * w 

        result = black_cost * b + white_cost * w;

        return result;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string[] bw = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bw[0]);

            int w = Convert.ToInt32(bw[1]);

            string[] bcWcz = Console.ReadLine().Split(' ');

            int bc = Convert.ToInt32(bcWcz[0]);

            int wc = Convert.ToInt32(bcWcz[1]);

            int z = Convert.ToInt32(bcWcz[2]);

            //int result = taumBday(b, w, bc, wc, z);
            long result = taumBday(b, w, bc, wc, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}