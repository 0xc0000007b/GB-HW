import random
import math
from colorama import init, Fore
init(autoreset = True)
def fibonacci():
    num = int(input(Fore.MAGENTA +'input your number: \n'))
    first = 1
    second = 1

    while num > 2:
        first, second = second, first + second
        num -= 1
        print(Fore.CYAN + str(second*-1),  Fore.CYAN + str(second), end = ' ')
    if num == 1:
        print(1)
    if num == 0:
        print(Fore.RED + "смысл?")

def odd_values_to_list_appender():
    num = int(input(Fore.GREEN + 'input range: \n'))
    used_list = [(random.randint(0, 15)) for _ in range(num)]
    print(Fore.YELLOW +str(used_list))
    odd_list = []
    odd_values = 0
    for i in range(len(used_list)):
        if i % 2 != 0:
             odd_values += used_list[i]
             odd_list.append(used_list[i])
    print(Fore.GREEN + "numbers, which stand on odd indexes: ", Fore.CYAN + str(odd_list), Fore.GREEN + "sum equals:",Fore.RED + str(odd_values) )

def to_bin():
    system_index = int(input(Fore.GREEN +'input num(from 2 to 9): '))
    num = int(input(Fore.BLUE + 'input num: '))

    new_num = ''
    while num > 0:
        if 2 < system_index >= 9:
            print(Fore.RED + f'sorry this system {system_index} do not exist')
            break
        else:
            new_num += str(num % system_index)
            num//=2
    print(Fore.CYAN + "your number in binary numeric system: " + new_num, end = ' ')

def calc_difference():
    test = [10.0, 1.1, 1.99, 3.33, 33.5, 12.1, 55.5, 666.9, 999.999, 1000.9]
    max_val = max(test)
    print( Fore.CYAN + f'difference between {max_val} and {round(test[4],1)} equals: ' + str(round((max_val-math.floor(max_val))-(test[4]-math.floor(test[4])), 1)))

def calc_multiply():
    used_numbers = [random.randint(0, 15) for _ in range(6)]

    mul = 0
    mul1 = 0
    mul2 = 0

    for i in range(len(used_numbers)):
        mul = used_numbers[0] * used_numbers[5]
        mul1 = used_numbers[1] * used_numbers[4]
        mul2 = used_numbers[2] * used_numbers[3]


    print(Fore.BLUE + "multiply of elements equals: ", Fore.LIGHTGREEN_EX +str(mul),Fore.LIGHTBLUE_EX + str(mul1), Fore.LIGHTCYAN_EX +str(mul2))