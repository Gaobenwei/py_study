# # #!/usr/bin/python3
# # -*- coding: utf-8 -*-
#
# __author__ = 'awei'
#
# import pprint
#
# # str='123456789'
#
# # print(str)                 # 输出字符串
# # print(str[0:-2])           # 输出第一个到倒数第二个的所有字符
# # print(str[0])              # 输出字符串第一个字符
# # print(str[2:5])            # 输出从第三个开始到第六个的字符（不包含）
# # print(str[2:])             # 输出从第三个开始后的所有字符
# # print(str[1:5:2])          # 输出从第二个开始到第五个且每隔一个的字符（步长为2）
# # print(str * 2)             # 输出字符串两次
# # print(str + '你好')         # 连接字符串
#
# # print('------------------------------')
#
# # print('hello\nrunoob')      # 使用反斜杠(\)+n转义特殊字符
# # print(r'hello\nrunoob')     # 在字符串前面添加一个 r，表示原始字符串，不会发生转义
# # # name = input("\n\n输入name 键后退出。\n")
# # # print('hello,', name)
#
# # #!/usr/bin/python3
#
# # import sys; x = 'runoob'; sys.stdout.write(x+'\n'+'\n')
#
# # x="a"
# # y="b"
# # print( x, end=" " )
# # print( y, end=" " )
# # print()
# # import sys # 导入模块
# # from sys import argv,path  #  导入特定的成员
# # from sys import *  # 导入所有成员
#
# # !/usr/bin/python3
#
# # import sys
#
# # print ('参数个数为:', len(sys.argv), '个参数。')
# # print ('参数列表:', str(sys.argv))
# # print ('脚本名:', str(sys.argv[0]))
# # print (sys.argv[1])
#
# # import sys
# # import getopt
#
# # def site():
# #     name = None
# #     url = None
#
# #     argv = sys.argv[1:]
#
# #     try:
# #         opts, args = getopt.getopt(argv, "n:u:",
# #                                    ["name=",
# #                                     "url="])  # 长选项模式
#
# #     except:
# #         print("Error")
#
# #     for opt, arg in opts:
# #         if opt in ['-n', '--name']:
# #             name = arg
# #         elif opt in ['-u', '--url']:
# #             url = arg
#
#
# #     print( name + " " + url)
#
# # site()
#
# # print(r'''hello,\n
# # world''')
# # n = 123
# # f = 456.789
# # s1 = 'Hello, world'
# # s2 = 'Hello, \'Adam\''
# # s3 = r'Hello, "Bart"'
# # s4 = r'''Hello,
# # Bob!'''
#
# # print(n,f,s1,s2,s3,s4)
# # # del n
# # # del f
# # print(n,f,s1,s2,s3,s4)
#
# # # 布尔类型的值和类型
# # a = True
# # b = False
# # print(type(a))  # <class 'bool'>
# # print(type(b))  # <class 'bool'>
#
# # # 布尔类型的整数表现
# # print(int(True))   # 1
# # print(int(False))  # 0
#
# # # 使用 bool() 函数进行转换
# # print(bool(0))         # False
# # print(bool(42))        # True
# # print(bool(''))        # False
# # print(bool('Python'))  # True
# # print(bool([]))        # False
# # print(bool([1, 2, 3])) # True
#
# # # 布尔逻辑运算
# # print(True and False)  # False
# # print(True or False)   # True
# # print(not True)        # False
#
# # # 布尔比较运算
# # print(5 > 3)  # True
# # print(2 == 2) # True
# # print(7 < 4)  # False
#
# # # 布尔值在控制流中的应用
# # if True:
# #     print("This will always print")
#
# # if not False:
# #     print("This will also always print")
#
# # x = 10
# # if x:
# #     print("x is non-zero and thus True in a boolean context")
#
# # !/usr/bin/python3
#
# # list = [ 'abcd', 786 , 2.23, 'runoob', 70.2 ]  # 定义一个列表
# # tinylist = [123, 'runoob']
#
# # print (list)            # 打印整个列表
# # print (list[0])         # 打印列表的第一个元素
# # print (list[1:3])       # 打印列表第二到第四个元素（不包含第四个元素）
# # print (list[2:])        # 打印列表从第三个元素开始到末尾
# # print (tinylist * 2)    # 打印tinylist列表两次
# # print (list + tinylist)  # 打印两个列表拼接在一起的结果
# # print(list[0:4:1])      # 从第一个元素开始，每隔一个元素打印一个元素
#
# # def reverseWords(input):
#
# #     # 通过空格将字符串分隔符，把各个单词分隔为列表
# #     inputWords = input.split(" ")
#
# #     # 翻转字符串
# #     # 假设列表 list = [1,2,3,4],
# #     # list[0]=1, list[1]=2 ，而 -1 表示最后一个元素 list[-1]=4 ( 与 list[3]=4 一样)
# #     # inputWords[-1::-1] 有三个参数
# #     # 第一个参数 -1 表示最后一个元素
# #     # 第二个参数为空，表示移动到列表末尾
# #     # 第三个参数为步长，-1 表示逆向
#
# #     inputWords_=inputWords[0:2]
# #     inputWords=inputWords[-1::-1]
#
#
# #     # 重新组合字符串
# #     # output = '+'.join(inputWords)
# #     output = inputWords_ + inputWords
#
# #     return output
#
# # if __name__ == "__main__":
# #     input = 'I like runoob'
# #     rw = reverseWords(input)
# #     print(rw)
#
# # print(ord('A'))
# # print(ord("中"))
# # print('%02d-%2d' % (3, 1))
# # print('%.2f' % 3.1415926)
# # print('%0.2f' % 3.1)
# # print('Age: %s. Gender: %s' % (25, True))
# # print('growth rate: %d %%' % 7)
#
# # r = 2.5
# # s = 3.14 * r ** 2
# # print(f'The area of a circle with radius {r} is {s:.2f}')
#
# # s1 = 72
# # s2 = 85
# # r = (s2-s1)/s1*100
# # print(f'growth rate: {r:.1f} %')
# # print("growth is %.1f%% \n" % r)
#
# classmates = ['Michael', 'Bob', 'Tracy']  # 定义一个列表
# print(classmates)
# # print(len(classmates))
# # print(classmates[0])
# # print(classmates[-1])
# # classmates.append('Adam') # 添加元素到末尾
# # print(classmates)
# # classmates.insert(1, 'Jack') # 插入元素到指定位置
# # print(classmates)
# # classmates.pop() # 删除末尾元素
# # print(classmates) # ['Michael', 'Jack', 'Tracy']
# # classmates.pop(1) # 删除指定位置元素
# # print(classmates) # ['Michael', 'Tracy']
# # classmates[1] = 'Sarah' # 替换指定位置元素
#
# L = [
#     ['Apple', 'Google', 'Microsoft'],
#     ['Java', 'Python', 'Ruby', 'PHP'],
#     ['Adam', 'Bart', 'Bob']
# ]
# print(L[0][0])
# print(L[1][1])
# print(L[2][2])
#
# age = 15
#
# match age:
#     case x if x < 10:
#         print(f'< 10 years old: {x}')
#     case 10:
#         print('10 years old.')
#     case 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18:
#         print('11~18 years old.')
#     case 19:
#         print('19 years old.')
#     case _:
#         print('not sure.')
#
# args = ['gcc', 'hello.c', 'world.c']
# # args = ['clean']
# # args = ['gcc']
#
# match args:
#     # 如果仅出现gcc，报错:
#     case ['gcc']:
#         print('gcc: missing source file(s).')
#     # 出现gcc，且至少指定了一个文件:
#     case ['gcc', *file1]:
#         print('gcc compile: ' + ", ".join(file1))
#     # 仅出现clean:
#     case ['clean']:
#         print('clean')
#     case _:
#         print('invalid command.')
#
# sum = 0
# for x in range(101):
#     sum = sum + x
# print(sum)
#
# L = ['Bart', 'Lisa', 'Adam']
# for name in L:
#     print("hello, %s" % name)
#
# for num in list(range(0, 10)):
#     print(num)
#
# d = {'Michael': 95, 'Bob': 75, 'Tracy': 85}
# print(d.get("ddd", "100"))
# d.pop("Bob")
# print(d)
#
# t = ("hello", "world", 1, 2, 3)  # 元组
# print(t)
#
# # !/usr/bin/python3
#
# sites = {'Google', 'Taobao', 'Runoob', 'Facebook', 'Zhihu', 'Baidu'}
#
# print(sites)  # 输出集合，重复的元素被自动去掉
#
# # 成员测试
# if 'Runoob' in sites:
#     print('Runoob 在集合中')
# else:
#     print('Runoob 不在集合中')
#
# # set可以进行集合运算
# a = set('abracadabra')
# b = set('alacazam')
#
# print(a)
#
# print(a - b)  # a 和 b 的差集
#
# print(a | b)  # a 和 b 的并集
#
# print(a & b)  # a 和 b 的交集
#
# print(a ^ b)  # a 和 b 中不同时存在的元素
#
# # !/usr/bin/python3
#
# dict = {}
# dict['one'] = "1 - 菜鸟教程"
# dict[2] = "2 - 菜鸟工具"
#
# tinydict = {'name': 'runoob', 'code': 1, 'site': 'www.runoob.com'}
#
# print(dict['one'])  # 输出键为 'one' 的值
# print(dict[2])  # 输出键为 2 的值
# print(tinydict)  # 输出完整的字典
# print(tinydict.keys())  # 输出所有键
# print(tinydict.values())  # 输出所有值
#
# a = "asdfasdfasdfdsf"
# if (n := len(a)) > 10:
#     print(f"List is too long ({n} elements, expected <= 10)")
#
# # !/usr/bin/python3
#
# a = 10
# b = 20
#
# if (a and b):
#     print("1 - 变量 a 和 b 都为 true")
# else:
#     print("1 - 变量 a 和 b 有一个不为 true")
#
# if (a or b):
#     print("2 - 变量 a 和 b 都为 true，或其中一个变量为 true")
# else:
#     print("2 - 变量 a 和 b 都不为 true")
#
# # 修改变量 a 的值
# a = 0
# if (a and b):
#     print("3 - 变量 a 和 b 都为 true")
# else:
#     print("3 - 变量 a 和 b 有一个不为 true")
#
# if (a or b):
#     print("4 - 变量 a 和 b 都为 true，或其中一个变量为 true")
# else:
#     print("4 - 变量 a 和 b 都不为 true")
#
# if not (a and b):
#     print("5 - 变量 a 和 b 都为 false，或其中一个变量为 false")
# else:
#     print("5 - 变量 a 和 b 都为 true")
#
# # !/usr/bin/python3
#
# a = 20
# b = 20
#
# if (a is b):
#     print("1 - a 和 b 有相同的标识 id(a)=%d id(b)=%d" % (id(a), id(b)))
# else:
#     print("1 - a 和 b 没有相同的标识")
#
# if (id(a) == id(b)):
#     print("2 - a 和 b 有相同的标识 ")
# else:
#     print("2 - a 和 b 没有相同的标识")
#
# # 修改变量 b 的值
# b = 30
# if (a is b):
#     print("3 - a 和 b 有相同的标识 id(a)=%d id(b)=%d" % (id(a), id(b)))
# else:
#     print("3 - a 和 b 没有相同的标识")
#
# if (a is not b):
#     print("4 - a 和 b 没有相同的标识")
# else:
#     print("4 - a 和 b 有相同的标识")
#
# import time
#
# # for i in range(101):
# #     print("\r{:3}%".format(i),end=' ')
# #     time.sleep(0.05)
#
# # for i in range(101):
# #     print("\r %d%%" % i, end="")
# #     time.sleep(0.1)
# # for x in [1, 2, 3]:
# #     print("\r x=%d" % x, end=" ")
# #     time.sleep(10)
#
# tinydict = {("hello", "fuck"): ["a", "b", "c", "d"]}
# print(len(tinydict))
# print(tinydict)
# print(tinydict.get(("hello", "fuck")))
# print(tinydict.keys())
# print(tinydict.values())
#
# t = {}
# print(type(t))
# print(type(()))
# print(type(set()))
#
# thisset = set(["Google", "Runoob", "Taobao"])
# thisset.add("Facebook")
# print(thisset)
# a = set(x for x in thisset if x != "Runoob")  # 生成器
# print(type(a))
# print(a)
# thisset.update(["Baidu", "Sina"])  # 添加多个元素
# print(thisset)
# thisset.update({"hello": 1, "fuck": 2})  # 用字典添加多个元素
# print(thisset)
#
# for x in range(1, 10):
#     thisset = set(("Google", "Runoob", "Taobao", "Facebook"))
#     x = thisset.pop()
#     print(x)
#
#
# # !/usr/bin/python3
#
# # age = int(input("请输入你家狗狗的年龄: "))
# # print("")
# # if age <= 0:
# #     print("你是在逗我吧!")
# # elif age == 1:
# #     print("相当于 14 岁的人。")
# # elif age == 2:
# #     print("相当于 22 岁的人。")
# # elif age > 2:
# #     human = 22 + (age -2)*5
# #     print("对应人类年龄: ", human)
#
# # ### 退出提示
# # input("点击 enter 键退出")
#
# # !/usr/bin/python3
#
# # num=int(input("输入一个数字："))
# # if num%2==0:
# #     if num%3==0:
# #         print ("你输入的数字可以整除 2 和 3")
# #     else:
# #         print ("你输入的数字可以整除 2，但不能整除 3")
# # else:
# #     if num%3==0:
# #         print ("你输入的数字可以整除 3，但不能整除 2")
# #     else:
# #         print  ("你输入的数字不能整除 2 和 3")
#
# class Circle:
#     def __init__(self, radius):
#         self.radius = radius
#
#
# class Rectangle:
#     def __init__(self, width, height):
#         self.width = width
#         self.height = height
#
#
# def match_shape(shape):
#     match shape:
#         case Circle(radius=1):
#             print("匹配到半径为1的圆")
#         case Rectangle(height=4):
#             print("匹配到宽度为1，高度为2的矩形")
#         case _:
#             print("匹配到其他形状")
#
#
# match_shape(Circle(2))  # 输出: 匹配到半径为1的圆
# match_shape(Rectangle(3, 4))  # 输出: 匹配到宽度为1，高度为2的矩形
# match_shape("other")
#
# for num1 in range(2, 10):
#     for num2 in range(2, num1):
#         if num1 % num2 == 0:
#             print(num1, " = ", num2, " * ", num1 // num2)
#             break
#     else:
#         print(num1, "是质数")  # 输出: 匹配到其他形状
#
# # !/usr/bin/python3
#
# for letter in 'Runoob':
#     if letter == 'o':
#         pass
#         print('执行 pass 块')
#     else:
#         print('当前字母 :', letter)
#
# print("Good bye!")
#
# a, b = 0, 1
# while True:
#     print(b, end=",")
#     a, b = b, a + b
#     if (b >= 500):
#         break
# print("\n")
# # 列表推导式
# # [表达式 for 变量 in 列表]
# # [表达式 for 变量 in 列表 if 条件]
# names = ['Bob', 'Tom', 'alice', 'Jerry', 'Wendy', 'Smith']
# new_names = [name.upper() for name in names if len(name) > 3]
# print(new_names)
# print(type(new_names))
#
# multiples = [i for i in range(30) if i % 3 == 0]
# print(multiples)
# print(type(multiples))
#
# # 字典推导式
# # { key_expr: value_expr for value in collection }
# # { key_expr: value_expr for value in collection if condition }
# listdemo = ['Google', 'Runoob', 'Taobao']
# newdict = {key: len(key) for key in listdemo}
# print(newdict)
# print(type(newdict))
#
# dic = {x: x ** 2 for x in [3, 4, 5]}
# print(dic)
# print(type(dic))
#
# # 集合推导式
# # { expression for item in Sequence }
# # { expression for item in Sequence if conditional }
#
# setnew = {x ** 2 for x in range(1, 4)}
# print(setnew)
# print(type(setnew))
#
# a = {x for x in "fasdfasdf" if x not in "abc"}
# print(a)
# print(type(a))
#
# # 元组推导式（生成器表达式）
# # (expression for item in Sequence )
# # (expression for item in Sequence if conditional )
# # 元组推导式和列表推导式的用法也完全相同，只是元组推导式是用 () 圆括号将各部分括起来，而列表推导式用的是中括号 []，另外元组推导式返回的结果是一个生成器对象。
# a = (x for x in range(1, 10))
# # print(a)
# print(tuple(a))
# print(type(a))
#
#
# # !/usr/bin/python3
#
#
# def trim(s):
#     if s == "":
#         return s
#     while s[:1] == " ":
#         s = s[1:]
#     while s[-1:] == " ":
#         s = s[:-1]
#     return s
#
#
# # 测试:
# if trim('hello  ') != 'hello':
#     print('测试失败!')
# elif trim('  hello') != 'hello':
#     print('测试失败!')
# elif trim('  hello  ') != 'hello':
#     print('测试失败!')
# elif trim('  hello  world  ') != 'hello  world':
#     print('测试失败!')
# elif trim('') != '':
#     print('测试失败!')
# elif trim('    ') != '':
#     print('测试失败!')
# else:
#     print('测试成功!')
#
# d = {'a': 1, 'b': 2, 'c': 3}
# print(d.items())
# for key in d.keys():
#     print(d.get(key, 0))
#
# from collections.abc import Iterable
#
# print(isinstance("abc", Iterable))
# print(isinstance([1, 2, 3], Iterable))
# print(isinstance(123, Iterable))
# print(isinstance((x for x in range(10)), Iterable))
# print(isinstance((1, 2, 3), Iterable))
# print(isinstance({"a": 1, "b": 2}, Iterable))
# print(isinstance({"a", "b", "c"}, Iterable))
#
#
# def g():
#     yield 1
#     yield 2
#     yield 3
#
#
# print(isinstance(g(), Iterable))
#
# for value, i in enumerate(["a", "b", "c"]):
#     print(i, value)
#
#
# def findMinAndMax(L):
#     if L == []:
#         return (None, None)
#     min = L[0]
#     max = L[0]
#     for i in L:
#         if i > max:
#             max = i
#         if i < min:
#             min = i
#     return (min, max)
#
#
# # 测试
# if findMinAndMax([]) != (None, None):
#     print('测试失败!')
# elif findMinAndMax([7]) != (7, 7):
#     print('测试失败!')
# elif findMinAndMax([7, 1]) != (1, 7):
#     print('测试失败!')
# elif findMinAndMax([7, 1, 3, 9, 5]) != (1, 9):
#     print('测试失败!')
# else:
#     print('测试成功!')
#
# import os
#
# print(os.name)
# d = [d for d in os.listdir(".")]
# print(d)
#
# d = {"x": "A", "y": "B", "z": "C"}
# for k, v in d.items():
#     print(k, "=", v)
# print([k + "=" + v for k, v in d.items()])
# L = ['Hello', 'World', 'IBM', 'Apple']
# print([s.lower() for s in L])
#
# L1 = ['Hello', 'World', 18, 'Apple', None]
# L2 = [s.lower() for s in L1 if isinstance(s, str)]
#
# # 测试:
# print(L2)
# if L2 == ['hello', 'world', 'apple']:
#     print('测试通过!')
# else:
#     print('测试失败!')
#
#
# # g=(x*x for x in range(10))
# # for n in g:
# #     print(n)
#
# def fib(max):
#     n, a, b = 0, 0, 1
#     while n < max:
#         yield b
#         # print(b,end=",")
#         a, b = b, a + b
#         n = n + 1
#     return 'done'
#
#
# fo = fib(6)
# for i in fo:
#     print(i)
# fo = fib(7)
# while True:
#     try:
#         x = next(fo)
#         print("g:", x)
#     except StopIteration as e:
#         print("Generator return value:", e.value)
#         break
#
#
# def odd():
#     print('step 1')
#     yield 1
#     print('step 2')
#     yield (3)
#     print('step 3')
#     yield (5)
#
#
# o = odd()
# print(next(o))
# print(next(o))
# print(next(o))
#
#
# def triangles():
#     L = [1]
#     while True:
#         yield L
#         L = [1] + [L[i] + L[i + 1] for i in range(0, len(L) - 1)] + [1]
#
#
# # 期待输出:s
# # [1]
# # [1, 1]
# # [1, 2, 1]
# # [1, 3, 3, 1]
# # [1, 4, 6, 4, 1]
# # [1, 5, 10, 10, 5, 1]
# # [1, 6, 15, 20, 15, 6, 1]
# # [1, 7, 21, 35, 35, 21, 7, 1]
# # [1, 8, 28, 56, 70, 56, 28, 8, 1]
# # [1, 9, 36, 84, 126, 126, 84, 36, 9, 1]
# n = 0
# results = []
# for t in triangles():
#     results.append(t)
#     n = n + 1
#     if n == 10:
#         break
#
# for t in results:
#     print(t)
#
# if results == [
#     [1],
#     [1, 1],
#     [1, 2, 1],
#     [1, 3, 3, 1],
#     [1, 4, 6, 4, 1],
#     [1, 5, 10, 10, 5, 1],
#     [1, 6, 15, 20, 15, 6, 1],
#     [1, 7, 21, 35, 35, 21, 7, 1],
#     [1, 8, 28, 56, 70, 56, 28, 8, 1],
#     [1, 9, 36, 84, 126, 126, 84, 36, 9, 1]
# ]:
#     print('测试通过!')
# else:
#     print('测试失败!')
#
# for i in range(0, 0):
#     print(i)
#
# from collections.abc import Iterator, Iterable
#
# print(isinstance(iter([]), Iterator))
#
# print(isinstance(iter('abc'), Iterator))
#
# print("*-*-*-*-*", isinstance(triangles(), Iterable), isinstance(triangles(), Iterator))
# print([1, 2, 3], isinstance([1, 2, 3], Iterable), isinstance([1, 2, 3], Iterator))
#
# import os
#
# list_ = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
# iter_ = iter(list_)
# for x in iter_:
#     print(x, end=" ")
#
# print()
# iter_ = iter(list_)  # 重新获取迭代器
# while True:
#     try:
#         print(next(iter_), end=" ")
#     except StopIteration:
#         break
#
#
# class MyNumbers:
#     def __iter__(self):
#         self.a = 1
#         return self
#
#     def __next__(self):
#         if self.a <= 20:
#             x = self.a
#             self.a += 1
#             return x
#         else:
#             raise StopIteration
#
#
# print()
# myclass = MyNumbers()
# myiter = iter(myclass)
# '''
# myclass = MyNumbers()
# 这句创建了 MyNumbers 类的实例 myclass，它是一个普通的 Python 对象。此时，myclass 还不是迭代器，只是一个实现了 __iter__() 和 __next__() 方法的对象。
# myiter = iter(myclass)
# 这句调用了 myclass 的 __iter__() 方法，初始化了 self.a = 1，并将 myclass 自身返回。
# 这一步的结果是：
# myiter 和 myclass 指向同一个对象。
# 这个对象现在可以被视为迭代器，因为它实现了 __iter__() 和 __next__() 方法。
# '''
# print(next(myiter))
# print(next(myiter))
# print(next(myiter))
# print(next(myiter))
# print(next(myiter))
#
# while True:
#     try:
#         print(next(myiter), end=" ")
#     except StopIteration:
#         break
# print()
# for x in myiter:
#     print(x, end=" ")
#
# a = (x * x for x in range(10))
# print(type(a))
# print(isinstance(a, Iterator))
#
#
# def countdown(n):
#     while n > 0:
#         yield n
#         n -= 1
#
#
# # 创建生成器对象 返回的是一个生成器对象，类型是一个迭代器
# generator = countdown(5)
#
# # 通过迭代生成器获取值
# print(next(generator))  # 输出: 5
# print(next(generator))  # 输出: 4
# print(next(generator))  # 输出: 3
#
# # 使用 for 循环迭代生成器
# for value in generator:
#     print(value)  # 输出: 2 1
#
# # !/usr/bin/python3
#
# import sys
#
#
# def fibonacci(n):  # 生成器函数 - 斐波那契
#     a, b, counter = 0, 1, 0
#     while True:
#         if (counter > n):
#             return "结束"
#         yield a
#         a, b = b, a + b
#         counter += 1
#
#
# f = fibonacci(10)  # f 是一个迭代器，由生成器返回生成
#
# while True:
#     try:
#         print(next(f), end=" ")
#     except StopIteration as e:
#         print(e.value)
#         break
#
# print(hex(255))
# print(hex(1000))
#
# def my_abs(x):
#     if not isinstance(x, (int, float)):
#         raise TypeError('bad operand type') # 异常抛出
#     if x >= 0:
#         return x
#     else:
#         return -x
#
# import math
#
# def quadratic(a, b, c):
#     fenmu=a*2
#     temp=math.sqrt(b**2-4*a*c)
#     x1=(-b+temp)/fenmu
#     x2=(-b-temp)/fenmu
#     return x1,x2
#
# # 测试:
# print('quadratic(2, 3, 1) =', quadratic(2, 3, 1))
# print('quadratic(1, 3, -4) =', quadratic(1, 3, -4))
#
# if quadratic(2, 3, 1) != (-0.5, -1.0):
#     print('测试失败')
# elif quadratic(1, 3, -4) != (1.0, -4.0):
#     print('测试失败')
# else:
#     print('测试成功')
#
# def person(name,age,**kw):
#     if 'city' in kw:
#         pass
#     if 'job' in kw:
#         pass
#     print('name:',name,'age:',age,'other:',kw)
#
# # 调用者仍可以传入不受限制的关键字参数：
# person('Jack', 24, city='Beijing', addr='Chaoyang', zipcode=123456)
# # 如果要限制关键字参数的名字，就可以用命名关键字参数，例如，只接收city和job作为关键字参数。这种方式定义的函数
# # 和关键字参数**kw不同，命名关键字参数需要一个特殊分隔符*，*后面的参数被视为命名关键字参数。
# def person_1(name,age,*,city,job):
#     print(name,age,city,job) # 不能传入不受限制的关键字参数
# person_1('Jack', 24, city='Beijing', job='Engineer')
# # person_1('Jack', 24, city='Beijing', job='Engineer', addr='Chaoyang', zipcode=123456)
# # 如果函数定义中已经有了一个可变参数，后面跟着的命名关键字参数就不再需要一个特殊分隔符*了：
# def person(name, age, *args, city, job):
#     print(name, age, args, city, job)
# # 命名关键字参数必须传入参数名，这和位置参数不同。如果没有传入参数名，调用将报错：命名关键字参数可以有缺省值简化调用
# def person_1(name, age, *, city='Beijing', job):
#     print(name, age, city, job)
#
#
# def f1(a, b, c=0, *args, **kw):
#     print('a =', a, 'b =', b, 'c =', c, 'args =', args, 'kw =', kw)
# def f2(a, b, c=0, *, d, **kw):
#     print('a =', a, 'b =', b, 'c =', c, 'd =', d, 'kw =', kw)
#
# f1(1, 2)
# # a = 1 b = 2 c = 0 args = () kw = {}
# f1(1, 2, c=3)
# # a = 1 b = 2 c = 3 args = () kw = {}
# f1(1, 2, 3, 'a', 'b')
# # a = 1 b = 2 c = 3 args = ('a', 'b') kw = {}
# f1(1, 2, 3, 'a', 'b', x=99)
# # a = 1 b = 2 c = 3 args = ('a', 'b') kw = {'x': 99}
# f2(1, 2, d=99, ext=None)
# # a = 1 b = 2 c = 0 d = 99 kw = {'ext': None}
#
#
# def hello(greeting, *args):
#     if (len(args)==0):
#         print('%s!' % greeting)
#     else:
#         print('%s, %s!' % (greeting, ', '.join(args)))
#
# hello('Hi') # => greeting='Hi', args=()
# hello('Hi', 'Sarah') # => greeting='Hi', args=('Sarah')
# hello('Hello', 'Michael', 'Bob', 'Adam') # => greeting='Hello', args=('Michael', 'Bob', 'Adam')
#
# names = ('Bart', 'Lisa')
# hello('Hello', *names) # => greeting='Hello', args=('Bart', 'Lisa')
#
# def mul(*nums):
#     if len(nums)==0:
#         raise TypeError("TypeError: mul() missing 1 required positional argument: 'nums")
#         # pass
#     m=1
#     for n in nums:
#         m*=n
#     return m
# # 测试
# print('mul(5) =', mul(5))
# print('mul(5, 6) =', mul(5, 6))
# print('mul(5, 6, 7) =', mul(5, 6, 7))
# print('mul(5, 6, 7, 9) =', mul(5, 6, 7, 9))
# if mul(5) != 5:
#     print('mul(5)测试失败!')
# elif mul(5, 6) != 30:
#     print('mul(5, 6)测试失败!')
# elif mul(5, 6, 7) != 210:
#     print('mul(5, 6, 7)测试失败!')
# elif mul(5, 6, 7, 9) != 1890:
#     print('mul(5, 6, 7, 9)测试失败!')
# else:
#     try:
#         mul()
#         print('mul()测试失败!')
#     except TypeError as e:
#         print('测试成功!')
#         print(e)
#
# def move(n, a, b, c):
#     if n == 1:
#         print(a, '-->', c)
#     else:
#         move(n-1,a,c,b)
#         move(1,a,b,c)
#         move(n-1,b,a,c)
#
# # 期待输出:
# # A --> C
# # A --> B
# # C --> B
# # A --> C
# # B --> A
# # B --> C
# # A --> C
# move(3, 'A', 'B', 'C')
#
# def change(a):
#     print(id(a))   # 指向的是同一个对象
#     a=10
#     print(id(a))   # 一个新对象
#
# a=1
# print(id(a))
# change(a)
#
# #!/usr/bin/python3
#
# # 可写函数说明
# def printinfo( arg1, *vartuple ):
#    "打印任何传入的参数"
#    print ("输出: ")
#    print (arg1)
#    print (vartuple)
#
# # 调用printinfo 函数
# printinfo( 70, *( 1, 2, 3, 4 ) )
#
# x= lambda a,b:a+b
# print(x(1,2))
#
# # 可以将匿名函数赋值给一个变量，再利用变量来调用该函数：
# f = lambda x: x * x
# print(f(5))
# # 也可以把匿名函数作为返回值返回，将匿名函数封装在一个函数内部，比如：
# def build(x, y):
#     return lambda: x * x + y * y
# f = build(1, 2)
# print(f())
#
# def myfunc(n):
#     return lambda a: a*n
# mydoubler = myfunc(2)
# mytripler = myfunc(3)
#
# print(mydoubler(11))
# print(mytripler(11))
#
# print(type(myfunc(2)))
# print(type(mydoubler))
# print(type(mydoubler(11)))
#
# # 强制位置参数  / 一个函数形参语法 / 用来指明函数形参必须使用指定位置参数，不能使用关键字参数的形式。
# def f(a, b, /, c, d, *, e, f): # 形参a, b 必须使用指定位置参数，c, d 可以使用指定位置参数或关键字参数，e, f 必须使用关键字参数
#     print(a, b, c, d, e, f)
# # 正确调用
# f(10, 20, 30, d=40, e=50, f=60)
# # 错误调用
# # f(10, b=20, c=30, d=40, e=50, f=60)
#
# numbers=[1,2,3,4,5]
# sq=list(map(lambda x:x**2,numbers))
# print(sq)
#
#
# # 函数的装饰器 @
#
# # def decorator_function(original_function):
# #     def wrapper(*args, **kwargs):
# #         # 这里是在调用原始函数前添加的新功能
# #         before_call_code()
#
# #         result = original_function(*args, **kwargs)
#
# #         # 这里是在调用原始函数后添加的新功能
# #         after_call_code()
#
# #         return result
# #     return wrapper
#
# # # 使用装饰器
# # @decorator_function
# # def target_function(arg1, arg2):
# #     pass  # 原始函数的实现
# '''
# 解析：decorator 是一个装饰器函数，它接受一个函数 func 作为参数，并返回一个内部函数 wrapper，在 wrapper 函数内部，你可以执行一些额外的操作，然后调用原始函数 func，并返回其结果。
# decorator_function 是装饰器，它接收一个函数 original_function 作为参数。
# wrapper 是内部函数，它是实际会被调用的新函数，它包裹了原始函数的调用，并在其前后增加了额外的行为。
# 当我们使用 @decorator_function 前缀在 target_function 定义前，Python会自动将 target_function 作为参数传递给 decorator_function，然后将返回的 wrapper 函数替换掉原来的 target_function。
# '''
#
# '''
# @time_logger
# def target_function():
#     pass
# 等价于
# def target_function():
#     pass
# target_function = time_logger(target_function)
# '''
#
# # 带参数的装饰器
#
# def repeat(n):
#     def decorator(func):
#         def wrapper(*args, **kwargs):
#             for _ in range(n):
#                 result = func(*args, **kwargs)
#             return result
#         return wrapper
#     return decorator
#
# @repeat(3)
# def greet(name):
#     print(f"Hello, {name}!")
#
# greet("Alice")
#
# # 高阶函数 ：接受函数作为参数，或者将函数作为返回值的函数
# def add(x,y,f):
#     return f(x)+f(y)
# print(add(5,-6,abs))
#
# # map()一个是函数，一个是Iterable，map将传入的函数依次作用到序列的每个元素，并把结果作为新的Iterator返回。 将一个函数作用于每个元素，形成一个新的Iterator
# r=map(lambda x:x*x,[1,2,3,4,5,6,7,8,9])
# print(list(r))
# # print(r)
# print(str([1,2,3,4,5,6,7,8,9]))
#
# from functools import reduce
# #reduce reduce把一个函数作用在一个序列[x1, x2, x3, ...]上，这个函数必须接收两个参数，reduce把结果继续和序列的下一个元素做累积计算
# print(reduce(lambda x,y:x+y,[1,2,3,4,5,6,7,8,9]))
#
# from functools import reduce
# def fn(x, y):
#     return x * 10 + y
#
# def char2num(s):
#     dights={"0": 0, "1": 1, "2": 2, "3": 3, "4": 4, "5": 5, "6": 6, "7": 7, "8": 8, "9": 9}
#     return dights[s]
#
# print(reduce(fn,map(char2num,'13579')))
#
# dights={"0": 0, "1": 1, "2": 2, "3": 3, "4": 4, "5": 5, "6": 6, "7": 7, "8": 8, "9": 9}
# def char2num(s):
#     return dights[s]
#
# def str2int(s):
#     return reduce(lambda x,y:x*10+y,map(char2num,s))
#
# def normalize(name):
#     # 首字符大写
#     return name[0].upper() + name[1:].lower()
#
# # 测试:
# L1 = ['adam', 'LISA', 'barT']
# L2 = list(map(normalize, L1))
# print(L2)
#
# from functools import reduce
#
# def prod(L):
#     return reduce(lambda x,y:x*y,L)
#
# print('3 * 5 * 7 * 9 =', prod([3, 5, 7, 9]))
# if prod([3, 5, 7, 9]) == 945:
#     print('测试成功!')
# else:
#     print('测试失败!')
#
# from functools import reduce
#
# def str2float(s):
#     dicts= {"0":0,"1":1,"2":2,"3":3,"4":4,"5":5,"6":6,"7":7,"8":8,"9":9,".":-1}
#     nums=map(lambda x:dicts[x],s)
#     point=0
#
#     def to_float(f, n):
#         nonlocal point # 这里是声明nonlocal变量
#         if n==-1:
#             point=1
#             return f
#         if point==0:
#             return f*10+n
#         else:
#             point=point*10
#             return f+n/point
#     return reduce(to_float,nums)
#
# print('str2float(\'123.456\') =', str2float('123.456'))
# if abs(str2float('123.456') - 123.456) < 0.00001:
#     print('测试成功!')
# else:
#     print('测试失败!')
#
# # filter() 函数用于过滤序列，过滤掉不符合条件的元素，返回一个迭代器对象，如果要转换为列表，可以使用 list() 来转换。
# print(list(filter(lambda x:x%2==1,[1,2,3,4,5,6,7,8,9])))
# def is_odd(n):
#     return n%2==1
# print(list(filter(is_odd,[1,2,3,4,5,6,7,8,9])))
# func_=is_odd
# print(list(filter(func_,[1,2,3,4,5,6,7,8,9])))
#
#
# def _odd_iter():
#     n=1
#     while True:
#         n=n+2
#         yield n
#
# def _not_divisible(n):
#     return lambda x:x%n>0
#
# def prims():
#     yield 2
#     it =_odd_iter()
#     print(type(it))
#     while True:
#         n=next(it)
#         yield n
#         it=filter(_not_divisible(n),it)
#
# for n in prims():
#     if n < 100:
#         print(n)
#     else:
#         break
#
#
# def is_palindrome(n):
#     if n<10:
#         return True
#     flag=True
#     str_num=str(n)
#     for i in range(0,len(str_num)//2):
#         if str_num[i]!=str_num[len(str_num)-1-i]:
#             flag=False
#             break
#     return flag
# # 测试:
# output = filter(is_palindrome, range(1, 100))
# print('1~1000:', list(output))
# if list(filter(is_palindrome, range(1, 200))) == [1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99, 101, 111, 121, 131, 141, 151, 161, 171, 181, 191]:
#     print('测试成功!')
# else:
#     print('测试失败!')
#
# list_str=['adam', 'LISA', 'barT']
# print(sorted(list_str,key=str.lower))
# print(list_str)
#
# print(sorted(['bob', 'about', 'Zoo', 'Credit'], key=str.lower, reverse=True))
# from operator import itemgetter
#
# L = ["bob", "about", "Zoo", "Credit"]
#
# print(sorted(L))
# print(sorted(L, key=str.lower))
#
# students = [("Bob", 75), ("Adam", 92), ("Bart", 66), ("Lisa", 88)]
#
# print(sorted(students, key=itemgetter(0)))
# print(sorted(students, key=lambda t: t[1]))
# print(sorted(students, key=itemgetter(1), reverse=True))
#
#
# L = [('Bob', 75), ('Adam', 92), ('Bart', 66), ('Lisa', 88)]
# def by_name(t):
#     return t[0]
# L2 = sorted(L, key=by_name)
# print(L2)
# def by_score(t):
#     return t[1]
# L2 = sorted(L, key=by_score,reverse=True)
# print(L2)
#
# def lazy_sum(*args):
#     def sum():
#         ax = 0
#         for n in args:
#             ax = ax + n
#         return ax
#     return sum
#
# f = lazy_sum(1, 3, 5, 7, 9)
# # print(f)
# print(f())
# # 内部函数sum可以引用外部函数lazy_sum的参数和局部变量，当lazy_sum返回函数sum时，相关参数和变量都保存在返回的函数中，这种称为“闭包（Closure）”的程序结构
#
# def count():
#     fs = []
#     for i in range(1, 4):
#         def f():
#              return i*i
#         fs.append(f)
#     return fs
#
# f1, f2, f3 = count()
# print(f1(), f2(), f3())
# # 返回闭包时牢记一点：返回函数不要引用任何循环变量，或者后续会发生变化的变量。
# # 如果一定要引用循环变量怎么办？方法是再创建一个函数，用该函数的参数绑定循环变量当前的值，无论该循环变量后续如何更改，已绑定到函数参数的值不变
# def count():
#     def f(j):
#         def g():
#             return j*j
#         return g
#     fs = []
#     for i in range(1, 4):
#         fs.append(f(i)) # f(i)立刻被执行，因此i的当前值被传入f()
#     return fs
#
# f1, f2, f3 = count()
# print(f1(), f2(), f3())
#
# def inc():
#     x = 0
#     def fn():
#         nonlocal x
#         x = x + 1
#         return x
#     return fn
#
# f = inc()
# print(f()) # 1
# print(f()) # 2
#
# def createCounter():
#     n = 0
#     def counter():
#         nonlocal n
#         n = n + 1
#         return n
#     return counter
#
# # 测试:
# counterA = createCounter()
# print(counterA(), counterA(), counterA(), counterA(), counterA()) # 1 2 3 4 5
# counterB = createCounter()
# if [counterB(), counterB(), counterB(), counterB()] == [1, 2, 3, 4]:
#     print('测试通过!')
# else:
#     print('测试失败!')
#
# def is_odd(n):
#     return n % 2 == 1
#
# L = list(filter(is_odd, range(1, 20)))
# print(L)
# L =list(filter(lambda x:x%2==1,range(1,20)))
# print(L)
#
# print(is_odd.__name__)
#
# # 装饰器 传入的是函数参数，返回的是函数 而且一般添加功能，所以本函数的调用方法一般不变
# # 借助@将定义的装饰器至于函数定义处
#
# def lgo(func):
#     def wrappper(*args,**kw):
#         print("call %s():" % func.__name__)
#         return func(*args,**kw)
#     return wrappper
# @lgo
# def now():
#     print("2025-01-02")
#
#
# now()
#
# # 将@lgo 放到函数的定义位置，相当于调用了now=lgo(now)
#
# def now_():
#     print("2025-01564f65ads4f65a-02")
# now_()
# now_=lgo(now_)
# now_()
#
# # 如果decorator本身需要传入参数，那就需要编写一个返回decorator的高阶函数，写出来会更复杂。比如，要自定义log的文本：
# def log(text):
#     def decorator(func):
#         def wrapper(*args,**kw):
#             print("%s %s():" % (text, func.__name__))
#             return func(*args,**kw)
#         return wrapper
#     return decorator
#
# @log("execu")
# def now():
#     print("2025-01-02")
# now()
# print("适配之后的函数名："+now.__name__)
# print()
# # 3层的嵌套效果
# def now_():
#     print("2025-01-0/*/*/*/*/*2")
# now_1 = log("execute")(now_)
# now_1()
#
# # 最后修改函数签名信息内置的functools.wraps就是干这个事的
# import functools
# def log(func):
#     @functools.wraps(func)
#     def wrapper(*args,**kw):
#         print("call %s():" % func.__name__)
#         return func(*args,**kw)
#     return wrapper
#
# # 或者带参decorator
# import functools
# def log(text):
#     def decorator(func):
#         @functools.wraps(func)
#         def wrapper(*args,**kw):
#             print("%s %s():" % (text, func.__name__))
#             return func(*args,**kw)
#         return wrapper
#     return decorator
#
# @log("execute")
# def now():
#     print("2025-01-02")
# now()
# print("适配之后的函数名："+now.__name__)
#
# import time, functools
#
# def metric(func):
#     @functools.wraps(func)
#     def wrapper(*args,**kw):
#         start = time.time()
#         ret = func(*args,**kw)
#         end = time.time()
#         print('%s executed in %s ms' % (fn.__name__, end-start))
#         return ret
#     return wrapper
#
# def log(func):
#     @functools.wraps(func)
#     def wrapper(*args,**kw):
#         print("begin call")
#         return func(*args,**kw)
#     return wrapper
#
# # 测试
# @metric
# def fast(x, y):
#     time.sleep(0.0012)
#     return x + y
#
# @metric
# def slow(x, y, z):
#     time.sleep(0.1234)
#     return x * y * z
#
# f = fast(11, 22)
# s = slow(11, 22, 33)
# if f != 33:
#     print('测试失败!')
# elif s != 7986:
#     print('测试失败!')
#
# def log(text=None):
#     def decorator(func):
#         @functools.wraps(func) # 保证函数名称不变
#         def wrapper(*args,**kw):
#             print("begin call")
#             result=func(*args,**kw)
#             print("end call")
#             return result
#         return wrapper
#     if callable(text): # 作为@log()使用的装饰器
#         return decorator(text)
#     # 如果作为@log('message')使用
#     return decorator
#
# @log
# def f1():
#     print("Function f1 is called")
#
# @log('execute')
# def f2():
#     print("Function f2 is called")
#
# # 使用示例
# f1()
# f2()
#
# # 偏函数 把一个函数的某些参数给固定住了，返回一个新的函数，调用这个新函数会更简单
# ## 提出
# def int2(x, base=2):
#     return int(x, base) # 一个转换2进制的函数
# #functools.partial就是帮助我们创建一个偏函数的，不需要我们自己定义int2()，可以直接使用下面的代码创建一个新的函数int2
# import functools
# int2=functools.partial(int,base=2)
# print(int2("1000000"))
# #也可以在函数调用时传入其他值：
# print(int2("1000000",base=10))
#
# #最后，创建偏函数时，实际上可以接收函数对象、*args和**kw这3个参数，当传入：
# int2 = functools.partial(int, base=2)
# # 实际上固定了int()函数的关键字参数base，也就是：
# int2('10010')
# # 相当于：
# kw = { 'base': 2 }
# int('10010', **kw)
#
# max2=functools.partial(max,10)
# # 实际上会把10作为*args的一部分自动加到左边，也就是：即
# max2(5, 6, 7)
# # 相当于：
# args = (10, 5, 6, 7)
# max(*args)
#
# stack=[]
#
# stack.append(1)
# stack.append(2)
# stack.append(3)
# print(stack)
# top_elem=stack.pop()
# print(top_elem)
# print(stack)
# top_elem=stack[-1]
# print(top_elem)
# print(len(stack))
#
# class Stack:
#     def __init__(self):
#         self.stack = []
#
#     def push(self, item):
#         self.stack.append(item)
#
#     def pop(self):
#         if not self.is_empty():
#             return self.stack.pop()
#         else:
#             raise IndexError("pop from empty stack")
#
#     def peek(self):
#         if not self.is_empty():
#             return self.stack[-1]
#         else:
#             raise IndexError("peek from empty stack")
#
#     def is_empty(self):
#         return len(self.stack) == 0
#
#     def size(self):
#         return len(self.stack)
#
# # 使用示例
# stack = Stack()
# stack.push(1)
# stack.push(2)
# stack.push(3)
#
# print("栈顶元素:", stack.peek())  # 输出: 栈顶元素: 3
# print("栈大小:", stack.size())    # 输出: 栈大小: 3
#
# print("弹出元素:", stack.pop())  # 输出: 弹出元素: 3
# print("栈是否为空:", stack.is_empty())  # 输出: 栈是否为空: False
# print("栈大小:", stack.size())    # 输出:
# from collections import deque
#
# # 创建一个空队列
# queue = deque()
#
# # 向队尾添加元素
# queue.append('a')
# queue.append('b')
# queue.append('c')
#
# print("队列状态:", queue)  # 输出: 队列状态: deque(['a', 'b', 'c'])
# # 从队首移除元素
# first_element = queue.popleft()
# print("移除的元素:", first_element)  # 输出: 移除的元素: a
# print("队列状态:", queue)            # 输出: 队列状态: deque(['b', 'c'])
#
# # 查看队首元素（不移除）
# front_element = queue[0]
# print("队首元素:", front_element)    # 输出: 队首元素: b
#
# # 检查队列是否为空
# is_empty = len(queue) == 0
# print("队列是否为空:", is_empty)     # 输出: 队列是否为空: False
#
# # 获取队列大小
# size = len(queue)
# print("队列大小:", size)            # 输出: 队列大小: 2
#
# print([str(round(355/113, i)) for i in range(1, 20)])
#
# matrix = [
#     [1, 2, 3,4],
#     [5, 6, 7,8],
#     [9,10,11,12]
# ]
# print([[row[i] for row in matrix] for i in range(4)])
#
# transposed=[]
# for i in range(4):
#     transposed_row=[]
#     for row in matrix:
#         transposed_row.append(row[i])
#     transposed.append(transposed_row)
# print(transposed)
#
# for i, v in enumerate(['tic', 'tac', 'toe']):
#     print(i, v)
#
# questions = ['name', 'quest', 'favorite color']
# answers = ['lancelot', 'the holy grail', 'blue']
# for q,a in zip(questions, answers):
#     print(f"What is your {q}? It is {a}.")
#
# for i in reversed(range(len(questions))):
#     print(i, questions[i])
# basket = ['apple', 'orange', 'apple', 'pear', 'orange', 'banana']
# # for f in sorted(set(basket)):
# #     print(f)
#
# print(sorted(basket))
# print(basket)
#
# # !/usr/bin/python3
# # 文件名: using_sys.py
#
# import sys
#
# print('命令行参数如下:')
# for i in sys.argv:
#     print(i)
#
# print('\n\nPython 路径为：', sys.path, '\n')
# print(list(sys.path))
#
# #!/usr/bin/python3
# # Filename: using_name.py
#
# def test():
#     args = sys.argv
#     if len(args) == 1:
#         print('Hello, world!')
#     elif len(args) == 2:
#         print('Hello, %s!' % args[1])
#     else:
#         print('Too many arguments!')
#
# if __name__ == '__main__':
#    print('程序自身在运行')
#    test()
# else:
#    print('我来自另一模块')
#
# for i in range(1, 11):
#     print(f"{i:0>2d} {i*i:x<3d} {i*i*i:+>4d}")
#
# print('{name}网址： {site}'.format(name='菜鸟教程', site='www.runoob.com'))
# print("站点列表 {0} {1} ,和 {other}".format("google","runoob.com",other="taobao.com"))
# # !a (使用 ascii()), !s (使用 str()) 和 !r (使用 repr()) 可以用于在格式化某个值之前对其进行转化:
# import math
# print("Π的值为{!r}\n {!s}".format(math.pi, str(math.pi)))
#
# table = {'Google': 1, 'Runoob': 2, 'Taobao': 3}
# print('Runoob: {0[Runoob]:d}; Google: {0[Google]:d}; Taobao: {0[Taobao]:d}'.format(table))
#
# table = {'Google': 1, 'Runoob': 2, 'Taobao': 3}
# print('Runoob: %d; Google: %d; Taobao: %d' % (table['Runoob'], table['Google'], table['Taobao']))
#
# # str = input("请输入：")
# # print ("你输入的内容是: ", str)
#
# # f=open("./test.txt","w")
# # f.write("Hello, world!\n woshinidie\n 上班还得卷")
# # f.close()
# f=open("./test.txt","w")
# value=("runoob \r\n runoob.com \n runoob.org \n",15,"abc")
# s=str(value)
# f.write(s)
# f.close()
#
# f=open("./test.txt","r")
# str_1=f.read()
# print(str_1)
# f.close()
#
# f=open("./test.txt","r")
# str_2=f.readlines()
# print(str_2)
# f.close()
#
# with open('./test.txt','r') as f:
#     print(f.read())
# f.close()
#
# '''
# python的pickle模块实现了基本的数据序列和反序列化。
# 通过pickle模块的序列化操作我们能够将程序中运行的对象信息保存到文件中去，永久存储。
# 通过pickle模块的反序列化操作，我们能够从文件中创建上一次程序保存的对象。
# '''
# import pickle
# # 使用pickle模块将数据对象保存到文件
# data1={"a":[1,2.0,3,4+6j],"b":('string','Unicode string'),"c":None}
# selfref_list=[1,2,3]
# selfref_list.append(selfref_list)
#
# print(selfref_list,"*-*-*-*-*-*-*-*-*-")
#
# output = open('data.pkl', 'wb')
# pickle.dump(data1, output)
# pickle.dump(selfref_list, output, -1)
# output.close()
#
# # 使用pickle模块从文件中重构python对象
# pkl_file=open("data.pkl", "rb")
# data1=pickle.load(pkl_file)
#
# pprint.pprint(data1)
#
# data2=pickle.load(pkl_file)
# pprint.pprint(data2)
# pkl_file.close()
#
# # fo = open("test.txt", "r+")
# # print ("文件名: ", fo.name)
# #
# # line = fo.readline()
# # print ("读取行: %s" % (line.strip()))
# # print("当前文件指针位置：", fo.tell())
# #
# # fo.truncate(fo.tell())
# # fo.seek(0)
# # line = fo.readlines()
# # print ("读取行: %s" % (line))
# #
# # # 关闭文件
# # fo.close()
# #
# # # 打开文件
# # fo = open("test.txt", "r+")
# # print ("文件名: ", fo.name)
# #
# # str = "6:www.runoob.com"
# # # 在文件末尾写入一行
# # fo.seek(0, 2)
# # line = fo.write( str )
# #
# # # 读取文件所有内容
# # fo.seek(0,0)
# # for index in range(6):
# #     line = next(fo)
# #     print ("文件行号 %d - %s" % (index, line))
# #
# # # 关闭文件
# # fo.close()
# #
# # with open("test.txt","r+") as fo:
# #     print("name:", fo.name)
# #     seq=["hahah\n","woshinidie"]
# #     fo.writelines(seq)
# #     fo.close()
#
# try:
#     print('try...')
#     r = 10 / 0
#     print('result:', r)
# except ZeroDivisionError as e:
#     print('except:', e)
# finally:
#     print('finally...')
# print('END')
#
# # x = 10
# # if x > 5:
# #     raise Exception('x 不能大于 5。x 的值为: {}'.format(x))
#
#
# # import logging
# # def foo(s):
# #     return 10 / int(s)
# # def bar(s):
# #     return foo(s) * 2
# # def main():
# #     try:
# #         bar('0')
# #     except Exception as e:
# #         logging.exception(e)
# # main()
# # print('END')
#
# # try:
# #     raise NameError('HiThere')
# # except NameError:
# #     print("一个异常抛出了")
# #     raise
#
# # class MyError(Exception):
# #     def __init__(self,value):
# #         self.value = value
# #     def __str__(self):
# #         return repr(self.value)
# #
# # try:
# #     raise MyError(2*2)
# # except MyError as e:
# #     print('My exception occurred, value:', e.value)
#
#
# from functools import reduce
#
# def str2num(s):
#     if "." not in s:
#         return int(s)
#     return float(s)
#
# def calc(exp):
#     ss = exp.split('+')
#     ns = map(str2num, ss)
#     return reduce(lambda acc, x: acc + x, ns)
#
# def main():
#     r = calc('100 + 200 + 345')
#     print('100 + 200 + 345 =', r)
#     r = calc('99 + 88 + 7.6')
#     print('99 + 88 + 7.6 =', r)
#
# main()
#
# with open("test.txt","r") as f:
#     print(f.read())
#
# print(f.closed)
#
# from random import shuffle
# try:
#     with open("city.txt","r",encoding="utf-8") as f:
#         i=[line for line in f if line[0].isdigit()]
# except FileNotFoundError:
#     print("文件不存在,请检查文件名")
#     exit()
#
# # travlist=[]
# # print(i)
# # # 添加旅游城市
# # for index,value in enumerate(i):
# #     temp_1=value.strip()[2:] # 去除行么的换行符并且截取城市名
# #     temp_1=f"{index}#{temp_1}"
# #     travlist.append(temp_1)
# #
# # print("旅游城市列表：",travlist)
# # # 删除旅游的城市
# # city_num=input("请输入要删除的城市个数：")
# # try:
# #     for _ in range(0,int(city_num)):
# #         index=int(input("输入不想旅游城市的序号（第1个城市索引为0）"))
# #         if index>=0 and index<len(travlist):
# #             travlist.pop(index)
# #             print("删除城市成功,旅游计划城市现在为：",travlist)
# #         else:
# #             print("输入的城市序号有误")
# #     city_num=int(city_num)
# # except ValueError:
# #     print("请输入有效的整数")
# #
# # # 修改旅游城市
# # city_num=input("请输入要修改的城市个数：")
# # try:
# #     for _ in range(0,int(city_num)):
# #         index=int(input("输入要修改的城市序号（第1个城市索引为0）"))
# #         if index>=0 and index<= len(travlist):
# #             city_name=input("请输入新的城市名：")
# #             travlist[index]=f"{index}#{city_name}"
# #             print("旅游计划城市现在为：",travlist)
# #
# #         else:
# #             print("输入的城市序号有误,超出范围")
# # except ValueError:
# #     print("请输入有效的整数")
# #
# # shuffle(travlist)
# # print("最终的旅游计划城市为：",travlist[0:5])
#
# class MyComplex:
#     r=0
#     i=0
#     __weigth__=0
#     def __init__(self, realpart, imagpart,w):
#         self.r = realpart
#         self.i = imagpart
#         self.__weigth__=w
#     def prrt(self):
#         print(self.r,self.i)
#         print(self)
#         print(self.__class__)
#     def speak(self):
#         print("%s 说： 我 %d 岁。"%(self.r,self.__weigth__))
# x=MyComplex(3.0,-4.5,15)
# print(x.r,x.i)
# x.prrt()
# x.speak()
#
# class FlexibleClass:
#     def __init__(self, name):
#         self.name = name  # 所有实例都会初始化 'name' 变量
#
# # 创建两个实例
# obj1 = FlexibleClass("Object 1")
# obj2 = FlexibleClass("Object 2")
#
# # 动态绑定变量
# obj1.age = 25  # 只为 obj1 绑定了 'age'
# obj2.city = "New York"  # 只为 obj2 绑定了 'city'
#
# # 动态访问变量
# print(f"{obj1.name} is {obj1.age} years old.")  # 访问 obj1 的动态变量
# print(f"{obj2.name} lives in {obj2.city}.")  # 访问 obj2 的动态变量
#
# # 尝试访问不存在的变量（会引发 AttributeError）
# try:
#     print(obj1.city)
# except AttributeError as e:
#     print(f"Error: {e}")
#
# try:
#     print(obj2.age)
# except AttributeError as e:
#     print(f"Error: {e}")
#
# class Student(object):
#     def __init__(self, name, gender):
#         self.name = name
#         self.__gender = gender
#     def get_gender(self):
#         return self.__gender
#
#     def set_gender(self,gender):
#         if not isinstance(gender,str):
#             print("参数不对啊")
#         else:
#             self.__gender=gender
#
# # 测试:
# bart = Student('Bart', 'male')
# bart.set_gender(12)
# if bart.get_gender() != 'male':
#     print('测试失败!')
# else:
#     bart.set_gender('female')
#     if bart.get_gender() != 'female':
#         print('测试失败!')
#     else:
#         print('测试成功!')
#
#
# # !/usr/bin/python3
#
# # 类定义
# class people:
#     # 定义基本属性
#     name = ''
#     age = 0
#     # 定义私有属性,私有属性在类外部无法直接进行访问
#     __weight = 0
#
#     # 定义构造方法
#     def __init__(self, n, a, w):
#         self.name = n
#         self.age = a
#         self.__weight = w
#
#     def speak(self):
#         print("%s 说: 我 %d 岁。" % (self.name, self.age))
#
#
# # 单继承示例
# class student(people):
#     grade = ''
#
#     def __init__(self, n, a, w, g):
#         # 调用父类的构函
#         people.__init__(self, n, a, w)
#         self.grade = g
#
#     # 覆写父类的方法
#     def speak(self):
#         print("%s 说: 我 %d 岁了，我在读 %d 年级" % (self.name, self.age, self.grade))
#
#
# s = student('ken', 10, 60, 3)
# s.speak()
#
# class speaker():
#     topic=""
#     name=""
#     def __init__(self,n,t):
#         self.name=n
#         self.topic=t
#     def speak(self):
#         print("我叫 %s，我是一个演说家，我演讲的主题是 %s"%(self.name,self.topic))
#
# class sample(speaker,student):
#     a=""
#     def __init__(self,n,a,w,g,t):
#         student.__init__(self,n,a,w,g)
#         speaker.__init__(self,n,t)
#
# test = sample("Tim",25,80,4,"Python")
# test.speak()   #方法名同，默认调用的是在括号中参数位置排前父类的方法
#
# class Parent:  # 定义父类
#     def myMethod(self):
#         print('调用父类方法')
#
# class Child(Parent):  # 定义子类
#     def myMethod(self):
#         print('调用子类方法')
# c = Child()  # 子类实例
# c.myMethod()  # 子类调用重写方法
# super(Child, c).myMethod()  # 用子类对象调用父类已被覆盖的方法
#
#
# # !/usr/bin/python
# # -*- coding: UTF-8 -*-
#
# class FooParent(object):
#     def __init__(self):
#         self.parent = 'I\'m the parent.'
#         print('Parent')
#
#     def bar(self, message):
#         print("%s from Parent" % message)
#
#
# class FooChild(FooParent):
#     def __init__(self):
#         # super(FooChild,self) 首先找到 FooChild 的父类（就是类 FooParent），然后把类 FooChild 的对象转换为类 FooParent 的对象
#         super(FooChild, self).__init__()
#         print('Child')
#
#     def bar(self, message):
#         FooParent.bar(self,message)
#         print('Child bar fuction')
#         print(self.parent)
#
#
# if __name__ == '__main__':
#     fooChild = FooChild()
#     fooChild.bar('HelloWorld')
#
# class Vector:
#     def __init__(self, a, b):
#         self.a = a
#         self.b = b
#
#     def __str__(self):
#         return 'Vector (%d, %d)' % (self.a, self.b)
#
#     def __add__(self, other):
#         return Vector(self.a + other.a, self.b + other.b)
#
#
# v1 = Vector(2, 10)
# v2 = Vector(5, -2)
# print(v1 + v2)
# print(dir(v1))
# import builtins
# print(dir(builtins))
#
# print("当前模块的名称：", __name__)
# print("当前工作目录",os.getcwd())
# files=os.listdir(os.getcwd())
# print("当前目录下的文件：",files)
# import shutil
# shutil.copyfile('city.txt', 'city_1.txt')
# # shutil.move('/build/executables', 'installdir')
# import glob
# print(glob.glob('*.txt'))
# import random
# print(random.choice(['apple', 'pear', 'banana']))
# print(random.sample(range(100), 10))
# print(random.random())
# print(random.randrange(9))
#
# import datetime
#
# #获取当前日期和时间
# current_datetime = datetime.datetime.now()
# print(current_datetime)
#
# # 获取当前日期
# current_date = datetime.date.today()
# print(current_date)
#
# # 格式化日期
# formatted_datetime = current_datetime.strftime("%Y-%m-%d %H:%M:%S")
# print(formatted_datetime)  # 输出：2023-07-17 15:30:45
#
# birthday = datetime.date(1998, 7, 22)
# age=datetime.date.today()-birthday
# print(age.days)
#
# a=1
# b=2
# temp=(a,b)
# b,a=temp
# print(a,b)
# from timeit import Timer
# t1=Timer('t=a; a=b; b=t', 'a=1; b=2').timeit()
# t2=Timer('a,b = b,a', 'a=1; b=2').timeit()
# print(t1,t2)
#
# class Animal(object):
#     a=0
#     b=""
#     c=[]
#     d={}
#     e=set()
#     f=()
#     def run(self):
#         print('Animal is running...')
#     def __len__(self):
#         return 100
# mao=Animal()
# print(hasattr(mao,'a'))
# print(hasattr(mao,'g'))
# for i in dir(mao):
#     print(type(getattr(mao,i))) # 获取属性，不存在抛出错误或者可以 getattr(mao,"z",None) 返回默认值
#
# setattr(mao,"a",15)
# print(getattr(mao,"a"))
# def run_twice(animal):
#     animal.run()
#
# class Timer(object):
#     def run(self):
#         print("Timer is running")
#
# run_twice(Timer())
# run_twice(Animal())
#
# print(len("abc"))
# print(len(Animal()))
#
# class Student(object):
#     count = 0
#
#     def __init__(self, name):
#         self.name = name
#         Student.count += 1
# def print_student(name):
#     print('Student', name)
#     print(Student.count)
# # 测试:
#
# if Student.count != 0:
#     print('测试失败1!')
# else:
#     print(Student.count)
#     bart = Student('Bart')
#     if Student.count != 1:
#         print('测试失败2!')
#         print_student(bart)
#     else:
#         lisa = Student('Bart')
#         if Student.count != 2:
#             print('测试失败3!')
#             print_student(lisa)
#         else:
#             print('Students:', Student.count)
#             print('测试通过!')
#
# class Student(object):
#     pass
# s=Student()
# s.name="Bart" # 动态给实例绑定一个属性
# def set_age(self, age): # 定义一个函数作为实例方法
#     self.age=age
# from types import MethodType
# s.set_age=MethodType(set_age,s) # 给实例绑定一个方法
# s.set_age(25) # 调用实例方法
# # 但是给一个实例绑定的方法，对另一个实例是不起作用的：
# s2=Student() # 创建新的实例
# # s2.set_age(25) # 尝试调用方法 会报错
# # 为了给所有实例都绑定方法，可以给class绑定方法：
# Student.set_age=set_age # 给class绑定方法后，所有实例均可调用
#
# # 我们在对实例属性操作的时候，就知道该属性很可能不是直接暴露的，而是通过getter和setter方法来实现的。
#
class Student(object):
    def __init__(self,sc,bir):
        self._score=sc
        self._birth=bir
    @property
    def score(self):
        return self._score
    @score.setter
    def score(self,value):
        if not isinstance(value,int):
            raise ValueError('score must be an integer')
        if value <0 or value >100:
            raise ValueError('score must between 0~100!')
        self._score = value
    @property
    def age(self):
        return 2015-self._birth
