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
//BigInteger 사용을 위해 추가 
using System.Numerics; 

class Solution {

    // Complete the extraLongFactorials function below.
    static void extraLongFactorials(int n) {
        //초기 선언 = 1값 
        BigInteger number = BigInteger.Multiply(1, 1);
        
        for(int i = n ; i > 0 ; i--)
        {
            //--1 돌면서 곱함 
            number = BigInteger.Multiply(number, i);
        }
        
        
        Console.WriteLine(number);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        extraLongFactorials(n);
    }
}