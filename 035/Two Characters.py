#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the alternate function below.

import itertools
#itertools 를 참조 추가 하여 반복문을 간결하게 사용

def validate(s_copy):
    for i in range(len(s_copy)-1):
        if s_copy[i] == s_copy[i+1]:
            return False
    return True

def alternate(s):
    # 유니크캐릭터라는 변수에 리스트셋을 이용하여 중복 제거된 리스트를 넣는다.
    # (list 를 set 형태로 바꾸고 중복제거가 진행된뒤 다시 list 로 바꾸는 개념.)
    unique_chars = list(set(s))
    # itertools.combinations 를 사용하면 모든 조합을 뽑아낼수 있다. 2차원 배열 
    # [('f', 'e'), ('f', 'b'), ('f', 'a'), ('e', 'b'), ('e', 'a'), ('b', 'a')]
    unique_pairs = list(itertools.combinations(unique_chars, 2))
    # print(unique_pairs)
    # 최대 길이를 0으로 초기 세팅을 한다.
    max_length = 0
    # 위에서 뽑아낸 모든조합이 존재하는 리스트로 반복문을 돌림.

    for tup in unique_pairs:
        # 리스트 컴프리헨션 (Comprehension)
        # [표현식 for 항목 in 반복가능객체 if 조건]
        
        # for c in s -> s를 c에 넣고 
        # if c in tup -> 만약 c에 tup 가 있으면 
        # c -> c를 선택하라 


        s_copy = [c for c in s if c in tup]

# 10
# beabeefeab

# ('e', 'a')
# ['e', 'a', 'e', 'e', 'e', 'a']
# ('e', 'b')
# ['b', 'e', 'b', 'e', 'e', 'e', 'b']
# ('e', 'f')
# ['e', 'e', 'e', 'f', 'e']
# ('a', 'b')
# ['b', 'a', 'b', 'a', 'b']
# ('a', 'f')
# ['a', 'f', 'a']
# ('b', 'f')
# ['b', 'b', 'f', 'b']

        if validate(s_copy):

            max_length = max(max_length, len(s_copy))

    return max_length

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    l = int(input().strip())

    s = input()

    result = alternate(s)

    fptr.write(str(result) + '\n')

    fptr.close()