# @property把一个getter方法变成了属性的的调用，本身又会创建另外一个装饰器@score.setter，负责把一个setter方法变成属性赋值，于是，我们就拥有一个可控的属性操作：
s=Student(90,2000)
s.score=60 # OK，实际转化为s.set_score(60)
print(s.score) # OK，实际转化为s.get_score()
# 定义制度属性的话，就是用@property，定义可读写属性的话，就是用@property和@score.setter。

class Screen(object):
    @property
    def width(self):
        return self._width
    @width.setter
    def width(self,value):
        self._width=value
    @property
    def height(self):
        return self._height
    @height.setter
    def height(self,value):
        self._height=value
    @property
    def resolution(self):
        return self.width * self.height


# 测试:
s = Screen()
s.width = 1024
s.height = 768
print('resolution =', s.resolution)
if s.resolution == 786432:
    print('测试通过!')
else:
    print('测试失败!')

class Student(object):
     def __init__(self, name):
         self.name = name
     def __str__(self):
         return 'Student object (name: %s)' % (self.name)

print(Student('Michael'))

class Fib(object):
   def __init__(self):
      self.a, self.b = 0, 1 # 初始化两个计数器a，b
   def __iter__(self):
      return self # 实例本身就是迭代对象，故返回自己
   def __next__(self):
      self.a,self.b=self.b,self.a+self.b # 计算下一个值
      if self.a > 10000: # 退出循环的条件
         raise StopIteration()
      return self.a # 返回下一个值
   def __getitem__(self,n):
       if isinstance(n,int): # n是索引
          a,b=1,1
          for x in range(n):
             a,b=b,a+b
          return a
       if isinstance(n,slice): # n是切片
          start =n.start
          stop=n.stop
          if start is None:
              start=0
          a,b,=1,1
          L=[]
          for x in range(start,stop):
              if x>=start:
                  L.append(a)
              a,b=b,a+b
          return L
   def __getattr__(self,attr):
       return "no "
