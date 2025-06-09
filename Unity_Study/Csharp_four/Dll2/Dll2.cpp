// Dll2.cpp : 定义 DLL 的导出函数。
//

#include "pch.h"
#include "framework.h"
#include "Dll2.h"


// 这是导出变量的一个示例
DLL2_API int nDll2=0;

// 这是导出函数的一个示例。
DLL2_API int fnDll2(void)
{
    return 0;
}

// 这是已导出类的构造函数。
CDll2::CDll2()
{
    return;
}
