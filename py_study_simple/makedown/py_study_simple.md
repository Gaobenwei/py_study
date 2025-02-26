# day_one
试一试能不能提交文件了，应该没问题了
# Python从头学习记录
# 基础语法快速浏览 与C/C++对比
空格缩进 \ 多行换行 大中小括号中不需要\换行|
int float bool complex 
String 没有char 类型，为长度1的String str[begin:end]范围[begin,end) str[begin: end:step]  r"string\n"--》不转义直接输出
a, b, c = 1, 2, "runoob" 为多个对象指定变量

输入input 输出print() 默认是换行输出
String 尾到头索引-1开始
不能被改变

Python 可以在同一行中使用多条语句，语句之间使用分号 ; 分割，
多个语句构成代码组
缩进相同的一组语句构成一个代码块，我们称之代码组。

像if、while、def和class这样的复合语句，首行以关键字开始，以冒号( : )结束，该行之后的一行或多行代码构成代码组

import 类似头文件包含
命令行参数类似C++ 文件名作为第一个
## pass
Python pass是空语句，是为了保持程序结构的完整性。

pass 不做任何事情，一般用做占位语句.例如空循环或者空类

## 有关判断
如果用match语句改写，则改写如下：
```python
score = 'B'

match score:
    case 'A':
        print('score is A.')
    case 'B':
        print('score is B.')
    case 'C':
        print('score is C.')
    case _: # _表示匹配到其他任何情况
        print('score is ???.')
```
使用match语句时，我们依次用case xxx匹配，并且可以在最后（且仅能在最后）加一个case _表示“任意值”，代码较if ... elif ... else ...更易读。类似C++的switch。

复杂匹配
match语句除了可以匹配简单的单个值外，还可以匹配多个值、匹配一定范围，并且把匹配后的值绑定到变量：
```python

age = 15

match age:
    case x if x < 10:
        print(f'< 10 years old: {x}')
    case 10:
        print('10 years old.')
    case 11 | 12 | 13 | 14 | 15 | 16 | 17 | 18:
        print('11~18 years old.')
    case 19:
        print('19 years old.')
    case _:
        print('not sure.')
```
在上面这个示例中，第一个case x if x < 10表示当age < 10成立时匹配，且赋值给变量x，第二个case 10仅匹配单个值，第三个case 11|12|...|18能匹配多个值，用|分隔。

可见，match语句的case匹配非常灵活。

匹配列表
match语句还可以匹配列表，功能非常强大。

我们假设用户输入了一个命令，用args = ['gcc', 'hello.c']存储，下面的代码演示了如何用match匹配来解析这个列表：
```python

args = ['gcc', 'hello.c', 'world.c']
# args = ['clean']
# args = ['gcc']

match args:
    # 如果仅出现gcc，报错:
    case ['gcc']:
        print('gcc: missing source file(s).')
    # 出现gcc，且至少指定了一个文件:
    case ['gcc', file1, *files]:
        print('gcc compile: ' + file1 + ', ' + ', '.join(files))
    # 仅出现clean:
    case ['clean']:
        print('clean')
    case _:
        print('invalid command.')
```
第一个case ['gcc']表示列表仅有'gcc'一个字符串，没有指定文件名，报错；

第二个case ['gcc', file1, *files]表示列表第一个字符串是'gcc'，第二个字符串绑定到变量file1，后面的任意个字符串绑定到*files（符号*的作用将在函数的参数中讲解），它实际上表示至少指定一个文件；

第三个case ['clean']表示列表仅有'clean'一个字符串；

最后一个case _表示其他所有情况。

可见，match语句的匹配规则非常灵活，可以写出非常简洁的代码。
## 特殊的数据结构
### list 
可以包含任意类型的元素，列表可以完成大多数集合类的数据结构实现。列表中元素的类型可以不相同，它支持数字，字符串甚至可以包含列表（所谓嵌套）。
列表是写在方括号 [] 之间、用逗号分隔开的元素列表。
和字符串一样，列表同样可以被索引和截取，列表被截取后返回一个包含所需元素的新列表。索引方式和截取方法与String类似，+ 连接 * 重复也和字符串类似。**注意截取的时候步长不能为0，为1就是一次输出**
**与Python字符串不一样的是，列表中的元素是可以改变的：**
如果截取的时候步长为负数，则逆向读取，可以用来反转字符串或者列表
### tuple
元组（tuple）与列表类似，不同之处在于元组的元素不能修改。元组写在小括号 () 里，元素之间用逗号隔开。
定义的时候就要确定下来元素初始值，所以i定义单个元素元组为了防止歧义eg： t=(1,) 额外加一个逗号
元组中的元素类型也可以不相同：

