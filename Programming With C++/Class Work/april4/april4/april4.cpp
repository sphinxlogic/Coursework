// april4.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using std::cin;
using std::cout;
using std::endl;

int x = 30;

int _tmain(int argc, _TCHAR* argv[])
{
	int x = 10;

	cout << "before loop: " << x << endl;

	for (int i = 1; i<=5; i++)
	{
		int x = 2;
		cout << "in loop: " << x << endl;
	}

	cout << "after loop: " << x << endl;

	cout << "what does this do? " << ::x << endl;

	system("pause");
	return 0;
}

