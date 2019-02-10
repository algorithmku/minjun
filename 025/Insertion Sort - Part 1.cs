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

    // Complete the insertionSort1 function below.
    // 한칸씩 전과 후값을 비교하여 삽입정렬을 시행함.
    /*

1 2 4 5 3 -> 이게 시작인데 3이 작다...

1 2 4 5 5 -> 5가 뒤로감
1 2 4 4 5 -> 4가 5자리로감
-> 비교해보니 3이 2보다 큼 
1 2 3 4 5 -> 3이 4자리에 들어감


     */
    static void insertionSort1(int n, int[] arr) {
        // 전 후 값을 비교 함
        // 삽입 정렬 
        for (int i = 0; i < arr.Count() - 1; i++){
            // 현재
            int now = arr[i];
            // 다음
            int next = arr[i + 1];
            //지금 값이 다음값보다 크면
            if (next < now){
                //다음값을 insert 한다.
                int insertNum = next;
                //다음값의 위치저장 
                int nextIndex = i + 1;
                // 멈출지 체크
                bool breakcheck = false;
                // 다음 값의 인덱스 부터 0까지 줄여간다.
                for (int j = nextIndex; j > 0; j--){
                    // 만약에 이전값이 추가할값보다 크면
                    if (insertNum < arr[j - 1]){
                        //이전 값을 넣고
                        arr[j] = arr[j - 1];
                    }
                    else
                    {
                        //아니면 다음값을 넣고 멈춘다.
                        arr[j] = insertNum;
                        breakcheck = true;
                    }
                    //arr 을 출력한다.
                    foreach (var t in arr)
                    {
                        Console.Write(t.ToString() + " ");
                    }
                    //줄바꿈을 위하여
                    Console.WriteLine();
                    //멈춰야하는지 확인 하고 멈춘다.
                    if (breakcheck) {
                        break;
                    }
                }
                //멈추지 말아야 한다면
                if (!breakcheck){
                    // 추가하려고한값을 처음값에 넣고
                    arr[0] = insertNum;
                    // arr 을 출력한다.
                    foreach (var t in arr)
                    {
                        Console.Write(t.ToString() + " ");
                    }
                }
            }
        }
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        insertionSort1(n, arr);
    }
}