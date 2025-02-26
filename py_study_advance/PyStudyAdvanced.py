# -*- coding: utf-8 -*-

# import multiprocessing
# import os, time, random, sys
# from multiprocessing import Process, Pool
#
# # 子进程要执行的代码
# # def run_func(name)->None:
# #     print(f"子进程运行中，name={name}, names_id = {os.getpid()}")
# #
# # if __name__ == '__main__':
# #     print("父进程运行中，pid=%d" % os.getpid())
# #     p=Process(target = run_func, args = ("hello",))
# #     print("子进程将要执行")
# #     p.start()
# #     p.join()
# #     print("子进程已结束")
#
# # 使用大量进程涉及进程池
# # def long_time_task(name):
# #     print(f"Run task {name} ({os.getpid()})")
# #     start = time.time()
# #     time.sleep(random.random()*3) # 这句是模拟耗时操作
# #     end=time.time()
# #     print(f"Task {name} runs {end - start:0.2} seconds.")
# #
# # if __name__ == '__main__':
# #     print(f'父进程 {os.getpid()}')
# #     p=Pool(4)
# #     for i in range(5):
# #         p.apply_async(long_time_task, args=(i,))
# #     print('等待所有子进程完成')
# #     p.close() # 在调用join()之前必须先调用close()，调用close()之后就不能继续添加新的Process了，close()作用是关闭进程池，防止进一步添加新的进程。
# #     p.join()
# #     print('所有子进程已结束')
#
# # 控制子进程的输入和输出
# import subprocess
# # print("$ nslookup www.python.org")
# # r=subprocess.call(['nslookup','www.python.org'])
# # print("Exit code:", r)
#
# # print("$ nslookup")
# # p=subprocess.Popen(["nslookup"],stdin=subprocess.PIPE,stdout=subprocess.PIPE,stderr=subprocess.PIPE)
# # output, err = p.communicate(b'set q=mx \n python.org \n exit \n ')
# # print(output.decode('utf-8'))
# # print('Exit code:', p.returncode)
#
# # 进程之间的通信
# # 以Queue为例，在父进程中创建两个子进程，一个往Queue里写数据，一个从Queue里读数据
# from multiprocessing import Queue,Process
# import os,time,random
# # 写数据进程执行的代码:
# def write(q):
#     print(f"写进程pid={os.getpid()}")
#     for value in ['A','B','C']:
#         print(f"Put {value} to queue...")
#         q.put(value)
#         time.sleep(random.random()) # 随机休眠0-1秒
# # 读数据进程执行的代码:
# def read(q):
#     print(f"读进程pid={os.getpid()}")
#     while True:
#         value=q.get(True) # 读队列，直到队列为空
#         print(f"Read {value}")
#
# # if __name__ == '__main__':
# #     # 父进程创建Queue，并传给各个子进程：
# #     q=Queue()
# #     pw=Process(target=write,args=(q,))
# #     pr=Process(target=read,args=(q,))
# #     # 启动子进程pw，写入:
# #     pw.start()
# #     pr.start() # 启动子进程pr，读取:
# #     pw.join() # 等待pw结束
# #     # pr进程里是死循环，无法等待其结束，只能强行终止:
# #     pr.terminate()
#
# def child_process(conn):
#     print(f'Child process PID: {os.getpid()}')
#     msg=conn.recv()
#     print(f"从父进程接收到的消息：{msg}")
#     response = "Hello, parent. Message received."
#     conn.send(response)
#     conn.close()
# if __name__ == '__main__':
#     parent_conn,child_conn=multiprocessing.Pipe() # 创建管道并返回一对连接对象（Connection），一个用于发送数据，另一个用于接收数据。
#     # 创建子进程
#     p=multiprocessing.Process(target=child_process,args=(child_conn,))
#     p.start()
#     # 在父进程中，向子进程发送消息
#     parent_conn.send("Hello, child. 这里是父进程")
#     # 等待子进程来的消息
#     response=parent_conn.recv()
#     print(f"Parent process received message: {response}")
#     parent_conn.close()
#     child_conn.close()
#     p.join()

# import functools
#
# def log(text=None):
#     def decorator(func):
#         @functools.wraps(func)
#         def wrapper(*args, **kw):
#             print("begin call")
#             if text and isinstance(text, str):
#                 print(f"has text: {text}")
#             result = func(*args, **kw)
#             print("end call")
#             return result
#         return wrapper
#
#     if callable(text):
#         print(f"callable: {text}")
#         return decorator(text) #无参的时候，即@log()直接使用作为装饰器，参数自然是加功能的函数本身，返回一个调用相当于return decorator(func)第三层没干啥的函数
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
# f1()
# print()
# f2()
#
# def rpc(rpc_flag, *args):
#     def _rpc(func):
#         rpc_indexer.RegisterRpc(func.__name__)
#         func._is_rpc = True
#         func._rpc_flag = rpc_flag
#         func._rpc_args = args
#         func._response_args = GetResponseArgs(args).
#         def wrapper(*args, **kwargs):
#             return func(*args, **kwargs)
#         return wrapper
#     return _rpc

print("Hello World")