f= Fib()
print(next(f))
print(next(f))
print(next(f))
print(f[0])
print(f[:7])
print(f.abc)

class Chain(object):
    def __init__(self,path=""):
        self._path=path
    def __getattr__(self,path):
        return Chain("%s%s" % (self._path,path))
    def __str__(self):
        return self._path
    __repr__=__str__
    def __call__(self,value):
        print("说的是：%s" % (value))

class Student(object):
    def __init__(self, name):
        self.name = name
    def __call__(self):
        print('My name is %s.' % self.name)
s = Student('Michael')
s() # self参数不要传入
print(callable(Student("haha")))
print(callable(max))
print(callable([]))
Chain()("dsfa")
print(hasattr(s,"__members__"))

# 枚举类型
from enum import Enum,unique
Month=Enum("Month",("January","February","March","April","May","June","July","August","September","October","November","December"))
for name,member in Month.__members__.items():
    print(name,"=>",member,",",member.value)

@unique # unique装饰器可以帮助我们检查保证没有重复值
class Weekday(Enum):
    Sunday=0
    Monday=1
    Tuesday=2
    Wednesday=3
    Thursday=4
    Friday=5
    Saturday=6

for day,value in Weekday.__members__.items():
    print(day, "==>",value)
day1=Weekday.Monday
print(day1)
print(Weekday.Tuesday)
print(Weekday["Tuesday"])
print(Weekday.Tuesday.value)
print(day1 == Weekday.Monday)
print(Weekday(3))

