#!/bin/python3

import math
import os
import random
import re
import sys
#https://www.hackerrank.com/challenges/caesar-cipher-1/problem
# Complete the caesarCipher function below.
def caesarCipher(s, k):
    # s = 문자열
    # k = 밀릴 숫자

    #     print(ord("a"))
    #     print(ord("z"))
    #     print(ord("A"))
    #     print(ord("Z"))

    # 97
    # 122
    # 65
    # 90


    result = ''
    
    #k = k % 26 
    ## k는 100 까지 입력이 가능 하여 26개 알파벳 내에 안맞을수 있음. 
    ## 1바퀴 이상 


    for i in s:
        # 알파벳 여부를 먼저 파악함 isalpha
        if i.isalpha():
            ## num = ord(i) + k
            # 아스키 코드를 사용하는 방법 (숫자 -> 문자)
            # chr(97)   # 결과값 a  
            # 아스키 코드를 사용하는 방법 (문자 -> 숫자)
            # ord("a")  # 결과값 97
            
            # 대문자 
            # if i.isupper():
            #     if (num <= 65) : 
            #         # 범위 밖
            #         result += chr(64 + k)
            #     elif (num >= 90):
            #         # 범위 밖
            #         result += chr(64 + (num - 90))
            #     else :
            #         result += chr(ord(i) + k)
            # # 소문자
            # else :
            #     if (num <= 97):
            #         # 범위 밖
            #         result += chr(96 + k)
            #     elif (num >= 122):
            #         result += chr(96 + (num - 122))
            #         # 범위 밖
            #     else :
            #         result += chr(ord(i) + k)

            # 대문자 
            if i.isupper():
                result += chr( 65 + ((ord(i) - 65  + k) % 26))
            # # 소문자
            else:
                result += chr( 97 + ((ord(i) - 97  + k) % 26))

        else:
            # 알파벳이 아니면 동일하게 result 에 붙임.
            result += i




    return result
    
if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    s = input()

    k = int(input())

    result = caesarCipher(s, k)

    fptr.write(result + '\n')

    fptr.close()
