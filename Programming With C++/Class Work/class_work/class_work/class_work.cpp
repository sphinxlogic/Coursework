// class_work.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <cstdlib>
#include <ctime>

using std::cout;
using std::cin;
using std::endl;
using std::rand;
using std::srand;
using std::time;


int _tmain(int argc, _TCHAR* argv[])
{	
	int largest = 0;
	int number;

	srand( time (0));

	for(int i = 1; i < 100; i++)
	{
		number = rand();
		cout << number << ", ";
		if (number > largest)
		{
			largest = number;
		}
	}
		cout << endl;
		system("pause");
		cout << "The largest number is " << largest << endl;
		system("pause");

	return 0;
}

