// march28.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using std::cin;
using std::cout;
using std::endl;

int myComp( int x, int y );

int _tmain(int argc, _TCHAR* argv[])
{
	int a, b, c;
	cout << "Enter a Number: ";
	cin a;
	cout endl;
	cout << "Enter another: ";
	cin >> b;
	cout << endl;

	c= myComp( a, b);

	cout << "The Sum of " << a << "and" << b << " is " << c << endl;

	system("pause");
	return 0;
}

int myComp (int x, int y)
{	 
	return x + y;
}