from enum import Enum, unique
Gender=Enum("Gender",("Male","Female"))
@unique
class Gender(Enum):
    Male = 0
    Female = 1

class Student(object):
    def __init__(self, name, gender):
        self.name = name
        if isinstance(gender,Gender):
            self.gender = gender
        elif isinstance(gender,int):
            self.gender=Gender(gender)
        elif isinstance(gender,str):
            self.gender=Gender[gender]
        else:
            raise ValueError("gender must be a Gender or int or str")

# 创建一个学生实例，性别为枚举成员 Gender.Male
bart = Student('Bart', Gender.Male)
print(bart.name)        # 输出: Bart
print(bart.gender)      # 输出: Gender.Male
print(bart.gender.name) # 输出: Male (枚举成员的名字)
print(bart.gender.value) # 输出: 0 (枚举成员的值)

# 测试字符串形式的性别输入
lisa = Student('Lisa', 'Female')  # Gender['Female']
print(lisa.gender)  # 输出: Gender.Female

# 测试整数形式的性别输入
tom = Student('Tom', 1)  # Gender(1)
print(tom.gender)  # 输出: Gender.Female

# 测试无效的性别输入
try:
    invalid = Student('Invalid', 3)  # 3 不是有效的 Gender 值
except ValueError as e:
    print(e)  # 输出: Invalid gender

