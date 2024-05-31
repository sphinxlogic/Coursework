//This is the main program that will be used 
//to test my Time class

#include <iostream>
#include "stdafx.h"
#include "time.h"

using std::cout;
using std::endl;

Time::Time( int h, int m, int s)
{
	setHour( h );
	setMinute( m );
	setSecond( s); 
}

void Time::setHour( int h)
{
	hour = h;
	if (hour < 0)
	{
		hour = 0;
		cout << "Invalid hour, Set to zero\n";
	}
	if (hour > 23)
		hour = 0;
}
void Time::setMinute(int m)
{
	minute= m;
	if (minute < 0)
		minute = 0;
	if (minute > 59)
		minute = 0;
}
void Time::setSecond(int s)
{
	second = s;
	if (second < 0)
		second = 0;
	if (second > 59)
		second = 0;
}

int Time::getHour()
{
	return hour;
}
int Time::getMinute()
{
	return minute;
}

int Time::getSecond()
{
	return second;
}

void Time::display()
{
	cout << "The Time is  " << hour << ":" << minute << ":" << second << endl;
}