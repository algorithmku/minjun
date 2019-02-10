#!/bin/python3

import math
import os
import random
import re
import sys

from collections import defaultdict
#https://www.hackerrank.com/challenges/closest-numbers/problem
# Complete the closestNumbers function below.
def closestNumbers(arr):
    #정렬
    arr.sort()
    # collections 의 defaultdict() 모듈을 사용하여 list타입으로 사용할것을 선언. 
    dic = defaultdict(list)
    
    for i in range(len(arr) - 1):
    #반복문을 사용하여 배열i - 배열[i+1을 ] extend 시킨다.
    #list 를 사용하기때문에 append가 아님. append는 object에서 사용 
    # dic 의 정수값 list 에 i : i+2 값을 
        dic[abs(arr[i] - arr[i+1])].extend(arr[i:i+2])
        #print(dic)
    # 가장 작은 값을 리턴함
    return dic[min(dic)]


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = closestNumbers(arr)

    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')

    fptr.close()