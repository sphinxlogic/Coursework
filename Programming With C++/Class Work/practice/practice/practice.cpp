// practice.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include <iostream>

using std::cout;
using std::cin;
using std::endl;

#include <iomanip>
using std::setw;


int _tmain(int argc, _TCHAR* argv[])
{
	int lineLen;

	cout << "What size line?";
	cin >> lineLen;
	cout << endl;

	for(int i = 1; i <= lineLen; i++)
	{
		cout << "*";
	}

	cout << endl << endl;

	//draw verticle line
	for (int i = 1; i <= lineLen; i++)
	{
		cout << "*";
		cout << endl;
	}

	//draw angle line
	for (int i = 1; i <= lineLen; i++)
	{
		cout << setw(i) << "*";
		cout << endl;
	}

	//draw angle line 2
	for (int i = 1; i <= lineLen; i++)
	{
		for (int spaceCount = 1; spaceCount <= i - 1; spaceCount++)
		{
			cout << " ";
		}
		cout << "*";
		cout << endl;
	}

	//darw angle line 3
	for (int i = lineLen; i >= 1; i--)
	{
		cout << setw(i) << "*";
		cout << endl;
	}

	system("pause");
	return 0;
}

