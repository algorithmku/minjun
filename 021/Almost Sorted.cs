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

1행은 입력 갯수
2행은 입력 값 

문제의 요점은 정렬을 따지는것임 
1,2,3,4,5,6,7~~~~
이렇게 순서대로 정렬이 되는건데 

예제 1을 보면 4,2가 입력됨
스왑을한다는건 순서를 바꾼다는건데 순서를 바꿔서 정렬이 되는지 보는거임
4,2의 순서를 바꿔서 2,4가 되면 입력된 값중에 정렬이 되는것임 
그럼 일단 yes 를 출력하고 swap 1 2 를 출력하는데 여기서 1 2 는 index 번호임 
(여기서 번호는 배열이 아닌 그냥 1번부터 ~~~~ 999번으로 따짐)

그럼 2번째 예제를 보면 3개를 입력하는데 3 1 2 다 
그럼 이거는 어떻게 swap 을 진행하든 1 2 3 이 불가능함
그냥 no 때려버림...

그리고 3번쨰 예제 
6개를 입력하는데 1,5,4,3,2,6임 이건 reverse 로 순서를 바꾸면 된다.
리버스를 한다는건 순서를 역순으로 다시 바꾼다는것..

2번째 [5] 부터 5번째 [2] 까지 
5,4,3,2 를 2,3,4,5 로 리버스 때리면
1,2,3,4,5,6이 된다.
그래서 yes 하고 reverse 로 2 5 를 노출 


 */
    
    // Complete the almostSorted function below.
    static void almostSorted(int[] arr) {

        //비교할 준비를 해보자...

        //우선 똑같은 배열을 복사를 한다.
        int[] arrSort = (int[])arr.Clone();
        //정렬한 값으로 우선 Sort 를 진행한다.
        Array.Sort(arrSort);
        //List 를 준비하자 -> 두개 배열 비교하고 다른것의 위치를 넣기위해
        List<int> list = new List<int>();
        
        for(int i = 0 ; i < arr.Length ; i++){
            if (arr[i] != arrSort[i]){
                //다르면 넣자 
                list.Add(i);
            }
        }
        int[] arrlist = list.ToArray();        
        int a = arrlist[0];
        int b = arrlist[arrlist.Length-1];
        
        //만약에 2개가 다른거면 스왑
        if (arrlist.Length == 2){
            
            Console.Write("yes");
            Console.Write("\n");
            Console.Write("swap ");
            Console.Write(a+1);
            Console.Write(" ");
            Console.Write(b+1);
            
        }else{
            //아니면 리버스 혹은 no
            bool reverseCheck = true;
            
            // list 에 담긴 값중 첫번째 값 부터 
            // 마지막값까지 돌리는데
            // 기존에 arr값과 소트한값[첫번째값+마지막값-현재위치]를 함.
            // 예를 들어.
            // 첫번째값 2 마지막값 5
            // 더하면 7
            // 만약 첫번째를 돌면 
            // -i 를 하면 2를 뻄 그래서 5가 되고 arr[2]랑 arrSort[5]랑 비교하는샘임 
            // 두번쨰 돌면 
            // -i 를 하면 3을 뺌 그래서 4가 되고 arr[3]이랑 arrSort[4]랑 비교하는샘임.
            // 다 돌면 순서를 바꿀수있는 리버스했을때 소트가 맞는거고.
            // 돌다가 틀리면 리버스가 안되는값이라서 그냥 no 
            for (int i = a; reverseCheck && i <= b; i++){
                if (arr[i] != arrSort[a+b-i]){
                    reverseCheck = false;
                    break;
                }
            }
            
            if (reverseCheck){
                
                Console.Write("yes");
                Console.Write("\n");
                Console.Write("reverse ");
                Console.Write(a+1);
                Console.Write(" ");
                Console.Write(b+1);

            }else{
                Console.Write("no");
            }
            
        }
        

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        almostSorted(arr);
    }
}

