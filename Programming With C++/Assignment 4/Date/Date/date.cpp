//This file contains functionality for my Date class
//Written by Jonathan Moore


#include "stdafx.h"
#include "date.h"
#include <iostream>


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

	if (year >= 1900)
	{
       year = y;
	}
	else
	{
		year = 1900;
	}

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

	if (day <= 30)
	{
		day = d;
	}
	else
	{
		day = 30;
	}

}

void Date::nextDay()
{
	if (day >=	1)
	{
		day = day + 1;

		if (day > 30)
		{
			day = 1;
			month++;
		}
	}

	if (month > 12)
	{
		month = 1; 
	    year++;
	}
		
	
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
// Year, Month, Day format
void Date::displayDate1()
{		
    cout << "The Date is " << getYear() << "/" << getMonth() << "/" << getDay() << endl;
		
}// Month, Day, Year format
void Date::displayDate2()
{
	cout << "The Date is " << getMonth() << "/" << getDay() << "/" << getYear() << endl;
}
// Day, Month, Year format
void Date::displayDate3()
{
	cout << "The Date is " << getDay() << "/" << getMonth() << "/" << getYear() << endl;

}

