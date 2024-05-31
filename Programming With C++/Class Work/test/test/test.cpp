// test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using std::cin;
using std::cout;
using std::endl;
using std::showpoint;
using std::fixed;

#include <iomanip>
using std::setprecision;
using std::setw;

const int weeksPerYear = 52;

int _tmain(int argc, _TCHAR* argv[])
{

	int vehicleMileage1;
    int vehicleMileage2;
	double fuelCost;
	int milesDriven;
	double weeklyCost1;
	double yearlyCost1;
    double weeklyCost2;
	double yearlyCost2;

	cout << "Enter Mileage for vehicle 1: ";
	cin >> vehicleMileage1;
	cout << endl;
	cout << "Enter Mileage for vehicle 2: ";
	cin >> vehicleMileage2;
	cout << endl;
	cout << "Enter fuel Cost";
	cin >> fuelCost;
	cout << endl;
	cout << "Enter miles Drivenper week";
	cin >> milesDriven;
	cout << endl;

	weeklyCost1 = static_cast<double>(milesDriven)/ vehicleMileage1 * fuelCost;
	yearlyCost1 = weeklyCost1 * weeksPerYear;
	weeklyCost2 = static_cast<double>(milesDriven)/ vehicleMileage2 * fuelCost;
	yearlyCost2 = weeklyCost2 * weeksPerYear;

	cout << setprecision(2) << fixed << showpoint;
	cout << setw(26) << "Fuel Cost: $" << fuelCost << endl;
	cout << setw(25) << "Weekly Miles Driven: " << milesDriven << endl;

	cout << endl;
	cout << setw(30) << "Weekly Cost" << setw(20) << "Yearly Cost" << endl;
	cout << "Vehicle 1 "
		 << setw(18) << weeklyCost1 
		 << setw(20)<< yearlyCost1 << endl;
	cout << "Vehicle 2 "
		 << setw(18) << weeklyCost2 
		 << setw(20) << yearlyCost2 << endl;
	

	system("pause");
	return 0;
}

