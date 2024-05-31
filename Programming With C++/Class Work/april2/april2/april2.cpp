// april2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using std::cout; 
using std::cin;
using std::endl;
using std::fixed;
using std::showpoint;

#include<iomanip>
using std::setprecision;
using std::setw;

void getUserChoice( int &answer);
void displayFahrToCel();
void displayCelToFahr();
bool equal (int a, int b);
double fahrToCel(double fahr);
double celToFahr(double cel);


int _tmain(int argc, _TCHAR* argv[])
{
	int answer;
	//find out which conversion user wants
	getUserChoice(answer);
	//display appropriate conversion table
	switch(answer)
	{
	case 1 : displayFahrToCel();
				break;
	case 2 : displayCelToFahr();
				break;
	default : cout << "Not an Appropriate choice" << endl;
	}
	system("pause");
	return 0;
}

void getUserChoice( int &answer)
{
	cout << "Which table do you want to see?" << endl;
	cout << " Type 1 for Fahrenheit to Celsius." << endl;
	cout << " Type 2 for Celsius to Fahrenheit"  << endl;
	cout << "Choice: ";
	cin >> answer;
}

void displayFahrToCel()
{
	cout << "Fahrenheit" << setw(20) << "Celsius" << endl;
	cout << setprecision(2) << fixed << showpoint;
	for (int fahr = 32; fahr <=212; fahr++)
	{
		cout << setw(7)<<fahr << setw(15)<<  fahrToCel(fahr) << endl;
	}
}

void displayCelToFahr()
{
	cout << "Celsius" << setw(15) << "Fahrenheit" << endl;
	cout << setprecision(2) << fixed << showpoint;
	for (int cel = 0; cel <= 100; cel++)
	{
		cout << setw(5) << cel << setw(14) << celToFahr(cel) << endl;
		if (cel + 1 % 20 == 0)
			system("pause");
	}
	
}


double fahrToCel(double fahr)
{
	return( fahr - 32 ) * 5 / 9;
}

double celToFahr(double cel)
{
	return cel * 9 / 5 + 32;
}

bool equal ( int a, int b)
{
	if(a == b)
		return true;
	else 
		return false;
}