# import logging
# logging.basicConfig(level=logging.INFO)
# import pdb
# s="0"
# n=int(s)
# # logging.info("n = %d"%n)
# pdb.set_trace()
# print(10/n)


# 单元测试 以自定义的Dict类为例
class Dict(dict):
    def __Init__(self,**kw):
        super().__init__(**kw)
    def __getattr__(self,key):
        try:
            return self[key]
        except KeyError as e:
            raise AttributeError(r"'Dict' object has no attribute '%s'" % key)
    def __setattr__(self,key,value):
        self[key]=value
# # 1引入unittest模块
# # 需要编写一个测试类，从unittest.TestCase继承。以test开头的方法就是测试方法，不以test开头的方法不被认为是测试方法，测试的时候不会被执行。
# import unittest
#
# class TestDict(unittest.TestCase):
#     def setUp(self):
#         print('setUp...')
#
#     def tearDown(self):
#         print('tearDown...')
#     def test_init(self):
#         d = Dict(a=1, b='test')
#         self.assertEqual(d.a, 1)
#         self.assertEqual(d.b, 'test') # 期待相等
#         self.assertTrue(isinstance(d, dict))
#
#     def test_key(self):
#         d = Dict()
#         d['key'] = 'value'
#         self.assertEqual(d.key, 'value')
#
#     def test_attr(self):
#         d = Dict()
#         d.key = 'value'
#         self.assertTrue('key' in d)
#         self.assertEqual(d['key'], 'value')
#
#     def test_keyerror(self):
#         d = Dict()
#         with self.assertRaises(KeyError): # 期待抛出KeyError异常
#             value = d['empty']
#
#     def test_attrerror(self):
#         d = Dict()
#         with self.assertRaises(AttributeError):
#             value = d.empty
#
# if __name__=='__main__':
#     unittest.main()
# else:
#     unittest.main()


