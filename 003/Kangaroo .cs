/*
Kangaroo
https://www.hackerrank.com/challenges/kangaroo/problem
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string kangaroo(int x1, int v1, int x2, int v2) {
        // Complete this function
        //1번 캥거루가 2번캥거루보다 더 앞서있으면 NO
        if (x1 > x2){
            return "NO";
        }else{
            
            int k1 = x1;
            int k2 = x2;
            //만번 뛰어서 만나는 지점이 있는지 확인 
            for(int i = 0; i < 10000; i++)
            {
                k1 += v1;
                k2 += v2;
                if(k1 == k2)
                {
                    return "YES";
                }
            }
            return "NO";
        }
        
    }

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        string result = kangaroo(x1, v1, x2, v2);
        Console.WriteLine(result);
    }
}