#
# def track(*args):
#     def _track(func):
#         func.called_count = 0
#         return func
#     return _track
#
# @track()
# def example1():
#     print("Function example1 executed")
#
# print(example1.called_count)  # 输出: 0
# example1()
# print(example1.called_count)  # 输出: 0
#
# def track1(a, *decorator_args):
#     def _track1(func):
#         func.called_count = a
#
#         def wrapper(*wrapper_args, **wrapper_kwargs):
#             wrapper.called_count += 1
#             return func(*wrapper_args, **wrapper_kwargs)
#
#         wrapper.called_count = func.called_count
#         # wrapper.original_func = func  # 保存对原始函数的引用
#         return func
#
#     return _track1
#
# @track1(3)
# def example2():
#     print("Function example2 executed")
#
#
# # 此时 example2 实际上是 wrapper
# print(example2.called_count)  # 输出: 3
#
# example2()  # 调用函数，输出: Function example2 executed
# print(example2.called_count)  # 输出: 4

import time
def count_time_args(msg=None):
    def count_time(func):
        def wrapper(*args, **kwargs):
            t1=time.time()
            func(*args, **kwargs)
            print(f"[{msg}]执行时间为：", time.time() - t1)

        return wrapper
    return count_time

@count_time_args(msg="baiyu")
def fun_one():
    time.sleep(1)


@count_time_args(msg="zhh")
def fun_two():
    time.sleep(1)


@count_time_args(msg="mylove")
def fun_three():
    time.sleep(1)

# class BaiyuDecorator:
#     def __init__(self, func):
#         self.func=func
#         print("執行类的__init__方法")
#
#     def __call__(self, *args, **kwargs):
#         print('进入__call__函数')
#         t1 = time.time()
#         self.func(*args, **kwargs)
#         print("执行时间为：", time.time() - t1)

# @BaiyuDecorator
# def baiyu():
#     print("我是公式白玉")
#     time.sleep(2)
#
#
# def python_blog_list():
#     time.sleep(5)
#     print('''【Python】爬虫实战，零基础初试爬虫下载图片（附源码和分析过程）
#     https://blog.csdn.net/zhh763984017/article/details/119063252 ''')
#     print('''【Python】除了多线程和多进程，你还要会协程
#     https://blog.csdn.net/zhh763984017/article/details/118958668 ''')
#     print('''【Python】爬虫提速小技巧，多线程与多进程（附源码示例）
#     https://blog.csdn.net/zhh763984017/article/details/118773313 ''')
#     print('''【Python】爬虫解析利器Xpath，由浅入深快速掌握（附源码例子）
#     https://blog.csdn.net/zhh763984017/article/details/118634945 ''')
#
#
# @BaiyuDecorator
# def blog(name):
#     print('进入blog函数')
#     name()
#     print('我的博客是 https://blog.csdn.net/zhh763984017')


# class BaiyuDecorator:
#     def __init__(self, arg1, arg2):  # init()方法里面的参数都是装饰器的参数
#         print('执行类Decorator的__init__()方法')
#         self.arg1 = arg1
#         self.arg2 = arg2
#
#     def __call__(self, func):  # 因为装饰器带了参数，所以接收传入函数变量的位置是这里
#         print('执行类Decorator的__call__()方法')
#         def baiyu_warp(*args):  # 这里装饰器的函数名字可以随便命名，只要跟return的函数名相同即可
#             print('执行wrap()')
#             print('装饰器参数：', self.arg1, self.arg2)
#             print('执行' + func.__name__ + '()')
#             func(*args)
#             print(func.__name__ + '()执行完毕')
#
#         return baiyu_warp
#
#
# @BaiyuDecorator('Hello', 'Baiyu')
# def example(a1, a2, a3):
#     print('传入example()的参数：', a1, a2, a3)
#
# if __name__ == '__main__':
#     # fun_one()
#     # fun_two()
#     # fun_three()
#     # baiyu()
#     # print("-------")
#     # blog(python_blog_list)
#     print('准备调用example()')
#     example('Baiyu', 'Happy', 'Coder')
#     print('测试代码执行完毕')
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
# print(f)
# print(f())
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
#
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

def fibonacci(n):
    if n <= 1:
        return n
    if n not in fibonacci.cache:
        fibonacci.cache[n] = fibonacci(n-1) + fibonacci(n-2)
    return fibonacci.cache[n]

# 初始化自定义属性
fibonacci.cache = {}

# 调用函数
print(fibonacci(10))  # 输出: 55
print(fibonacci.cache)  # 输


def counting_decorator(initial_count=0):
    def decorator(func):
        func.count = initial_count  # 初始化计数器

        def wrapper(*args, **kwargs):
            print("Before the function call")
            result = func(*args, **kwargs)  # 调用原函数
            wrapper.count += 1  # 计数器加1
            print("After the function call")
            return result
        wrapper.count = func.count
        return wrapper

    return decorator


@counting_decorator(initial_count=5)  # 可以指定初始计数值
def hello_world():
    print("hello world")
# counting_decorator(5)(hello_world)()

# 调用函数
hello_world()  # 输出: Before the function call, hello world, After the function call
print(f"Current count: {hello_world.count}")  # 输出: Current count: 6

hello_world()  # 输出: Before the function call, hello world, After the function call
print(f"Current count: {hello_world.count}")  # 输出: Current count: 7
# 出: {2: 1, 3: 2, 4: 3, 5: 5, 6: 8, 7: 13, 8: 21, 9: 34, 10: 55}
