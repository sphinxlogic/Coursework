// May7_2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "stdafx.h"
#include <iostream>

using std::cout;
using std::cin;
using std::endl;

int _tmain(int argc, _TCHAR* argv[])
{

	for (int n =1; n <= 5; n++)
	{
		for (int m=n; m <= 5 ; m++)
		{
			cout << m;
		}

		cout << endl;
	}

	system("pause");
	return 0;
}

