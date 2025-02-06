# # import study
# #
# # print("*-*-*-")
# # list_=dir(study)
# # print(len(list_))
# # for i,num in zip(dir(study),range(0,len(dir(study)))):
# #     print(i,end=" ")
# #     if num %5 ==0 and num!=0:
# #         print("\n")
# #
# # study.test()
# print("*-*-*-")
# import time, functools

# def metric(func):
#     @functools.wraps(func)
#     def wrapper(*args,**kw):
#         start = time.time()
#         result= func(*args,**kw)
#         end = time.time()
#         print('%s executed in %s ms' % (func.__name__, end - start))
#         return result
#     return wrapper
# def log(func):
#     @functools.wraps(func)
#     def wrapper(*args,**kw):
#         print('begin call %s():' % func.__name__)
#         result= func(*args,**kw)
#         print('end call %s():' % func.__name__)
#         return result
#     return wrapper

# # 测试
# def fast(x, y):
#     time.sleep(0.0012)
#     return x + y;


# @log
# @metric
# def slow(x, y, z):
#     time.sleep(0.1234)
#     return x * y * z;

# f = fast(11, 22)
# s = slow(11, 22, 33)


# if f != 33:
#     print('测试失败!')
# elif s != 7986:
#     print('测试失败!')

# print("dfasdfasdf")
# metric_func=metric(log(fast))
# metric_func(11,22)

import sys,os

G_path="G:\\"

with open("../../README.MD","w+") as f:
    f.truncate(0)
    file_list=os.listdir(G_path)
    print(str(file_list))
    for str in file_list:
        f.write(str+'\n')