**可以间接做到修改元组的值**，即元组包含可变的对象，例如包含一个列表
```python
>>> t = ('a', 'b', ['A', 'B'])
>>> t[2][0] = 'X'
>>> t[2][1] = 'Y'
>>> t
('a', 'b', ['X', 'Y'])
```
### String
特别注意编码方式，Unicode 和可变长字节UTF-8可以存中文等字符。bytes类型的数据无论是在计算长度或是表示字符，都是以一个字节为单位，所以len('中文')=2；len('中文'.encode('utf-8'))=6. [参考网址](https://liaoxuefeng.com/books/python/basic/string-encoding/index.html)
在操作字符串时，我们经常遇到str和bytes的互相转换。为了避免乱码问题，应当始终坚持使用UTF-8编码对str和bytes进行转换。

由于Python源代码也是一个文本文件，所以，当你的源代码中包含中文的时候，在保存源代码时，就需要务必指定保存为UTF-8编码。当Python解释器读取源代码时，为了让它按UTF-8编码读取，我们通常在文件开头写上这两行：
```python
#!/usr/bin/env python3
# -*- coding: utf-8 -*-
```
对于格式化输出与C类似，%，如果单纯输出% 用 %%

str.format() 麻烦的一批
format()
另一种格式化字符串的方法是使用字符串的format()方法，它会用传入的参数依次替换字符串内的占位符{0}、{1}……，不过这种方式写起来比%要麻烦得多：
```python

'Hello, {0}, 成绩提升了 {1:.1f}%'.format('小明', 17.125)
'Hello, 小明, 成绩提升了 17.1%'
```
`f-string`
最后一种格式化字符串的方法是使用以f开头的字符串，称之为f-string，它和普通字符串不同之处在于，字符串如果包含{xxx}，就会以对应的变量替换：
```python
>>> r = 2.5
>>> s = 3.14 * r ** 2
>>> print(f'The area of a circle with radius {r} is {s:.2f}')
The area of a circle with radius 2.5 is 19.62
```

上述代码中，{r}被变量r的值替换，{s:.2f}被变量s的值替换，并且:后面的.2f指定了格式化参数（即保留两位小数），因此，{s:.2f}的替换结果是19.62。
### dict set
类似于C++ map和set

### bytes
bytes 类型
在 Python3 中，bytes 类型表示的是不可变的二进制序列（byte sequence）。

与字符串类型不同的是，bytes 类型中的元素是整数值（0 到 255 之间的整数），而不是 Unicode 字符。

bytes 类型通常用于处理二进制数据，比如图像文件、音频文件、视频文件等等。在网络编程中，也经常使用 bytes 类型来传输二进制数据。

创建 bytes 对象的方式有多种，最常见的方式是使用 b 前缀：

此外，也可以使用 bytes() 函数将其他类型的对象转换为 bytes 类型。bytes() 函数的第一个参数是要转换的对象，第二个参数是编码方式，如果省略第二个参数，则默认使用 UTF-8 编码：

x = bytes("hello", encoding="utf-8")
与字符串类型类似，bytes 类型也支持许多操作和方法，如切片、拼接、查找、替换等等。同时，由于 bytes 类型是不可变的，因此在进行修改操作时需要创建一个新的 bytes 对象。例如：

实例
```python

x = b"hello"
y = x[1:3]  # 切片操作，得到 b"el"
z = x + b"world"  # 拼接操作，得到 b"helloworld"
```
需要注意的是，bytes 类型中的元素是整数值，因此在进行比较操作时需要使用相应的整数值。例如：
```python
实例
x = b"hello"
if x[0] == ord("h"):
    print("The first element is 'h'")
```
其中 ord() 函数用于将字符转换为相应的整数值。

## 迭代 for

Python的for循环使用更像C++的范围for循环：

```c++
vector<int> res;
for(const char& num:res){}
```

```python
for num in res:
    print(num)
```

所以在使用的时候可能需要判断一个对象是否是可以迭代的对象。通过`collections.abc`模块的`Iterable`类型判断：

```python
>>> from collections.abc import Iterable
>>> isinstance('abc', Iterable) # str是否可迭代
True
>>> isinstance([1,2,3], Iterable) # list是否可迭代
True
>>> isinstance(123, Iterable) # 整数是否可迭代
False
```

为了实现索引-元素 对这样的访问，可以用`enumerate`函数。

## 注意
对于不变对象来说，调用对象自身的任意方法，也不会改变该对象自身的内容。相反，这些方法会创建新的对象并返回，这样，就保证了不可变对象本身永远是不可变的。
## 运算符
多了一些，例如`:=`在赋值的同时返回该值，例如`if (n:=10)>10 `
### is is not
身份运算符用于比较两个对象的存储单元
is	is 是判断两个标识符是不是引用自一个对象	x is y, 类似 id(x) == id(y) , 如果引用的是同一个对象则返回 True，否则返回 False
is not	is not 是判断两个标识符是不是引用自不同对象	x is not y ， 类似 id(x) != id(y)。如果引用的不是同一个对象则返回结果 True，否则返回 False。
**id()获取对象的内存地址，就是比较变量名是否指向同一个对象**

## 推导式 （写法类似STL仿函数里的遍历方法）
```python
# 列表推导式
# [表达式 for 变量 in 列表] 
# [表达式 for 变量 in 列表 if 条件]
names = ['Bob','Tom','alice','Jerry','Wendy','Smith']
new_names=[name.upper() for name in names if len(name)>3]
print(new_names)
print(type(new_names))

multiples = [i for i in range(30) if i % 3 == 0]
print(multiples)
print(type(multiples))

# 字典推导式
# { key_expr: value_expr for value in collection }
# { key_expr: value_expr for value in collection if condition }
listdemo = ['Google','Runoob', 'Taobao']
newdict={key:len(key) for key in listdemo}
print(newdict)
print(type(newdict))

dic={x:x**2 for x in [3,4,5]}
print(dic)
print(type(dic))

# 集合推导式
# { expression for item in Sequence }
# { expression for item in Sequence if conditional }

setnew={x**2 for x in range(1,4)}
print(setnew)
print(type(setnew))

a={x for x in "fasdfasdf" if x not in "abc"}
print(a)
print(type(a))

# 元组推导式（生成器表达式）
# (expression for item in Sequence )
# (expression for item in Sequence if conditional )
# 元组推导式和列表推导式的用法也完全相同，只是元组推导式是用 () 圆括号将各部分括起来，而列表推导式用的是中括号 []，另外元组推导式返回的结果是一个生成器对象。
a=(x for x in range(1,10))
# print(a)
print(tuple(a))
print(type(a))
```
**关于列表生成式当中的if else  判断相关的**

使用列表生成式的时候，有些童鞋经常搞不清楚`if...else`的用法。

例如，以下代码正常输出偶数：

```plain
>>> [x for x in range(1, 11) if x % 2 == 0]
[2, 4, 6, 8, 10]
```

但是，我们不能在最后的`if`加上`else`：

```plain
>>> [x for x in range(1, 11) if x % 2 == 0 else 0]
  File "<stdin>", line 1
    [x for x in range(1, 11) if x % 2 == 0 else 0]
                                              ^
SyntaxError: invalid syntax
```

这是因为跟在`for`后面的`if`是一个筛选条件，不能带`else`，否则如何筛选？

另一些童鞋发现把`if`写在`for`前面必须加`else`，否则报错：

```plain
>>> [x if x % 2 == 0 for x in range(1, 11)]
  File "<stdin>", line 1
    [x if x % 2 == 0 for x in range(1, 11)]
                       ^
SyntaxError: invalid syntax
```

这是因为`for`前面的部分是一个表达式，它必须根据`x`计算出一个结果。因此，考察表达式：`x if x % 2 == 0`，它无法根据`x`计算出结果，因为缺少`else`，必须加上`else`：

```plain
>>> [x if x % 2 == 0 else -x for x in range(1, 11)]
[-1, 2, -3, 4, -5, 6, -7, 8, -9, 10]
```

上述`for`前面的表达式`x if x % 2 == 0 else -x`才能根据`x`计算出确定的结果。

***可见，在一个列表生成式中，`for`前面的`if ... else`是表达式，而`for`后面的`if`是过滤条件，不能带`else`。***for 前面是表达式，就需要得出精确的值，后面是过滤的条件，不能带else。

## 迭代器与生成器

### 生成器

如果列表元素可以按照某种算法推算出来，那我们是否可以在循环的过程中不断推算出后续的元素呢？这样就不必创建完整的list，从而节省大量的空间。在Python中，这种一边循环一边计算的机制，称为生成器：**generator。**

创建方法：

1. 把列表生成式[]改成（）即可。打印生成器的下一个值可以用next()做到。

   generator保存的是算法，调用next（）不断调用并生成下一个元素的值，直到计算到最后一个元素，抛出错误。

2. 如果推算规则不好写成生成式，但可以写出复杂的函数推到不断算出下一个数字。就有关键字`yield`，如果一个函数定义中包含`yield`关键字，那么这个函数就不再是一个普通函数，而是一个generator函数，调用一个generator函数将返回一个generator。

   ```python
   def fib(max):
       n, a, b = 0, 0, 1
       while n < max:
           yield b #普通函数的话例如：print(b)
           a, b = b, a + b
           n = n + 1
       return 'done'
   
   ...
   最难理解的就是generator函数和普通函数的执行流程不一样。普通函数是顺序执行，遇到return语句或者最后一行函数语句就返回。而变成generator的函数，在每次调用next()的时候执行，遇到yield语句返回，再次执行时从上次返回的yield语句处继续执行。
   ...
   ```

   调用该generator函数时，首先要生成一个generator对象，然后用`next()`函数不断获得下一个返回值：eg：
   
   ***请务必注意：调用generator函数会创建一个generator对象，多次调用generator函数会创建多个相互独立的generator。***
   
   想要关注StopIteration的错误返回情况，可以捕获错误分析value值：
   
   ```python
   fo=fib(7)
   while True:
       try:
           x=next(fo)
           print("g:",x)
       except StopIteration as e:
           print("Generator return value:",e.value)
           break
   ```

**yield** 是一个关键字，用于定义生成器函数，生成器函数是一种特殊的函数，可以在迭代过程中逐步产生值，而不是一次性返回所有结果。

跟普通函数不同的是，生成器是一个返回迭代器的函数，只能用于迭代操作，更简单点理解生成器就是一个迭代器。

当在生成器函数中使用 **yield** 语句时，函数的执行将会暂停，并将 **yield** 后面的表达式作为当前迭代的值返回。

然后，每次调用生成器的 **next()** 方法或使用 **for** 循环进行迭代时，函数会从上次暂停的地方继续执行，直到再次遇到 **yield** 语句。这样，生成器函数可以逐步产生值，而不需要一次性计算并返回所有结果。

调用一个生成器函数，返回的是一个迭代器对象。

### 迭代器

我们已经知道，可以直接作用于`for`循环的数据类型有以下几种：

一类是集合数据类型，如`list`、`tuple`、`dict`、`set`、`str`等；

一类是`generator`，包括生成器和带`yield`的generator function。

这些可以直接作用于`for`循环的对象统称为***可迭代对象：`Iterable`。***

可以使用`isinstance()`判断一个对象是否是`Iterable`对象：

```python
>>> from collections.abc import Iterable
>>> isinstance([], Iterable)
True
>>> isinstance({}, Iterable)
True
>>> isinstance('abc', Iterable)
True
>>> isinstance((x for x in range(10)), Iterable)
True
>>> isinstance(100, Iterable)
False
```

而生成器不但可以作用于`for`循环，还可以被`next()`函数不断调用并返回下一个值，直到最后抛出`StopIteration`错误表示无法继续返回下一个值了。

可以被`next()`函数调用并不断返回下一个值的对象称为***迭代器：`Iterator`。***

```python
>>> from collections.abc import Iterator
>>> isinstance((x for x in range(10)), Iterator)
True
>>> isinstance([], Iterator)
False
>>> isinstance({}, Iterator)
False
>>> isinstance('abc', Iterator)
False
```

- 生成器都是`Iterator`对象，但`list`、`dict`、`str`虽然是`Iterable`，却不是`Iterator`。

- 把`list`、`dict`、`str`等`Iterable`变成`Iterator`可以使用`iter()`函数：

- 凡是可作用于`for`循环的对象都是`Iterable`类型；

  凡是可作用于`next()`函数的对象都是`Iterator`类型，它们表示一个惰性计算的序列；Python的`for`循环本质上就是通过不断调用`next()`函数实现的，例如：

  ```python
  for x in [1, 2, 3, 4, 5]:
      pass
  ```

  实际上完全等价于：

  ```python
  # 首先获得Iterator对象:
  it = iter([1, 2, 3, 4, 5])
  # 循环:
  while True:
      try:
          # 获得下一个值:
          x = next(it)
      except StopIteration:
          # 遇到StopIteration就退出循环
          break
  ```

> 为什么`list`、`dict`、`str`等数据类型不是`Iterator`？
>
> 这是因为Python的`Iterator`对象表示的是一个数据流，`Iterator`对象可以被`next()`函数调用并不断返回下一个数据，直到没有数据时抛出`StopIteration`错误。可以把这个数据流看做是一个有序序列，但我们却不能提前知道序列的长度，只能不断通过`next()`函数实现按需计算下一个数据，所以`Iterator`的计算是惰性的，只有在需要返回下一个数据时它才会计算。
>
> `Iterator`甚至可以表示一个无限大的数据流，例如全体自然数。而使用list是永远不可能存储全体自然数的。

迭代器是一个可以记住遍历的位置的对象。
迭代器对象从集合的第一个元素开始访问，直到所有的元素被访问完结束。迭代器只能往前不会后退。
***迭代器有两个基本的方法：iter() 和 next()。***
不同与STL只能向前，功能最简单的迭代器。似乎定义了不能指定起始位置，只能在最开头.而且似乎只能遍历到底一次，即每个元素遍历到一次，没有多次遍历的说法。

***迭代器相较于可迭代对象，除了均可以for循环遍历的性质，该有序数据流惰性的，不能提前预知到长度，所以list dict str不是iterator***



#### 创建一个迭代器

把一个类作为一个迭代器使用需要在类中实现两个方法 __iter__() 与 __next__() 。__iter__() 方法返回一个特殊的迭代器对象， 这个迭代器对象实现了 `__next__() `方法并通过 StopIteration 异常标识迭代的完成。

`__next__() `方法会返回下一个迭代器对象。

#### StopIteration

StopIteration 异常用于标识迭代的完成，防止出现无限循环的情况，在 `__next__() `方法中我们可以设置在完成指定循环次数后触发 StopIteration 异常来结束迭代。

```python
class MyNumbers:
    def __iter__(self):
        self.a=1
        return self
    def __next__(self):
        if self.a<=20:
            x=self.a
            self.a+=1
            return x
        else:
            raise StopIteration
print()
myclass=MyNumbers() 
myiter=iter(myclass) 
'''
myclass = MyNumbers()
这句创建了 MyNumbers 类的实例 myclass，它是一个普通的 Python 对象。此时，myclass 还不是迭代器，只是一个实现了 __iter__() 和 __next__() 方法的对象。
myiter = iter(myclass)
这句调用了 myclass 的 __iter__() 方法，初始化了 self.a = 1，并将 myclass 自身返回。
这一步的结果是：
myiter 和 myclass 指向同一个对象。
这个对象现在可以被视为迭代器，因为它实现了 __iter__() 和 __next__() 方法。
''''
print(next(myiter))
print(next(myiter))
print(next(myiter))
print(next(myiter))
print(next(myiter))
```
## 函数
- python的函数返回可以多个值，实质上还是一个值，是一个tuple。
- 带有默认参数的函数的调用的时候可以不按顺序提供部分默认参数。当不按顺序提供部分默认参数时，需要把参数名写上。
- **特别要注意，python中默认参数必须指向不变对象！**
  ```python
  def add_end(L=[]):
    L.append('END')
    return L
    # 多次调用，会有问题
    >>> add_end()
    ['END', 'END']
    >>> add_end()
    ['END', 'END', 'END']
    '''
    Python函数在定义的时候，默认参数L的值就被计算出来了，即[]，因为默认参数L也是一个变量，它指向对象[]，每次调用该函数，如果改变了L的内容，则下次调用时，默认参数的内容就变了，不再是函数定义时的[]了。
    '''
    # 要修改上面的例子，我们可以用None这个不变对象来实现：
    def add_end(L=None):
    if L is None:
        L = []
    L.append('END')
    return L
  ```
- 定义可变参数也不一样，关键字居然是`*`
  定义一个可变参数函数：
  ```python
    def calc(*numbers):
    sum = 0
    for n in numbers:
        sum = sum + n * n
    return sum
    >>>calc(1,3,5,7)
    # Python允许你在list或tuple前面加一个*号，把list或tuple的元素变成可变参数传进去：
    nums=[1,2,3,4]
    calc(*nums)
    # *nums表示把nums这个list的所有元素作为可变参数传进去。这种写法相当有用，而且很常见。
  ```
- 关键字参数 `**`
  可变参数允许你传入0个或任意个参数，这些可变参数在函数调用时自动组装为一个tuple。而关键字参数允许你传入0个或任意个含参数名的参数，这些关键字参数在函数内部自动组装为一个**dict**。
  ```python
  def person(name, age, **kw):
    print('name:', name, 'age:', age, 'other:', kw)
    # 调用的时候可以不传也可以传入任意个关键字参数
    >>> person('Michael', 30)
    name: Michael age: 30 other: {}
    >>> person('Bob', 35, city='Beijing')
    name: Bob age: 35 other: {'city': 'Beijing'}
    >>> person('Adam', 45, gender='M', job='Engineer')
    name: Adam age: 45 other: {'gender': 'M', 'job': 'Engineer'}
    和可变参数类似，也可以先组装出一个dict，然后，把该dict转换为关键字参数传进去：
    >>> extra = {'city': 'Beijing', 'job': 'Engineer'}
    >>> person('Jack', 24, city=extra['city'], job=extra['job'])
    name: Jack age: 24 other: {'city': 'Beijing', 'job': 'Engineer'}
    # 用**简化写法
    >>> extra = {'city': 'Beijing', 'job': 'Engineer'}
    >>> person('Jack', 24, **extra)
    name: Jack age: 24 other: {'city': 'Beijing', 'job': 'Engineer'}
    # 注意kw获得的dict是extra的一份拷贝，对kw的改动不会影响到函数外的extra。
  ```
- 命名关键字参数
    ```python
        # 调用者仍可以传入不受限制的关键字参数：
        person('Jack', 24, city='Beijing', addr='Chaoyang', zipcode=123456)
        # 如果要限制关键字参数的名字，就可以用命名关键字参数，例如，只接收city和job作为关键字参数。这种方式定义的函数
        # 和关键字参数**kw不同，命名关键字参数需要一个特殊分隔符*，*后面的参数被视为命名关键字参数。
        def person_1(name,age,*,city,job):
            print(name,age,city,job) # 不能传入不受限制的关键字参数
        person_1('Jack', 24, city='Beijing', job='Engineer')
        # person_1('Jack', 24, city='Beijing', job='Engineer', addr='Chaoyang', zipcode=123456)
        # 如果函数定义中已经有了一个可变参数，后面跟着的命名关键字参数就不再需要一个特殊分隔符*了：
        def person(name, age, *args, city, job):
            print(name, age, args, city, job)
        # 命名关键字参数必须传入参数名，这和位置参数不同。如果没有传入参数名，调用将报错：命名关键字参数可以有缺省值简化调用
        def person_1(name, age, *, city='Beijing', job):
        print(name, age, city, job)
    ```
- 参数组合
  在Python中定义函数，可以用必选参数、默认参数、可变参数、关键字参数和命名关键字参数，这5种参数都可以组合使用。但是请注意，参数定义的顺序必须是：必选参数、默认参数、可变参数、命名关键字参数和关键字参数。
  ```python
  def f1(a, b, c=0, *args, **kw):
    print('a =', a, 'b =', b, 'c =', c, 'args =', args, 'kw =', kw)
    
    def f2(a, b, c=0, *, d, **kw):
        print('a =', a, 'b =', b, 'c =', c, 'd =', d, 'kw =', kw)
    >>> f1(1, 2)
    a = 1 b = 2 c = 0 args = () kw = {}
    >>> f1(1, 2, c=3)
    a = 1 b = 2 c = 3 args = () kw = {}
    >>> f1(1, 2, 3, 'a', 'b')
    a = 1 b = 2 c = 3 args = ('a', 'b') kw = {}
    >>> f1(1, 2, 3, 'a', 'b', x=99)
    a = 1 b = 2 c = 3 args = ('a', 'b') kw = {'x': 99}
    >>> f2(1, 2, d=99, ext=None)
    a = 1 b = 2 c = 0 d = 99 kw = {'ext': None}
    # 通过一个tuple和dict，你也可以调用上述函数：
    >>> args = (1, 2, 3, 4)
    >>> kw = {'d': 99, 'x': '#'}
    >>> f1(*args, **kw)
    a = 1 b = 2 c = 3 args = (4,) kw = {'d': 99, 'x': '#'}
    >>> args = (1, 2, 3)
    >>> kw = {'d': 88, 'x': '#'}
    >>> f2(*args, **kw)
    a = 1 b = 2 c = 3 d = 88 kw = {'x': '#'}
  ```
  任意函数都可以通过``func(*args,**kw)`的形式调用，但函数调用还是要注重接口的可读性。
> 参数小结
> 小结
Python的函数具有非常灵活的参数形态，既可以实现简单的调用，又可以传入非常复杂的参数。
默认参数一定要用不可变对象，如果是可变对象，程序运行时会有逻辑错误！
要注意定义可变参数和关键字参数的语法：
*args是可变参数，args接收的是一个tuple；
**kw是关键字参数，kw接收的是一个dict。
以及调用函数时如何传入可变参数和关键字参数的语法：
可变参数既可以直接传入：func(1, 2, 3)，又可以先组装list或tuple，再通过*args传入：func(*(1, 2, 3))；
关键字参数既可以直接传入：func(a=1, b=2)，又可以先组装dict，再通过**kw传入：func(**{'a': 1, 'b': 2})。
使用*args和**kw是Python的习惯写法，当然也可以用其他参数名，但最好使用习惯用法。
命名的关键字参数是为了限制调用者可以传入的参数名，同时可以提供默认值。
定义命名的关键字参数在没有可变参数的情况下不要忘了写分隔符*，否则定义的将是位置参数。
## python的递归
解决递归调用栈溢出的方法是通过尾递归优化，事实上尾递归和循环的效果是一样的，所以，把循环看成是一种特殊的尾递归函数也是可以的。
尾递归是指，在函数返回的时候，调用自身本身，并且，return语句不能包含表达式。这样，编译器或者解释器就可以把尾递归做优化，使递归本身无论调用多少次，都只占用一个栈帧，不会出现栈溢出的情况。
## 可变对象与不可变对象的传递
- 不可变类型：类似 C++ 的值传递，如整数、字符串、元组。如 fun(a)，传递的只是 a 的值，没有影响 a 对象本身。如果在 fun(a) 内部修改 a 的值，则是新生成一个 a 的对象。
- 可变类型：类似 C++ 的引用传递，如 列表，字典。如 fun(la)，则是将 la 真正的传过去，修改后 fun 外部的 la 也会受影响
## 强制位置参数
```python
# 强制位置参数  / 一个函数形参语法 / 用来指明函数形参必须使用指定位置参数，不能使用关键字参数的形式。
def f(a, b, /, c, d, *, e, f): # 形参a, b 必须使用指定位置参数，c, d 可以使用指定位置参数或关键字参数，e, f 必须使用关键字参数
    print(a, b, c, d, e, f)
# 正确调用
f(10, 20, 30, d=40, e=50, f=60)
# 错误调用
f(10, b=20, c=30, d=40, e=50, f=60)
```
## map() reduce() filter() sorted()
这三个函数的作用分别是：
- map()：接收一个函数 f 和一个 list，并通过把函数 f 依次作用在 list 的每个元素上，得到一个新的 list 并返回。
- reduce()：接收一个函数 f, 一个 list, 和一个初始值 i，这个函数 f 必须接收两个参数，reduce()对 list 的每个元素反复调用函数 f，并返回最终结果值。
- filter()：接收一个函数 f 和一个 list，这个函数 f 的作用是对每个元素进行判断，返回 True或 False，filter()根据判断结果自动过滤掉不符合条件的元素，返回有符合条件元素组成的新 list。
- sorted()：接收一个 list，返回一个排序后的 list，可以接收一个 key 函数来实现自定义的排序，key 函数只有一个参数，就是待排序的元素。
  >排序实现起来不像C++那么简单，需要自己实现比较函数，或者使用内置的比较函数.这里的key 参数是传入一个函数对象，该函数对象不需要返回布尔类型。相反，它返回的是一个可排序的值，这个值将作为排序的依据。也就是说，key 函数从每个元素中提取一个值，Python 使用这些值来决定排序的顺序。
  >如果要想实现多标准排序，可以考虑函数返回一个元组，第一标准在前，：
  ```python
  L = [('Bob', 75), ('Adam', 75), ('Bart', 66), ('Lisa', 66)]
  
    def by_score_and_name(t):
        # 返回一个元组，包含分数和姓名，
        # 用于首先按分数排序，当分数相同时按姓名排序
        return (t[1], t[0])
    
    # 使用sorted()函数进行排序
    L2 = sorted(L, key=by_score_and_name)
    print("按分数和姓名排序:", L2)
  ```
```python
# Python的比较规则也可以多级比较，比较的函数，这个具有两个参数，参数的值都是从可迭代对象中取出，此函数必须遵守的规则为，大于则返回1，小于则返回-1，等于则返回0。（虽然Python3不用了，但可以配合cmp_to_key）
def CanCook(self, product_id):
    return self.IsGoldSatisfied(product_id) and self.IsRecipeSatisfied(product_id) 

def IsUnlockRecipe(self, product_id):
    return self.is_unlock[self.product_id2recipe_id[product_id]]

def ProductItemCompare(self, left_product_id, right_product_id):
    # 未解锁的排后面
    l_is_unlock = self.IsUnlockRecipe(left_product_id)
    r_is_unlock = self.IsUnlockRecipe(right_product_id)
    if l_is_unlock and not r_is_unlock:
        return -1
    elif not l_is_unlock and r_is_unlock:
        return 1
    
    # 都解锁了看背包内物品是否满足烹饪条件
    l_can_cook = self.CanCook(left_product_id)
    r_can_cook = self.CanCook(right_product_id)

    if l_can_cook and not r_can_cook:
        return -1
    elif not l_can_cook and r_can_cook:
        return 1
    
    return 0
# 使用key=lambda 的例子
def _SortProductItemList(self):
    self.sorted_products_id_list = sorted(
        self.sorted_products_id_list,
        key=lambda x: (not self.IsUnlockRecipe(x), not self.CanCook(x))
    )

# 使用cmp_to_key()的例子
def _SortProductItemList(self):
    self.sorted_products_id_list = sorted(
        self.sorted_products_id_list,
        key=cmp_to_key(self.ProductItemCompare)
    )
```
注意`key=..`这里是传入一个函数对象，该函数对象不需要返回布尔类型。相反，它返回的是一个可排序的值，这个值将作为排序的依据。也就是说，key 函数从每个元素中提取一个值，Python 使用这些值来决定排序的顺序。多级排序的时候，返回的值是一个元组，第一个元素是排序的依据，第二个元素是排序的依据，以此类推。
  

## Python 装饰器
### 函数的装饰器
似乎类似C++ stl中的适配器，专门修饰已有函数的适配器。接受函数作为输入返回一个包装过后的函数的对象（可以调用过的一个对象）
在代码运行期间动态增加功能的方式，称之为“装饰器”（Decorator）。
```python
# 装饰器 传入的是函数参数，返回的是函数 而且一般添加功能，所以本函数的调用方法一般不变
# 借助@将定义的装饰器至于函数定义处
def lgo(func):
    def wrappper(*args,**kw):
        print("call %s():" % func.__name__)
        return func(*args,**kw)
    return wrappper
@lgo
def now():
    print("2025-01-02")
now()

# 将@lgo 放到函数的定义位置，相当于调用了now=lgo(now)

def now_():
    print("2025-01564f65ads4f65a-02")
now_()
now_=lgo(now_)
now_()
```

```python
# 如果decorator本身需要传入参数，那就需要编写一个返回decorator的高阶函数，写出来会更复杂。比如，要自定义log的文本：
def log(text):
    def decorator(func):
        def wrapper(*args,**kw):
            print("%s %s():" % (text, func.__name__))
            return func(*args,**kw)
        return wrapper
    return decorator

@log("execu")
def now():
    print("2025-01-02")
now()
print()
# 3层的嵌套效果
def now_():
    print("2025-01-0/*/*/*/*/*2")
now_1 = log("execute")(now_)
now_1()
```


```python
# 函数的装饰器 @

# def decorator_function(original_function):
#     def wrapper(*args, **kwargs):d
#         # 这里是在调用原始函数前添加的新功能
#         before_call_code()
        
#         result = original_function(*args, **kwargs)
        
#         # 这里是在调用原始函数后添加的新功能
#         after_call_code()
        
#         return result
#     return wrapper

# # 使用装饰器
# @decorator_function
# def target_function(arg1, arg2):
#     pass  # 原始函数的实现
'''
解析：decorator 是一个装饰器函数，它接受一个函数 func 作为参数，并返回一个内部函数 wrapper，在 wrapper 函数内部，你可以执行一些额外的操作，然后调用原始函数 func，并返回其结果。
decorator_function 是装饰器，它接收一个函数 original_function 作为参数。
wrapper 是内部函数，它是实际会被调用的新函数，它包裹了原始函数的调用，并在其前后增加了额外的行为。
当我们使用 @decorator_function 前缀在 target_function 定义前，Python会自动将 target_function 作为参数传递给 decorator_function，然后将返回的 wrapper 函数替换掉原来的 target_function。
'''

'''
@time_logger
def target_function():
    pass
等价于
def target_function():
    pass
target_function = time_logger(target_function)
'''

# 带参数的装饰器

def repeat(n):
    def decorator(func):
        def wrapper(*args, **kwargs):
            for _ in range(n):
                result = func(*args, **kwargs)
            return result
        return wrapper
    return decorator

@repeat(3)
def greet(name):
    print(f"Hello, {name}!")

greet("Alice")
```
### 记得修改函数签名信息
```python
# 最后修改函数签名信息内置的functools.wraps就是干这个事的
import functools
def log(func):
    @functools.wraps(func)
    def wrapper(*args,**kw):
        print("call %s():" % func.__name__)
        return func(*args,**kw)
    return wrapper

# 或者带参decorator
import functools
def log(text):
    def decorator(func):
        @functools.wraps(func)
        def wrapper(*args,**kw):
            print("%s %s():" % (text, func.__name__))
            return func(*args,**kw)
        return wrapper
    return decorator

@log("execute")
def now():
    print("2025-01-02")
now()
print("适配之后的函数名："+now.__name__)


```
### 一个适应有参或无参的装饰器
```python
import functools

def log(text=None):
    def decorator(func):
        @functools.wraps(func)
        def wrapper(*args, **kw):
            print("begin call")
            if text and isinstance(text, str):
                print(f"has text: {text}")
            result = func(*args, **kw)
            print("end call")
            return result
        return wrapper

    if callable(text):
        return decorator(text) #无参的时候，即@log()直接使用作为装饰器，参数自然是加功能的函数本身，返回一个调用相当于return decorator(func)第三层没干啥的函数
    return decorator

@log
def f1():
    print("Function f1 is called")

@log('execute')
def f2():
    print("Function f2 is called")

# 使用示例
f1()
f2()
```
### 装饰器执行顺序
可以看这个例子：
```python
@BaiyuDecorator_1
@BaiyuDecorator_2
@BaiyuDecorator_3
def baiyu():
    print("我是攻城狮白玉")
```
> baiyu = BaiyuDecorator_1 (BaiyuDecorator_2 (BaiyuDecorator_3(baiyu)))
这样顺序就清楚了，：**在执行的时候先执行原函数的功能，然后再由里到外依次执行装饰器的内容**
### 一个添加属性也添加功能的装饰器举例
```python
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
```
### 类装饰器
除了函数装饰器，Python 还支持类装饰器。类装饰器是包含 __call__ 方法的类，它接受一个函数作为参数，并返回一个新的函数。
```python
class DecoratorClass:
    def __init__(self, func):
        self.func = func
    
    def __call__(self, *args, **kwargs):
        # 在调用原始函数之前/之后执行的代码
        result = self.func(*args, **kwargs)
        # 在调用原始函数之后执行的代码
        return result

@DecoratorClass
def my_function():
    pass
```
**带参数的类装饰器**：当装饰器有参数的时候，`__init__()`函数就不能传输func(func代表药装饰的函数),而func是在`__call__()`函数中传入的
```python
class BaiyuDecorator:
    def __init__(self, arg1, arg2):  # init()方法里面的参数都是装饰器的参数
        print('执行类Decorator的__init__()方法')
        self.arg1 = arg1
        self.arg2 = arg2
 
    def __call__(self, func):  # 因为装饰器带了参数，所以接收传入函数变量的位置是这里
        print('执行类Decorator的__call__()方法')
 
        def baiyu_warp(*args):  # 这里装饰器的函数名字可以随便命名，只要跟return的函数名相同即可
            print('执行wrap()')
            print('装饰器参数：', self.arg1, self.arg2)
            print('执行' + func.__name__ + '()')
            func(*args)
            print(func.__name__ + '()执行完毕')
 
        return baiyu_warp
 
 
@BaiyuDecorator('Hello', 'Baiyu')
def example(a1, a2, a3):
    print('传入example()的参数：', a1, a2, a3)
 
 
if __name__ == '__main__':
    print('准备调用example()')
    example('Baiyu', 'Happy', 'Coder')
    print('测试代码执行完毕')
```
> 这里注意观察一下输出的顺序，在调用之前就会输出__init__()等信息，带参数的和不带参数的都观察一下。


## 函数可以作为返回结果，就是一个函数对象，再进行调用才会返回结果
### 闭包
[简答闭包教学](https://blog.csdn.net/Saki_Python/article/details/136166366)
```python

def lazy_sum(*args):
    def sum():
        ax = 0
        for n in args:
            ax = ax + n
        return ax
    return sum

f = lazy_sum(1, 3, 5, 7, 9)
print(f)
print(f())
# 内部函数sum可以引用外部函数lazy_sum的参数和局部变量，当lazy_sum返回函数sum时，相关参数和变量都保存在返回的函数中，这种称为“闭包（Closure）”的程序结构

def count():
    fs = []
    for i in range(1, 4):
        def f():
             return i*i
        fs.append(f)
    return fs

f1, f2, f3 = count()
print(f1(), f2(), f3())
# 返回闭包时牢记一点：返回函数不要引用任何循环变量，或者后续会发生变化的变量。
```

```python
# 如果一定要引用循环变量怎么办？方法是再创建一个函数，用该函数的参数绑定循环变量当前的值，无论该循环变量后续如何更改，已绑定到函数参数的值不变
def count():
    def f(j):
        def g():
            return j*j
        return g
    fs = []
    for i in range(1, 4):
        fs.append(f(i)) # f(i)立刻被执行，因此i的当前值被传入f()
    return fs

f1, f2, f3 = count()
print(f1(), f2(), f3())
```
***使用闭包时，对外层变量赋值前，需要先使用nonlocal声明该变量不是当前函数的局部变量。***
```python
def inc():
    x = 0
    def fn():
        # nonlocal x
        x = x + 1
        return x
    return fn

f = inc()
print(f()) # 1
print(f()) # 2
# 出错 原因是x作为局部变量并没有初始化，直接计算x+1是不行的。但我们其实是想引用inc()函数内部的x，所以需要在fn()函数内部加一个nonlocal x的声明。加上这个声明后，解释器把fn()的x看作外层函数的局部变量，它已经被初始化了，可以正确计算x+1。

```
## 偏函数
```python
# 偏函数 把一个函数的某些参数给固定住了，返回一个新的函数，调用这个新函数会更简单
## 提出
def int2(x, base=2):
    return int(x, base) # 一个转换2进制的函数
#functools.partial就是帮助我们创建一个偏函数的，不需要我们自己定义int2()，可以直接使用下面的代码创建一个新的函数int2
import functools
int2=functools.partial(int,base=2)
print(int2("1000000"))
#也可以在函数调用时传入其他值：
print(int2("1000000",base=10))

#最后，创建偏函数时，实际上可以接收函数对象、*args和**kw这3个参数，当传入：
int2 = functools.partial(int, base=2)
# 实际上固定了int()函数的关键字参数base，也就是：
int2('10010')
# 相当于：
kw = { 'base': 2 }
int('10010', **kw)

max2=functools.partial(max,10)
# 实际上会把10作为*args的一部分自动加到左边，也就是：即
max2(5, 6, 7)
# 相当于：
args = (10, 5, 6, 7)
max(*args)
```
# 关于模块和包
一个abc.py的文件就是一个名字叫abc的模块，一个xyz.py的文件就是一个名字叫xyz的模块。
现在，假设我们的abc和xyz这两个模块名字与其他模块冲突了，于是我们可以通过包来组织模块，避免冲突。方法是选择一个顶层包名，比如mycompany，按照如下目录存放：
```python
mycompany
├─ __init__.py
├─ abc.py
└─ xyz.py

# 多级目录
mycompany
 ├─ web
 │  ├─ __init__.py
 │  ├─ utils.py
 │  └─ www.py
 ├─ __init__.py
 ├─ abc.py
 └─ utils.py
```
每一个包目录下面都会有一个__init__.py的文件，这个文件是必须存在的，否则，Python就把这个目录当成普通目录，而不是一个包。__init__.py可以是空文件，也可以有Python代码，因为__init__.py本身就是一个模块，而它的模块名就是mycompany。
mycompany.web也是一个模块，该模块对应的.py文件是web目录下的__init__.py。

> 注意当使用 from package import item 这种形式的时候，对应的 item 既可以是包里面的子模块（子包），或者包里面定义的其他名称，比如函数，类或者变量。 
> import 语法会首先把 item 当作一个包定义的名称，如果没找到，再试图按照一个模块去导入。如果还没找到，抛出一个 :exc:ImportError 异常。 
> 反之，如果使用形如 import item.subitem.subsubitem 这种导入形式，除了最后一项，都必须是包，而最后一项则可以是模块或者是包，但是不可以是类，函数或者变量的名字。

**导入语句遵循如下规则：如果包定义文件 __init__.py 存在一个叫做 __all__ 的列表变量，那么在使用 from package import * 的时候就把这个列表中的所有名字作为包内容导入。** 如果 `__all__` 真的没有定义，那么使用from sound.effects import *这种语法的时候，就不会导入包 sound.effects 里的任何子模块。他只是把包sound.effects和它里面定义的所有内容导入进来（可能运行`__init__.py`里定义的初始化代码）。

### 类似C++类私有成员或者私有函数
类似`__xxx__`这样的变量是特殊变量，可以被直接引用，但是有特殊用途，比如上面的`__author__`，`__name__`就是特殊变量，hello模块定义的文档注释也可以用特殊变量`__doc__`访问，我们自己的变量一般不要用这种变量名；
类似`_xxx`和`__xxx`这样的函数或变量就是非公开的（private），不应该被直接引用，比如`_abc`，`__abc`等；
外部不需要的函数私有函数或者说类里面的辅助函数就可以命名为`_function`。

## 文件操作
类似C++的文件操作，过程都是打开文件以某种模式，操作完之后关闭文件。操作函数也类似，也有一个文件指针的概念，可以调节。
处理文件操作，with关键字很good
```python
with open('test.txt','r') as f:
    print(f.read())
f.close() //这个保证会自动完成
```
with 语句实现原理建立在上下文管理器之上。

上下文管理器是一个实现` __enter__ `和 `__exit__` 方法的类。

使用 with 语句确保在嵌套块的末尾调用 `__exit__` 方法。

这个概念类似于 try...finally 块的使用。

> 在文件对象中定义了 `__enter__` 和` __exit__ `方法，即文件对象也实现了上下文管理器，首先调用 `__enter__ `方法，然后执行 `with` 语句中的代码，最后调用` __exit__ `方法。 即使出现错误，也会调用` __exit__ `方法，也就是会关闭文件流。

# 异常和错误

## try except
- try-finally 语句无论是否发生异常都将执行最后的代码。
```python
try:
    print('try...')
    r = 10 / 0
    print('result:', r)
except ZeroDivisionError as e:
    print('except:', e)
finally: # 无论是否抛出错误都会执行
    print('finally...')
print('END')
```
- 如果一个异常没有与任何的 except 匹配，那么这个异常将会传递给上层的 try 中。
- 一个`except`子句可以同时处理多个异常,这些异常将被放在一个括号里成为一个元组，例如:
```python
except (RuntimeError, TypeError, NameError):
    pass
```
- 最后一个except子句可以忽略异常的名称，它将被当作通配符使用。你可以使用这种方法打印一个错误信息，然后再次把异常抛出.
```python
except:
    print("Unexpected error:", sys.exc_info()[0])
    raise
```
- try/except 语句还有一个可选的 else 子句，如果使用这个子句，那么必须放在所有的 except 子句之后。else 子句将在 try 子句没有发生任何异常的时候执行。
```python
for arg in sys.argv[1:]:
    try:
        f = open(arg, 'r')
    except IOError:
        print('cannot open', arg)
    else:
        print(arg, 'has', len(f.readlines()), 'lines')
        f.close()
```
```python
try:
    runnob()
except AssertionError as error:
    print(error)
else:
    try:
        with open("file.log") as file:
            read_data=file.read()
    except FileNotFoundError as fnf_error:
        print(fnf_error)
finally:
    print("无论是否异常都会执行")
```
- raise 抛出异常
- python的异常也是类，捕获的时候能够捕获所有的子类。
```python
class Error(Exception):
    """Base class for exceptions in this module."""
    pass

class InputError(Error):
    """Exception raised for errors in the input.

    Attributes:
        expression -- input expression in which the error occurred
        message -- explanation of the error
    """

    def __init__(self, expression, message):
        self.expression = expression
        self.message = message

class TransitionError(Error):
    """Raised when an operation attempts a state transition that's not
    allowed.

    Attributes:
        previous -- state at beginning of transition
        next -- attempted new state
        message -- explanation of why the specific transition is not allowed
    """

    def __init__(self, previous, next, message):
        self.previous = previous
        self.next = next
        self.message = message
```
- 使用try...except捕获错误还有一个巨大的好处，就是可以跨越多层调用，比如函数main()调用bar()，bar()调用foo()，结果foo()出错了，这时，只要main()捕获到了
- logging模块可以非常容易地记录错误信息：
```python
import logging
def foo(s):
    return 10 / int(s)
def bar(s):
    return foo(s) * 2
def main():
    try:
        bar('0')
    except Exception as e:
        logging.exception(e)
main()
print('END')
```
## 抛出错误
需要抛出错误，根据需要，可以定义一个错误的class，选择好继承关系，然后，用raise语句抛出一个错误的实例。以选择Python已有的内置的错误类型（比如ValueError，TypeError），尽量使用Python内置的错误类型。
在捕获到错误后，经常再次上抛，给顶层调用者处理，raise语句如果不带参数，就会把当前错误原样抛出。此外，在except中raise一个Error，还可以把一种类型的错误转化成另一种类型：
```python
try:
    10 / 0
except ZeroDivisionError:
    raise ValueError('input error!')
```
只要是合理的转换逻辑就可以，但是，决不应该把一个IOError转换成毫不相干的ValueError。

# Python 面向对象 类...

`__init__()`方法类似C++构造函数，

类中的方法都带有一个特殊参数：`self`，类似C++的this指针，一定是第一个参数
Python中定义的私有成员带下划线：`__weigth`

`__name__`类似这种双下划线开头和结尾的是特殊变量

## 继承

```python
class Student(OBJECT):
    pass # (父类)
```

### 有限的多重继承

```python
class Student(OBJECT1,ob2,ob3):
    pass # (父类)
#若是父类中有相同的方法名，而在子类使用时未指定，python从左至右搜索 即方法在子类中未找到时，从左到右查找父类中是否包含方法。
```

### 也可以重写父类的函数

```python
class Parent:  # 定义父类
    def myMethod(self):
        print('调用父类方法')

class Child(Parent):  # 定义子类
    def myMethod(self):
        print('调用子类方法')
c = Child()  # 子类实例
c.myMethod()  # 子类调用重写方法
super(Child, c).myMethod()  # 用子类对象调用父类已被覆盖的方法  super() 函数是用于调用父类(超类)的一个方法。
```

```python
class A:
    def add(self,x):
        y=x+1
        print(y)
class B(A):
    def add(self,x):
        super(B,self).add(x) //调用父类的方法
        
#!/usr/bin/python
# -*- coding: UTF-8 -*-
 
class FooParent(object):
    def __init__(self):
        self.parent = 'I\'m the parent.'
        print ('Parent')
    
    def bar(self,message):
        print ("%s from Parent" % message)
 
class FooChild(FooParent):
    def __init__(self):
        # super(FooChild,self) 首先找到 FooChild 的父类（就是类 FooParent），然后把类 FooChild 的对象转换为类 FooParent 的对象
        super(FooChild,self).__init__()    
        print ('Child')
        
    def bar(self,message):
        super(FooChild, self).bar(message) # 或者FooParent.bar(self,message) 同样可以调用
        print ('Child bar fuction')
        print (self.parent)
 
if __name__ == '__main__':
    fooChild = FooChild()
    fooChild.bar('HelloWorld')
```

## 运算符重载

Python同样支持运算符重载，我们可以对类的专有方法进行重载：

```python
#!/usr/bin/python3
 
class Vector:
   def __init__(self, a, b):
      self.a = a
      self.b = b
 
   def __str__(self):
      return 'Vector (%d, %d)' % (self.a, self.b)
   
   def __add__(self,other):
      return Vector(self.a + other.a, self.b + other.b)
   __repr__=__str__  # 解释器易显示的效果，和__str__经常一样
       
 
v1 = Vector(2,10)
v2 = Vector(5,-2)
print (v1 + v2) # 这里先涉及到+的重载，即__add__() 然后涉及一个累心转换 __str__()
'''
如果一个类想被用于for ... in循环，类似list或tuple那样，就必须实现一个__iter__()方法，该方法返回一个迭代对象，然后，Python的for循环就会不断调用该迭代对象的__next__()方法拿到循环的下一个值，直到遇到StopIteration错误时退出循环。
'''
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
f= Fib()
print(next(f))
print(next(f))
print(next(f))
print(f[0])
print(f[:7])
```

似乎常规方法都是调用的特殊函数，例如+，-调用的是`__add__(),__sub__(),__mul__(),__div__(),__eq__(),__ne__(),__lt__(),__gt__(),__le__(),__ge__()`等，这些方法都是Python内置的函数，可以直接调用。
len()调用__len__(),eg:
```python
len("abc") 
"abc".__len()__
class MyDog(object):
     def __len__(self):
         return 100
dog = MyDog()
print(len(dog)) # 自定义类如果也想调用，就要重载函数__len__()，类似C++自定义类运算符或者函数重载了。
```
#### __call__
这个类似C++实现operator()(),这样的对象实列是可以调用的，例如：
```python
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

```
## 动态绑定

和静态语言不同，Python允许对实例变量绑定任何数据，也就是说，对于两个实例变量，虽然它们都是同一个类的不同实例，但拥有的变量名称都可能不同：

```python
class FlexibleClass:
    def __init__(self, name):
        self.name = name  # 所有实例都会初始化 'name' 变量

# 创建两个实例
obj1 = FlexibleClass("Object 1")
obj2 = FlexibleClass("Object 2")

# 动态绑定变量
obj1.age = 25  # 只为 obj1 绑定了 'age'
obj2.city = "New York"  # 只为 obj2 绑定了 'city'

# 动态访问变量
print(f"{obj1.name} is {obj1.age} years old.")  # 访问 obj1 的动态变量
print(f"{obj2.name} lives in {obj2.city}.")  # 访问 obj2 的动态变量

# 尝试访问不存在的变量（会引发 AttributeError）
try:
    print(obj1.city)
except AttributeError as e:
    print(f"Error: {e}")

try:
    print(obj2.age)
except AttributeError as e:
    print(f"Error: {e}")

```
### 动态语言
传入参数时不一定需要类型匹配，因为python是动态语言，可以动态绑定变量。
只要有类似的成员或者方法就可以：eg：
```python
class Animal(object):
    def run(self):
        print('Animal is running...')

def run_twice(animal):
    animal.run()

class Timer(object):
    def run(self):
        print("Timer is running")

run_twice(Timer())
run_twice(Animal())
```
### 动态绑定方法
```python
class Student(object):
    pass
s=Student()
s.name="Bart" # 动态给实例绑定一个属性
def set_age(self, age): # 定义一个函数作为实例方法
    self.age=age
from types import MethodType
s.set_age=MethodType(set_age,s) # 给实例绑定一个方法
s.set_age(25) # 调用实例方法
# 但是给一个实例绑定的方法，对另一个实例是不起作用的：
s2=Student() # 创建新的实例
# s2.set_age(25) # 尝试调用方法 会报错
# 为了给所有实例都绑定方法，可以给class绑定方法：
Student.set_age=set_age # 给class绑定方法后，所有实例均可调用
```
#### 使用__slots__实现限制实例的属性
```python
class Student(object):
    __slots__ = ('name', 'age') # 用tuple定义允许绑定的属性名称
s = Student() # 创建新的实例
s.name = 'Michael' # 绑定属性'name'
s.age = 25 # 绑定属性'age'
# s.score = 99 # 绑定属性'score'

class GraduateStudent(Student):
    pass
g = GraduateStudent() # 创建新的实例
g.score = 9999 # 允许
```
> 值得注意的是，使用__slots__要注意，__slots__定义的属性仅对当前类实例起作用，对继承的子类是不起作用的：除非在子类中也定义``__slots__``，这样，子类实例允许定义的属性就是自身的``__slots__``加上父类的``__slots__``。
#### 使用@property 完成属性的获取和设置
装饰器@property可以将一个方法变成属性调用，此时方法名就相当于属性名。
```python
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
```
>特别注意，在使用@property时，我们把一个getter方法变成属性，此时，@property本身又创建了另一个装饰器@score.setter，负责把一个setter方法变成属性赋值，于是，我们就拥有一个可控的属性操作：**但是一定要注意方法的名称，加入上述例子当中，成绩属性是score,getter()、setter()方法也是score()，那么就会引发错误，函数中又调用self.score  (这里不是简单对属性赋值了，他是否又会调用装饰器修饰后的函数呢，因为修饰后的函数方法可以类似属性赋值和访问)**。
```python
class Student(object):
    # 方法名称和实例变量均为birth:
    @property
    def birth(self):
        return self.birth
#这是因为调用s.birth时，首先转换为方法调用，在执行return self.birth时，又视为访问self的属性，于是又转换为方法调用self.birth()，造成无限递归，最终导致栈溢出报错RecursionError。
```
## 操作对象的状态 getattr() setattr() hasattr()
```python
# hasattr(obj, 'x') # 有属性'x'吗？
# True
# obj.x
# # 9
# hasattr(obj, 'y') # 有属性'y'吗？
# # False
# setattr(obj, 'y', 19) # 设置一个属性'y'
# hasattr(obj, 'y') # 有属性'y'吗？
# # True
# getattr(obj, 'y') # 获取属性'y'
# # 19
# obj.y # 获取属性'y'

class Animal(object):
    a=0
    b=""
    c=[]
    d={}
    e=set()
    f=()
    def run(self):
        print('Animal is running...')
    def __getattr__(self,attr):
        if attr=="score":
            return 99 # or返回函数也可以 return lambda:5
    def __len__(self):
        return 100
mao=Animal()
print(hasattr(mao,'a'))
print(hasattr(mao,'g'))
for i in dir(mao):
    print(type(getattr(mao,i)))

setattr(mao,"a",15)
print(getattr(mao,"a"))
fn=getattr(mao,"run")
fn() #等价于 mao.run()

def readAnimal(p):
    if hasattr(p,"a"):
        print(p.a)
    return None
# 19
```
> 当调用不存在属性时，比如score，Python解释器会试图调用__getattr__(self, 'score')来尝试获得属性，这样，我们就有机会返回score的值；只有在没有找到属性的情况下，才调用__getattr__，已有的属性，比如name，不会在__getattr__中查找。
```python
class Chain(object):
    def __init__(self,path=""):
        self._path=path
    def __getattr__(self,path):
        return Chain("%s/%s" % (self._path,path))
    def __str__(self):
        return self._path
    __repr__=__str__
#  作用就是，可以针对完全动态的情况作调用。   无论API怎么变，SDK都可以根据URL实现完全动态的调用，而且，不随API的增加而改变！
>>> Chain().status.user.timeline.list
'/status/user/timeline/list'
```
## 类属性和实例属性
类本身有属性，实例化对象也可以绑定属性，并不会覆盖类属性
```python
class Student(object):
    name = 'Student'
s = Student() # 创建实例s
print(s.name) # 打印name属性，因为实例并没有name属性，所以会继续查找class的name属性  :Student
print(Student.name) # 打印类的name属性  :Student
s.name = 'Michael' # 给实例绑定name属性
print(s.name) # 打印name属性，因为实例的name属性优先级比类的高，因此，它会屏蔽掉类的name属性
print(Student.name) # 但是类属性并未消失，用Student.name仍然可以访问  :Student
del s.name # 如果删除实例的name属性
print(s.name) # 由于实例的name属性被删除了，再次调用s.name，去查找class的name属性，因此显示的是类的name属性  :Student
```
**实际当中，不要对实例属性和类属性使用相同的名称**
# python 的namespace和作用于
## 命名空间

三种

- 内置名称：语言内置的名称，比如函数名abs，异常名称等，就是系统的
- 全局名称：模块中定义的名称，记录了模块的变量，包括函数、类、其它导入的模块、模块级的变量和常量。全局变量
- 局部名称：函数中定义的名称，记录了函数的变量，包括函数的参数和局部定义的变量。（类中定义的也是）

假设我们要使用变量 runoob，则 Python 的查找顺序为：**局部的命名空间 -> 全局命名空间 -> 内置命名空间**。

如果找不到变量 runoob，它将放弃查找并引发一个 NameError 异常:

## 作用域

在一个 python 程序中，直接访问一个变量，会从内到外依次访问所有的作用域直到找到，否则会报未定义的错误。变量的作用域决定了在哪一部分程序可以访问哪个特定的变量名称。Python 的作用域一共有4种，分别是：

- **L（Local）**：最内层，包含局部变量，比如一个函数/方法内部。
- **E（Enclosing）**：包含了非局部(non-local)也非全局(non-global)的变量。比如两个嵌套函数，一个函数（或类） A 里面又包含了一个函数 B ，那么对于 B 中的名称来说 A 中的作用域就为 nonlocal。
- **G（Global）**：当前脚本的最外层，比如当前模块的全局变量。
- **B（Built-in）**： 包含了内建的变量/关键字等，最后被搜索。

规则顺序： **L –> E –> G –> B**。在局部找不到，便会去局部外的局部找（例如闭包），再找不到就会去全局找，再者去内置中找。

![image-20250105201722418](image-20250105201722418.png)

```python
g_count = 0  # 全局作用域
def outer():
    o_count = 1  # 闭包函数外的函数中
    def inner():
        i_count = 2  # 局部作用域
```

内置作用域是通过一个名为 builtin 的标准模块来实现的，但是这个变量名自身并没有放入内置作用域内，所以必须导入这个文件才能够使用它。在Python3.0中，可以使用以下的代码来查看到底预定义了哪些变量:

```python
import builtins
print(dir(builtins))
```

Python 中只有模块（module），类（class）以及函数（def、lambda）才会引入新的作用域，其它的代码块（如 if/elif/else/、try/except、for/while等）是不会引入新的作用域的，也就是说这些语句内定义的变量，外部也可以访问，如下代码:

```python
>>> if True:
...  msg = 'I am from Runoob'
... 
>>> msg
'I am from Runoob'
>>> 
```

### 全局变量和局部变量

```python
total = 0 # 这是一个全局变量
# 可写函数说明
def sum( arg1, arg2 ):
    #返回2个参数的和."
    total = arg1 + arg2 # total在这里是局部变量.
    print ("函数内是局部变量 : ", total)
    return total
 
#调用sum函数
sum( 10, 20 )
print ("函数外是全局变量 : ", total) #
#函数内是局部变量 :  30
#函数外是全局变量 :  0
```

### global 和 nonlocal关键字

当内部作用域想修改外部作用域的变量时，就要用到 global 和 nonlocal 关键字了。如果要修改嵌套作用域（enclosing 作用域，外层非全局作用域）中的变量则需要 nonlocal 关键字了.

```python
num = 1
def fun1():
    global num  # 需要使用 global 关键字声明
    print(num) 
    num = 123
    print(num)
fun1()
print(num)
#1
#123
#123

def outer():
    num = 10
    def inner():
        nonlocal num   # nonlocal关键字声明
        num = 100
        print(num)
    inner()
    print(num)
outer()
#100
#100
```
# 枚举类
```python
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
```
# 元类
## 动态创建   --- type()
type()函数既可以返回一个对象的类型，又可以创建出新的类型，比如，我们可以通过type()函数创建出Hello类，而无需通过class Hello(object)...的定义：
```python
>>> def fn(self, name='world'): # 先定义函数
...     print('Hello, %s.' % name)
...
>>> Hello = type('Hello', (object,), dict(hello=fn)) # 创建Hello class
>>> h = Hello()
>>> h.hello()
Hello, world.
>>> print(type(Hello))
<class 'type'>
>>> print(type(h))
<class '__main__.Hello'>
```
要创建一个class对象，type()函数依次传入3个参数：
1. class的名称；
2. 继承的父类集合，注意Python支持多重继承，如果只有一个父类，别忘了tuple的单元素写法；
3. class的方法名称与函数绑定，这里我们把函数fn绑定到方法名hello上。
## 元类 metaclass
[元类和ORM等](https://liaoxuefeng.com/books/python/oop-adv/meta-class/index.html)
# 简单调试、测试等
## 断言
```python
def foo(s):
    n = int(s)
    assert n != 0, 'n is zero!'
    return 10 / n
def main():
    foo("0")
main() # 'n is zero!'
```
如果断言失败，assert语句本身就会抛出AssertionError：
## logging
```python
import logging
logging.basicConfig(level=logging.INFO)
s="0"
n=int(s)
logging.info("n = %d"%n)
print(10/n)
```
## pdb and pdb.set_trace()
```python
# err.py
import pdb

s = '0'
n = int(s)
pdb.set_trace() # 运行到这里会自动暂停
print(10 / n)
```
## 单元测试
```python
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
# 1引入unittest模块
# 需要编写一个测试类，从unittest.TestCase继承。以test开头的方法就是测试方法，不以test开头的方法不被认为是测试方法，测试的时候不会被执行。
import unittest

class TestDict(unittest.TestCase):
    def setUp(self):
        print('setUp...')

    def tearDown(self):
        print('tearDown...')
    def test_init(self):
        d = Dict(a=1, b='test')
        self.assertEqual(d.a, 1)
        self.assertEqual(d.b, 'test') # 期待相等
        self.assertTrue(isinstance(d, dict))

    def test_key(self):
        d = Dict()
        d['key'] = 'value'
        self.assertEqual(d.key, 'value')

    def test_attr(self):
        d = Dict()
        d.key = 'value'
        self.assertTrue('key' in d)
        self.assertEqual(d['key'], 'value')

    def test_keyerror(self):
        d = Dict()
        with self.assertRaises(KeyError): # 期待抛出KeyError异常
            value = d['empty']

    def test_attrerror(self):
        d = Dict()
        with self.assertRaises(AttributeError):
            value = d.empty
```
>可以在单元测试中编写两个特殊的setUp()和tearDown()方法。这两个方法会分别在每调用一个测试方法的前后分别被执行。
## 文档测试
ython内置的“文档测试”（doctest）模块可以直接提取注释中的代码并执行测试。doctest严格按照Python交互式命令行的输入和输出来判断测试结果是否正确。只有测试异常的时候，可以用...表示中间一大段烦人的输出。
```python
# mydict2.py
class Dict(dict):
    '''
    Simple dict but also support access as x.y style.

    >>> d1 = Dict()
    >>> d1['x'] = 100
    >>> d1.x
    100
    >>> d1.y = 200
    >>> d1['y']
    200
    >>> d2 = Dict(a=1, b=2, c='3')
    >>> d2.c
    '3'
    >>> d2['empty']
    Traceback (most recent call last):
        ...
    KeyError: 'empty'
    >>> d2.empty
    Traceback (most recent call last):
        ...
    AttributeError: 'Dict' object has no attribute 'empty'
    '''
    def __init__(self, **kw):
        super(Dict, self).__init__(**kw)

    def __getattr__(self, key):
        try:
            return self[key]
        except KeyError:
            raise AttributeError(r"'Dict' object has no attribute '%s'" % key)

    def __setattr__(self, key, value):
        self[key] = value

if __name__=='__main__':
    import doctest
    doctest.testmod()
```
# 序列化
## pickle
```python
# 把变量从内存中变成可存储或传输的过程称之为序列化，在Python中叫pickling，序列化之后，就可以把序列化后的内容写入磁盘，或者通过网络传输到别的机器上。 反过来，把变量内容从序列化的对象重新读到内存里称之为反序列化，即unpickling。
import pickle
d=dict(name="Bob",age=20,score=88)
# pickle.dumps(d)
# 把任意对象序列化成一个bytes，然后，就可以把这个bytes写入文件。或者用另一个方法pickle.dump()直接把对象序列化后写入一个file-like Object：
# with open("dump.txt","wb") as f:
#     pickle.dump(d,f)
# 当我们要把对象从磁盘读到内存时，可以先把内容读到一个bytes，然后用pickle.loads()方法反序列化出对象，也可以直接用pickle.load()方法从一个file-like Object中直接反序列化出对象。我们打开另一个Python命令行来反序列化刚才保存的对象：

with open("dump.txt","rb") as f:
    bytes_data=f.read()
    print(pickle.loads(bytes_data))
```
## json
```Python
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
'''
简单来说，序列化dump() 文件，dumps() 字符串，反序列化load() 文件，loads() 字符串 ,注意的就是对象的类型，以及对应的转换函数
'''

```