import multiprocessing
import os, time, random, sys
from multiprocessing import Process, Pool

# 子进程要执行的代码
# def run_func(name)->None:
#     print(f"子进程运行中，name={name}, names_id = {os.getpid()}")
#
# if __name__ == '__main__':
#     print("父进程运行中，pid=%d" % os.getpid())
#     p=Process(target = run_func, args = ("hello",))
#     print("子进程将要执行")
#     p.start()
#     p.join()
#     print("子进程已结束")

# 使用大量进程涉及进程池
# def long_time_task(name):
#     print(f"Run task {name} ({os.getpid()})")
#     start = time.time()
#     time.sleep(random.random()*3) # 这句是模拟耗时操作
#     end=time.time()
#     print(f"Task {name} runs {end - start:0.2} seconds.")
#
# if __name__ == '__main__':
#     print(f'父进程 {os.getpid()}')
#     p=Pool(4)
#     for i in range(5):
#         p.apply_async(long_time_task, args=(i,))
#     print('等待所有子进程完成')
#     p.close() # 在调用join()之前必须先调用close()，调用close()之后就不能继续添加新的Process了，close()作用是关闭进程池，防止进一步添加新的进程。
#     p.join()
#     print('所有子进程已结束')

# 控制子进程的输入和输出
import subprocess
# print("$ nslookup www.python.org")
# r=subprocess.call(['nslookup','www.python.org'])
# print("Exit code:", r)

# print("$ nslookup")
# p=subprocess.Popen(["nslookup"],stdin=subprocess.PIPE,stdout=subprocess.PIPE,stderr=subprocess.PIPE)
# output, err = p.communicate(b'set q=mx \n python.org \n exit \n ')
# print(output.decode('utf-8'))
# print('Exit code:', p.returncode)

# 进程之间的通信
# 以Queue为例，在父进程中创建两个子进程，一个往Queue里写数据，一个从Queue里读数据
from multiprocessing import Queue,Process
import os,time,random
# 写数据进程执行的代码:
def write(q):
    print(f"写进程pid={os.getpid()}")
    for value in ['A','B','C']:
        print(f"Put {value} to queue...")
        q.put(value)
        time.sleep(random.random()) # 随机休眠0-1秒
# 读数据进程执行的代码:
def read(q):
    print(f"读进程pid={os.getpid()}")
    while True:
        value=q.get(True) # 读队列，直到队列为空
        print(f"Read {value}")

# if __name__ == '__main__':
#     # 父进程创建Queue，并传给各个子进程：
#     q=Queue()
#     pw=Process(target=write,args=(q,))
#     pr=Process(target=read,args=(q,))
#     # 启动子进程pw，写入:
#     pw.start()
#     pr.start() # 启动子进程pr，读取:
#     pw.join() # 等待pw结束
#     # pr进程里是死循环，无法等待其结束，只能强行终止:
#     pr.terminate()

def child_process(conn):
    print(f'Child process PID: {os.getpid()}')
    msg=conn.recv()
    print(f"从父进程接收到的消息：{msg}")
    response = "Hello, parent. Message received."
    conn.send(response)
    conn.close()
if __name__ == '__main__':
    parent_conn,child_conn=multiprocessing.Pipe() # 创建管道并返回一对连接对象（Connection），一个用于发送数据，另一个用于接收数据。
    # 创建子进程
    p=multiprocessing.Process(target=child_process,args=(child_conn,))
    p.start()
    # 在父进程中，向子进程发送消息
    parent_conn.send("Hello, child. 这里是父进程")
    # 等待子进程来的消息
    response=parent_conn.recv()
    print(f"Parent process received message: {response}")
    parent_conn.close()
    child_conn.close()
    p.join()