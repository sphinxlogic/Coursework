//This file contains functionality for my Date class
//Written by Jonathan Moore

#include <iostream>
#include "stdafx.h"
#include "date.h"

using std::cout;
using std::endl;

Date::Date(int y, int m, int d)
{
	setYear(y);
	setMonth(m);
	setDay(d); 
}
void Date::setYear(int y)
{
	year = y;
}

void Date::setMonth(int m)
{
	month = m;

	if (month > 12)
	{
		month = 1;
	}
	else if (month < 1)
	{
		month = 1;
	}
}

void Date::setDay(int d)
{
	day = d;
}

int Date::getYear()
{
	return year;
}
int Date::getMonth()
{
	return month;
}

int Date::getDay()
{
	return day;
}

void Date::displayDate()
{
	cout << "The Date is  " << year << "/" << month << "/" << day << endl;
}
