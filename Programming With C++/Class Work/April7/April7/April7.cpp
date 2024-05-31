// April7.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using std::cin;
using std::cout;
using std::endl;

int factorial(int);
int factorial2(int );

int _tmain(int argc, _TCHAR* argv[])
{
	cout << "Enter a number ";

	int num;
	cin >> num;
	cout << endl;

	cout << num << "! is " << factorial(num) << endl;

	system("pause");
	return 0;
}

int factorial( int n)
{
	int product = 1;
	for ( int i= 1; i <=n; i++)
	{
		product *=i;

		
	}
		return product;
}

int factorial2(int n )
{
	if (n==1)
	{
		return 1;
	}

	else 
	{
		return n *factorial2(n-1);
	}
	
}

