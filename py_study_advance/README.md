# 学习完python的基础语法了，后续的学习记录于此
相关网站：
[菜鸟的进度](https://www.runoob.com/python3/python3-reg-expressions.html)
[进度2](https://liaoxuefeng.com/books/python/process-thread/index.html)

探索Python标准库
- Python 的官方标准库提供了广泛的功能覆盖，能够满足各种开发需求，从而减少对外部库的依赖。由 Python 核心团队和社区共同维护，这些库具备极高的可靠性和稳定性，因而质量上乘，漏洞较少。使用这些库可以显著提高开发效率，使开发者能够专注于业务逻辑，从而加快项目进度。此外，Python 标准库具有跨平台兼容性，使代码能够在不同操作系统上无缝运行，增强了软件的可移植性。
  - [Python 标准库](https://docs.python.org/zh-cn/3.11/library/index.html#library-index)
- 社区提供的第三方库功能更加丰富多样，涵盖了数据分析、桌面开发、网络编程、图形处理等广泛领域，可以满足更专业和复杂的开发需求。使用这些第三方库能够加速开发进程，避免重复造轮子，从而更快实现项目目标。第三方库通常配备详尽的文档、丰富的示例和众多的教程资源，开发者可以轻松上手，并在实战中学习到许多最佳实践，大大提升开发效率。例如，利用 PyQt 进行工具开发就是一个典型的应用场景。
  - [PyQt5 Reference Guide](https://docs.python.org/zh-cn/3.11/library/index.html#library-index)


# 多进程
```python
import os, time, random, sys
from multiprocessing import Process, Pool
# 子进程要执行的代码
def run_func(name)->None:
    print(f"子进程运行中，name={name}, names_id = {os.getpid()}")

if __name__ == '__main__':
    print("父进程运行中，pid=%d" % os.getpid())
    p=Process(target = run_func, args = ("hello",))
    print("子进程将要执行")
    p.start()
    p.join()
    print("子进程已结束")
    
# 使用大量进程涉及进程池
def long_time_task(name):
    print(f"Run task {name} ({os.getpid()})")
    start = time.time()
    time.sleep(random.random()*3) # 这句是模拟耗时操作
    end=time.time()
    print(f"Task {name} runs {end - start:0.2} seconds.")

if __name__ == '__main__':
    print(f'父进程 {os.getpid()}')
    p=Pool(4)
    for i in range(5):
        p.apply_async(long_time_task, args=(i,))
    print('等待所有子进程完成')
    p.close() # 在调用join()之前必须先调用close()，调用close()之后就不能继续添加新的Process了，close()作用是关闭进程池，防止进一步添加新的进程。
    p.join()
    print('所有子进程已结束')

```
## 控制子进程输入输出通道等
```python

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
```
## 进程之间的通信
Python的multiprocessing模块包装了底层的机制，提供了Queue、Pipes等多种方式来交换数据。
```python
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

if __name__ == '__main__':
    # 父进程创建Queue，并传给各个子进程：
    q=Queue()
    pw=Process(target=write,args=(q,))
    pr=Process(target=read,args=(q,))
    # 启动子进程pw，写入:
    pw.start()
    pr.start() # 启动子进程pr，读取:
    pw.join() # 等待pw结束
    # pr进程里是死循环，无法等待其结束，只能强行终止:
    pr.terminate()
```

```python
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
```
# 描述器
描述器本质是一个类的对象，可以通过托管协议托管属性的读取、存储等
```python
class Descriptor:
    __get__(self, obj, type = None)->obj
    __set__(self, obj, value)->None
    __delete__(self, obj)->None
    __set_name__(self, owner, name)

class Obj:
    attr = Descriptor()
```

eg:
```python
class Descriptor:
    def __get__(self, obj, cls):
        return obj._hp

    def __set__(self, obj, value):
        if value <0 or value > 100:
            return
        obj._hp=value

class A:
    hp = Descriptor()
    def __init__(self):
        self._hp = 0

a= A()
print(a.hp)
a.hp = 99
print(a.hp)
```
描述器实际上是绑定到类属性上的，访问该类属性时，描述器方法会触发。具体要注意以下两种情况：

（1）通过实例访问类属性时
如果通过实例访问（如 a.hp），obj 会是实例。
通过实例调用描述器时，可以实现对某个具体对象的定制访问。
```python
a = A()
print(a.hp)  # obj 是实例 a
a.hp = 50    # obj 是实例 a
del a.hp     # obj 是实例 a
```
（2）通过类访问类属性时
如果直接通过类访问（如 A.hp），obj 会是 None，而 cls 是类本身。
通过类调用描述器时，可以实现类级别的属性逻辑。
```python
print(A.hp)  # obj 是 None，因为这是类访问
```
>__get__(self, obj, cls)
参数是 固定的两个（除了 self 本身）：
obj: 调用此描述器的实例（通过实例访问描述器属性时传递），或 None（通过类访问描述器属性时传递）。
cls: 调用此描述器的类
> 
> __set__(self, obj, value)
参数是 固定的两个（除了 self 本身）：
obj: 调用此描述器时的实例（用于设置属性时）。
value: 设置的属性值。
> 
> __delete__(self, obj)
参数是 固定的一个（除了 self 本身）：
obj: 调用此描述器时的实例（用于删除属性时）。
## 用于属性访问的时候
> 对象的属性可以是：
> 1. 对象本身属性
> 2. 父类对象属性
> 3. 类的属性
> 4. 描述器托管
> 5. _getattr__托管
> 6. _getattribute_托管

so,哪一个是`d.attr`

python的属性访问链：
没有重载__getattr__ 和__getattribute__，走正常属性访问
1. Data Descriptor `__get__` (定义了get和set的)
2. Object `__dict__`
3. Non-Data Descriptor `__get__`(自定义了get的)
4. MRO `__dict__`
5. raise attributeerror

定义了__getattribute__，全部托管，没有__getattribute__，走正常，找不到最后走__getattr__
# 元类
type所有类型默认的元类，通过type实例化一个类
元类的核心方法

`__new__(cls, name, bases, dct)`
这是元类的关键方法，用于创建类。它的参数是固定的：

cls:
当前元类自身。
在调用时，Python 会把元类的自身类作为第一个参数传入。
name:
即类名称（字符串）。
bases:
当前类继承的父类元组。
dct:
类的属性字典（包括方法、属性、类变量等）。
如果这些参数的数量或顺序改变，类创建时会导致运行时错误。

`__init__(self, name, bases, dct)`
该方法在类对象创建之后调用，用于初始化类对象。参数同样是固定的：

self:
当前类对象（不是元类本身，而是元类创建的类）。
name:
类名称（字符串）。
bases:
当前类继承的父类元组。
dct:
类的属性字典。

对象创建流程
1. ObjectMetaClass `__new__`
2. ObjectMetaClass `__init__`
3. ObjectMetaClass `__call__`
4. Object `__new__`
5. Object `__init__`
```python
class ObjectMetaClass(type):
    def __init__(cls, name, bases, dict):
        print('Object Meta Class __init__')
        super().__init__(name, bases, dict)
        # type.__init__(cls, name, bases, dict)

    def __new__(kcls, name, bases, dict):
        print('Object Meta Class __new__')
        return super().__new__(kcls, name, bases, dict)

    def __call__(cls, *args, **kwargs):
        print('Object Meta Class __call__')
        return super().__call__( *args, **kwargs)

class Object(object, metaclass=ObjectMetaClass):
    def __init__(self):
        print('Object __init__')

    def __new__(cls, *args, **kwargs):
        print('Object __init__')
        return super().__new__(cls,*args,**kwargs)

    def func(self):
        pass

obj = Object()
```

```python

```