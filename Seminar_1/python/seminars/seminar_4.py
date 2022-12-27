from random import *

import numpy
from sympy import symbols
from math import prod

def fixed_round(num, rounding):
    template = '{:.' + str(num) + 'f}'
    print(template.format(rounding))

def check_nat(num):
    ans = []
    mult = 2
    simple_mult = num
    while mult <= num:
        if num % mult == 0:
            ans.append(mult)
            num //= mult
            mult = 2
        else:
            mult += 1


    print( *ans, sep = ',')


def get_unique(list):
    unique_list = numpy.unique(list)

    print(unique_list)

def polymonial(num):
    max_v = 100
    coeff=[randint(-max_v ,max_v) for i in range(num)]+[randint(1,max_v)]
    sym = symbols('x²')

    print(sum(map(prod,zip(coeff,[sym * i + sym ** i  for i in range(num+1)]))), '= 0')
