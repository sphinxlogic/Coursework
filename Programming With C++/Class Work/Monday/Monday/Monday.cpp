// Monday.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include <iostream>

using std::cout;
using std::cin;
using std::endl;

int _tmain(int argc, _TCHAR* argv[])
{
	int counter = 1;
	int grade;
	int total = 0; 

	
	while(counter <= 5)
	{
		cout << "Enter grade #" << counter << ": ";
		cin  >> grade;
		total = total + grade;

		counter = counter + 1;
	}
	
	cout << "The total for the grades is " << total << endl;

	int avg = total /5;

	cout << "The average grade is  " << avg << endl;

	system("pause");
	return 0;
}

