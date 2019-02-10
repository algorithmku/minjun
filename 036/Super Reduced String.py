#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the superReducedString function below.
def superReducedString(s):

    # 문자열 s 를 리스트형으로 s에 다시 넣는다.
    s = list(s)
    # 초기값 0 을 설정
    i = 0
    # 반복문을 돌림 i가 s-1의 길이값보다 적을때 
    while i < len(s) - 1:
        # 만약 s의 [i]랑 s[i+1]이랑 같다면 
        if s[i] == s[i + 1]:
            # pop하여 s에서 삭제한다.
            s.pop(i)
            # pop을 한번 더 하여 i + 1 에 대해서도 삭제를 한다.
            s.pop(i)
            # i를 0으로 다시 초기화 한다.
            i = 0
        else:
            i = i + 1

    if len(s) == 0:
        # s의 길이가 0이면 빈문자열
        return 'Empty String'
    else:
        # s의 길이가 존재하면 list 를 다시 join 을 이용하여 string 으로 변환한다.
        return "".join(s)
    

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    result = superReducedString(s)

    fptr.write(result + '\n')

    fptr.close()