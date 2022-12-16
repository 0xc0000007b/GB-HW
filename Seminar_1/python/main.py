import math
from random import randint
from find_and_mult_indexes import *


def check_day():
    print('input day: ')
    week_day = int(input())
    if week_day == 6 or week_day == 7:
        print("weekend")
    elif week_day > 7:
        print('wrong day')
    else:
        print("go to work")


def print_scond_digit():
    num = input()
    if '.' in num:
        dot_index_next_index = num.index('.', ',')+1
        print(num[dot_index_next_index])
    elif ',' in num:
        dot_index_next_index = num.index(',')+1
        print(num[dot_index_next_index])

    else:
        print('not found')

def InputNumbers(num):
    test = ["X", "Y", "Z"]
    arr = []
    for i in range(num):
        arr.append(input(f'Введите значение {test[i]}: '))
    return arr

def get_predicates(num):
    setter = not(num[0] or num[1] or num[2])
    getter = not(num[0] or num[1] or num[2])
    res = setter == getter
    return res

def check_pred():
    stat = InputNumbers(3)
    if get_predicates(stat) == True:
        print("truth")
    else:
        print("false")

def calc_distantion():
    print("input coordinate")
    coord_one_a = int(input())
    print("input coordinate")
    coord_one_b = int(input())
    print("input coordinate")
    coord_two_a = int(input())
    print("input coordinate")
    coord_two_b = int(input())

    res = math.sqrt((coord_one_a - coord_one_b) * (coord_two_a - coord_two_b))
    print(f' dist in 2d coordinates between coords {coord_one_a}, {coord_one_b}, {coord_two_a} and {coord_two_b} equals is: {res}')

def check_quarter(x, y):
    if x > 0 and y > 0:
        print('1 quarter')
    elif x < 0 and y > 0:
        print('2 quarter')
    elif x < 0 and y < 0:
        print('3 quarter')
    elif x > 0 and y < 0:
        print('4 quarter')
    elif x == 0 and y == 0:
        print('start of coordinates system')

def check_dots(x, y):
    if x > 0 and y > 0:
        print(f'1 quarter. x: from {x} to +unlimited and y: from {y} to +unlimited')
    elif x < 0 and y > 0:
        print(f'2 quarter. from -unlimited to {x} and y: from {y} to +unlimited')
    elif x < 0 and y < 0:
        print(f'3 quarter. from -unlimited to {x} and y: from -unlimited to {y}')
    elif x > 0 and y < 0:
        print(f'4 quarter. from {x} to +unlimited and y: from -unlimited to {y}')
    elif x == 0 and y == 0:
        print('start of coordinates system')


def checker():
    check_day()
    check_pred()
    calc_distantion()
    check_quarter(-5, 5)
    check_dots(-5, 3)
    find_sum()
    find_frac()
    find_and_mult()
    find_str()


if __name__ == '__main__':
    checker()


