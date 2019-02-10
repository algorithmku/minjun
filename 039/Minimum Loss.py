#!/bin/python3

import math
import os
import random
import re
import sys
#https://www.hackerrank.com/challenges/minimum-loss/problem
# Complete the minimumLoss function below.
def minimumLoss(price):
    #price 를 reverse sort 함 
    sorted_price = sorted(price, reverse=True)
    print(sorted_price)
    # 가장 작은 가격차이를 0번과 1번을 계산하여 우선대입
    min_price = sorted_price[0] - sorted_price[1]
    print(min_price)
    # 플래그 선언 
    flag = False

    # 1부터 n 까지 반복
    for i in range(1, n):
        # 1부터 소트한 값의 길이 -i 반복
        for j in range(1, len(sorted_price)-i):
            # temp 에 j 값에서 j+i 값을 뺌 
            temp = sorted_price[j] - sorted_price[j+i]
            print(temp)
            # 작은 값과 temp 를 비교함 그리고인덱스 j 값과 j+1 값을 비교함.
            if(min_price >= temp and price.index(sorted_price[j]) < price.index(sorted_price[j+i])):
                min_price = temp
                flag = True
        if(flag == True):
            return min_price

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    price = list(map(int, input().rstrip().split()))

    result = minimumLoss(price)

    fptr.write(str(result) + '\n')

    fptr.close()