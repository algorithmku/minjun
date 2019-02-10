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

    // Complete the utopianTree function below.
    static int utopianTree(int n) {
/*

    유토피아 나무는 매년 2싸이클 성장함.
    봄엔 두배로 크고 여름엔 1미터가 큼 (가을,겨울은 없는듯)
    
    계절이 1싸이클 
    
    봄 1
    여름 1 
    
    각각 1싸이클로 인식 
        
    시작할때 1미터짜리 심어서 0 싸이클은 리턴 값 1 

    첫 입력값은 케이스
    다음 입력값은 싸이클 숫자 
    
    홀수일떈 *2 
    짝수일땐 +1 

*/
        int i = 0;
        int result = 0;
        
        if (n == 0){
            
            result = 1;
            
        }else{
            
            while(i <= n){ 
                if (i%2 == 0){
                    result = result + 1;
                }else{
                    result = result * 2;
                }
                
                i++;
            }

        }
        
        return result;
    
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = utopianTree(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}