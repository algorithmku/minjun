#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the pairs function below.
def pairs(k, arr):
# k   : 2개의 조합에서 서로 값을 마이너스(-) 를 하면 나와야하는 값 
# arr : 배열 


# 풀이의 방식을 arr[0] - arr[1] 로 하여 모든 경우의수를 구하는것 보다는
# 어차피 2의 값이 나와야 하기때문에 +2를 해서 값을 나열한다.

# 순서 

# 1) 첫번째 집합(set)에 arr을 넣는다.
# 2) 두번째 집합(set)에 arr을 x로 for문을 돌리고 x와 k를 더한다.

## 2-1) 

# 5 2  

# 1 5 3 4 2  

# x+k 

# 1 + 2 = 3 
# 5 + 2 = 7 
# 3 + 2 = 5
# 4 + 2 = 6 
# 2 + 2 = 4 

# 3) 두개의 집합의 교집합을 구한다 (A & B)

# 첫번째 집합 = 1, 5, 3, 4, 2
# 두번째 집합 = 3, 7, 5, 6, 4 
# 교집합 = 3, 5, 4

# 4) 구해진 교집합의 길이(카운트)를 리턴한다.

    return len(set(arr) & set(x + k for x in arr))


    
if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    nk = input().split()

    n = int(nk[0])

    k = int(nk[1])

    arr = list(map(int, input().rstrip().split()))

    result = pairs(k, arr)

    fptr.write(str(result) + '\n')

    fptr.close()
