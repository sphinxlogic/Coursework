// Convert.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using std::cout;
using std::cin;
using std::endl;

int convertCtoF(int c);
double convertCtoF(double c);
int convertFtoC(int f);


int _tmain(int argc, _TCHAR* argv[])
{
	int c;
	int f;

	cout << "Enter a Celcius Temp: ";
	cin >> c;
	cout << "The Far. temp is " << convertFtoC(c)<< endl;

	system("pause");
	return 0;
}

int convertCtoF(int c)
{
	return 9/5 * c + 32;
}

double convertCtoF(double c)
{
	return 1.8 * c + 32;
}

int convertFtoC(int f)
{
	return 5/9 * f + 32; 
}