# import unittest
#
# class Student(object):
#     def __init__(self, name, score):
#         self.name = name
#         self.score = score
#     def get_grade(self):
#         if self.score>100 or self.score<0:
#             raise ValueError
#         if self.score >= 80:
#             return 'A'
#         if self.score >= 60:
#             return 'B'
#         return 'C'
#
# class TestStudent(unittest.TestCase):
#
#     def test_80_to_100(self):
#         s1 = Student('Bart', 80)
#         s2 = Student('Lisa', 100)
#         self.assertEqual(s1.get_grade(), 'A')
#         self.assertEqual(s2.get_grade(), 'A')
#
#     def test_60_to_80(self):
#         s1 = Student('Bart', 60)
#         s2 = Student('Lisa', 79)
#         self.assertEqual(s1.get_grade(), 'B')
#         self.assertEqual(s2.get_grade(), 'B')
#
#     def test_0_to_60(self):
#         s1 = Student('Bart', 0)
#         s2 = Student('Lisa', 59)
#         self.assertEqual(s1.get_grade(), 'C')
#         self.assertEqual(s2.get_grade(), 'C')
#
#     def test_invalid(self):
#         s1 = Student('Bart', -1)
#         s2 = Student('Lisa', 101)
#         with self.assertRaises(ValueError):
#             s1.get_grade()
#         with self.assertRaises(ValueError):
#             s2.get_grade()
#
# if __name__ == '__main__':
#     unittest.main()

