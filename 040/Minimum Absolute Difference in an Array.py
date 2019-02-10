#!/bin/python3

import math
import os
import random
import re
import sys
#>https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem

# Complete the minimumAbsoluteDifference function below.
def minimumAbsoluteDifference(arr):

    arr.sort()
    result = min([abs(arr[item+1] - arr[item]) for item in range(len(arr)-1)])
    return result

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input())

    arr = list(map(int, input().rstrip().split()))

    result = minimumAbsoluteDifference(arr)

    fptr.write(str(result) + '\n')

    fptr.close()
