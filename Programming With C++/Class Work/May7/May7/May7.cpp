// May7.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using std::cout;
using std::cin;
using std::endl;

int _tmain(int argc, _TCHAR* argv[])
{
	int x = 10;
	int y = 20;
	int *ptr1;
	int *ptr2;

	ptr1 = &x;
	ptr2 = &y;

	cout << "x = " << x << "y = " << y << endl;
	cout << "ptr1 points to " << *ptr1 << " ptr2 points to " << *ptr2 << endl;


	*ptr1 = 50;
	cout << "Now we have " << endl;
	cout << "x = " << x << "y = " << y << endl;
	cout << "ptr1 points to " << *ptr1 << " ptr2 points to " << *ptr2 << endl;


	system("pause");
	return 0;
}

