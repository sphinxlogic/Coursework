// April9.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
//#include <ctime>
//#include <cstdlib>
//using std::srand;
//using std::rand;
//#include <ctime>
//using std::time;

//switch (num)
//{
//case1 : cout << "ace";
using std::cin;
using std::cout;
using std::endl;

template < typename T >
T abs(T num )
{
	if (num < 0 )
		return -num;
	else
		return num;
}


int _tmain(int argc, _TCHAR* argv[])
{
	int x;
	cout << "Enter an integer: ";
	cin >> x;
	cout << endl;
	cout << "The absolute value of " << x
		<< "is" << abs(x) << endl;

	double y;
	cout << "Enter an double: ";
	cin >> y;
	cout << endl;
	cout << "The absolute value of " << x
		<< "is" << abs(y) << endl;

	system("pause");
	return 0;
}

