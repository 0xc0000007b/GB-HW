import random


def find_and_mult():
   num = int(input())
   stronger_list = [random.randint(-10, 10) for _ in range(num)]
   ind = int(input('Which index will come first? '))
   ind1 = int(input('Which index will come second? '))
   list_2 = []
   for i in range(len(stronger_list)):
       print(stronger_list[i], end = ' ')
       list_2.append(stronger_list[ind] * stronger_list[ind1])
   print()
   print(f"product of indexes equals: ", *list_2, end = ' ')
   print()

def shuffle_list():
    num = int(input())
    test_list = [random.randint(-10, 10) for _ in range(num)]
    for i  in range(len(test_list)):
        print(test_list[i], end = ' ')
    random.shuffle(test_list)
    print()
    print(*test_list, end = ' ')

from find_and_mult_indexes import *

def find_str():
    one = int(input())
    test_list = []
    for i in range(random.randint(-5, 5), one):
        test_list.append(i * i)
    print(test_list)

def find_frac():
    number = int(input())
    g_list = []
    for i in range(number):
        g_list.append(i+i)
    print(g_list)

def find_sum():
    number = input()
    sum = 0
    for i in number:
        if i != '.':
            if i != ',':
                sum += int(i)
    print("Сумма:", sum)