# # mydict2.py
# class Dict(dict):
#     '''
#     Simple dict but also support access as x.y style.
#
#     >>> d1 = Dict()
#     >>> d1['x'] = 100
#     >>> d1.x
#     100
#     >>> d1.y = 200
#     >>> d1['y']
#     200
#     >>> d2 = Dict(a=1, b=2, c='3')
#     >>> d2.c
#     '3'
#     >>> d2['empty']
#     Traceback (most recent call last):
#         ...
#     KeyError: 'empty'
#     >>> d2.empty
#     Traceback (most recent call last):
#         ...
#     AttributeError: 'Dict' object has no attribute 'empty'
#     '''
#     def __init__(self, **kw):
#         super(Dict, self).__init__(**kw)
#
#     def __getattr__(self, key):
#         try:
#             return self[key]
#         except KeyError:
#             raise AttributeError(r"'Dict' object has no attribute '%s'" % key)
#
#     def __setattr__(self, key, value):
#         self[key] = value
#
# if __name__=='__main__':
#     import doctest
#     doctest.testmod()

# def fact(n):
#     '''
#     Calculate 1*2*...*n
#
#     >>> fact(1)
#     1
#     >>> fact(10)
#     3628800
#     >>> fact(-1)
#     Traceback (most recent call last):
#         ...
#     ValueError
#     '''
#     if n < 1:
#         raise ValueError()
#     if n == 1:
#         return 1
#     return n * fact(n - 1)
#
#
# if __name__ == '__main__':
#     import doctest
#
#     doctest.testmod()
#
# from io import StringIO
# f=StringIO()
# print(f.write('hello'))
# print(f.write(" "))
# print(f.write("world!"))
# print(f.getvalue())
#
# f1=StringIO("Hello!\nHi!\nGoodbye!")
# while True:
#     s=f1.readline()
#     if s=='':
#         break
#     print(s.strip())
# from io import BytesIO
# f=BytesIO()
# f.write("中文".encode("utf-8"))
# print(f.getvalue())
#
# f = BytesIO(b'\xe4\xb8\xad\xe6\x96\x87')
# s=f.read()
# print(s)
#
# import os
# nowpath=os.path.abspath('.')#获取当前路径
# list_path=[x for x in os.listdir(nowpath) ]
# for x in list_path:
#     print(x)
#

