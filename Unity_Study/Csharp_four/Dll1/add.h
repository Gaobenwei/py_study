#pragma once

#include<iostream>

extern "C" {
	__declspec(dllexport) int Add(int a, int b);
}
