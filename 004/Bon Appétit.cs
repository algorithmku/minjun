/*
Bon Appétit
https://www.hackerrank.com/challenges/bon-appetit/problem
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution {
class Solution {
    static void Main(string[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT */
/*
        Bon Appétit 는 프랑스어네..

        브라이언이랑 안나랑 음식을 주문해서 나눠먹음 
        안나는 특정 음식을 알레르기로 먹지않음
        근데 반반 나눠내는건 똑같이 나눠내서 브라이언이 안나에게 차액을 돌려주는걸 계산해야함
        
        1번 예시
        
        4 1             << 4개를 주문하고 안나는 1번을 안먹음 여기서 1번은 배열의 1번
        3 10 2 9
        12  
        
        2번행의 음식가격 모두를 더한값은 24 그걸 2명으로 나눴을때 12로 계산을 했음. 
        하지만 안나는 1번음식을 먹지 않음. 
        1번은 배열로 보면 10이며 10에 대한 반값 5를 돌려준다
        
        2번 예시
        
        4 1
        3 10 2 9
        7
        
        위의 계산결과처럼 24의 합중에 반반하면 12인데 1번음식을 먹지 않아 5를 덜받음
        브라이언은 안나가 더내면 돌려줘도 덜내면 달라고 하지 않는 상남자네..
        안나가 낸돈이 브라이언보다 작거나 딱 맞으면 "Bon Appetit"를 출력함.
        
        
        
        
*/
        //임의로 값을 나눠본다
        string[] n = Console.ReadLine().Split(' ');
        // 주문한 갯수
        // int order_count = int.Parse(n[0]);
        // 안나가 안먹은것
        int anna_not_eat_arr = int.Parse(n[1]);
        // 전체 먹은 음식의 값 배열
        string[] input_arr = Console.ReadLine().Split(' ');
        // 안나가 낸돈
        int bill_anna = int.Parse(Console.ReadLine());
        // 값들을 int 형으로 변경
        var ar = Array.ConvertAll(input_arr, int.Parse);
        // 토탈 가격을 계산하고.
        int bill_total = ar.Sum();
        // 나누고
        int bill_p = bill_total/2;
        // 안나가 안먹은것의 반값을 더하고
        int anna_not_eat = int.Parse(input_arr[anna_not_eat_arr])/2;
        // 토탈의 나눈값의 안나가 안먹은 반값을 더하면 브라이언이 낼돈이 나오고..
        int bill_brian = bill_p + anna_not_eat;
        // 안나가 낸 돈 <= 토탈값 - 브라이언이 내야할 값 
        if (bill_anna <= (bill_total-bill_brian)){
            Console.WriteLine("Bon Appetit"); 
        }else{
            Console.WriteLine(bill_brian - bill_anna);
        }
        
        
        
    }
   
}
}