import os
import datetime
import stat
import time


def Get_File_Permissions(mode):
    permissions=["-"]*10
    if stat.S_ISDIR(mode):
        permissions[0]="d"
    if mode & stat.S_IRUSR:
        permissions[1]="r"
    if mode & stat.S_IWUSR:
        permissions[2]="w"
    if mode & stat.S_IXUSR:
        permissions[3]="x"
    if mode & stat.S_IRGRP:
        permissions[4] = 'r'
    if mode & stat.S_IWGRP:
        permissions[5] = 'w'
    if mode & stat.S_IXGRP:
        permissions[6] = 'x'
    if mode & stat.S_IROTH:
        permissions[7] = 'r'
    if mode & stat.S_IWOTH:
        permissions[8] = 'w'
    if mode & stat.S_IXOTH:
        permissions[9] = 'x'
    return "".join(permissions)

def dir_l(path="."):
    for i in os.listdir(path):
        ls_l=tuple()
        Abs_Path=os.path.abspath(i) # 获取绝对路径
        file_info=os.stat(Abs_Path) # 获取文件信息
        file_mode=file_info.st_mode # 获取文件权限
        # print(file_info)
        permissions=Get_File_Permissions(file_mode)
        file_time=file_info.st_mtime
        print(f"{permissions} {file_info.st_nlink:2} {file_info.st_uid:2} {file_info.st_gid:2} {file_info.st_size:6} {time.strftime('%Y/%m/%d %H:%M', time.localtime(file_time))} {i}")

dir_l()


def print_file_wei(path=".",houzhui=".py"):
    for i in os.listdir(path):
        full_path=os.path.join(path,i) # 构建完整路径
        if os.path.isfile(full_path) and houzhui in i:
            print(os.path.relpath(full_path,"."))  #使用 os.path.relpath() 将路径转化为相对于当前工作目录的相对路径。
        elif os.path.isdir(full_path):
            print_file_wei(full_path,houzhui)

print_file_wei("D:\\weekone",".txt")

# 把变量从内存中变成可存储或传输的过程称之为序列化，在Python中叫pickling，序列化之后，就可以把序列化后的内容写入磁盘，或者通过网络传输到别的机器上。 反过来，把变量内容从序列化的对象重新读到内存里称之为反序列化，即unpickling。
import pickle
d=dict(name="Bob",age=20,score=88)
# pickle.dumps(d)
# 把任意对象序列化成一个bytes，然后，就可以把这个bytes写入文件。或者用另一个方法pickle.dump()直接把对象序列化后写入一个file-like Object：
# with open("dump.txt","wb") as f:
#     pickle.dump(d,f)
# 当我们要把对象从磁盘读到内存时，可以先把内容读到一个bytes，然后用pickle.loads()方法反序列化出对象，也可以直接用pickle.load()方法从一个file-like Object中直接反序列化出对象。我们打开另一个Python命令行来反序列化刚才保存的对象：

# with open("dump.txt","rb") as f:
#     bytes_data=f.read()
#     print(pickle.loads(bytes_data))

import json
d=dict(name="Bob",age=20,score=88)
# dumps()方法返回一个str，内容就是标准的JSON。类似的，dump()方法可以直接把JSON写入一个file-like Object。要把JSON反序列化为Python对象，用loads()或者对应的load()方法，前者把JSON的字符串反序列化，后者从file-like Object中读取字符串并反序列化：
print(type(json.dumps(d)))
json_str='{"age": 20, "score": 88, "name": "Bob"}'
print(type(json.loads(json_str)))

import json

class Student(object):
    def __init__(self, name, age, score):
        self.name = name
        self.age = age
        self.score = score
s = Student('Bob', 20, 88)
def student2dict(std):
    return {
        "name":std.name,
        "age":std.age,
        "score":std.score
    }
print(json.dumps(s,default=student2dict)) #可选参数default就是把任意一个对象变成一个可序列为JSON的对象，我们只需要为Student专门写一个转换函数

print(json.dumps(s,default=lambda x:x.__dict__)) #因为通常class的实例都有一个__dict__属性，它就是一个dict，用来存储实例变量。也有少数例外，比如定义了__slots__的class。

#同样的道理，如果我们要把JSON反序列化为一个Student对象实例，loads()方法首先转换出一个dict对象，然后，我们传入的object_hook函数负责把dict转换为Student实例
def dict2Student(d):
    return Student(d["name"],d["age"],d["score"])
json_str = '{"age": 20, "score": 88, "name": "Bob"}'
json_str_student=json.loads(json_str,object_hook=dict2Student)
print(type(json_str_student))

import json

obj = dict(name='小明', age=20)
s = json.dumps(obj, ensure_ascii=False)
print(s)

{
    'test1' : (1, 32, 41, 101),
    'test2' : {
        'insert1' : {
            'number' : [1, 2, 101, 102],
            'string' : [
                {'name': 'test_name', 1: 2, 4: {
                    'test5': 104,
                    10: 105,
                }},
                'test_string',
                'test_name'
            ],
            101 : 1.1,
        }
    },

    10101: [(1, 'str', 1.2), {
        (1,2) : 'test',
        1 : 'test1',
        'num' : (1, 2),
    }]
}