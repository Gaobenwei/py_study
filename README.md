# python json测试
## 首次完成
1. str转json，`loads(str)` 方法
2. dict转str,`dumps(dict)` 方法
3. 测试用例文件test.txt存放原始数据，读入为str，loads后输出dict,在dumps后输出str。

## 二次提交
1. 加了抛出异常捕获后的处理，考虑有可能被其他module调用，在loads()处理了所有辅助函数抛出的异常，在main函数只捕获错误区分一下通知是哪个接口出错，现在的处理就是简单的:打印错误信息，提示缺少的字符。
2. 发现一处错误，dumps()中list 和 tuple 输出的都是`[]` ,改了一下
3. 采用__func()的形式隐藏了所有辅助函数，只提供了对外接口，loads() dumps() 

# Unity_Study
## C#简易学习记录
便于不同主机同步学习记录
## Unity简易学习记录
等待完成C#前三阶段学习，即刻开始