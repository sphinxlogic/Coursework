// by Jonathan Moore
//This program takes an integer and determines wheather its even or odd.

#include "stdafx.h"
#include <iostream>

using std::cout;
using std::cin;
using std::endl;

int _tmain(int argc, _TCHAR* argv[])
{
	int number;
	cout << "Please enter a number ";
	cin >> number; 
	if (number % 2 == 0 )
		cout << "The number is even "<< endl;
	else 
		cout << "The number is odd "<< endl;

	system("pause");
	return 0;
}

