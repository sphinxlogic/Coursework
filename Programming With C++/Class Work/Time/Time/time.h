//time.h
//This is my Time class for chapter 2
//Written by Jonathan Moore 2.11.08

#include <iostream>

using std::cin;
using std::cout;
using std::endl;

class Time
{ 
public:
Time( int h, int m, int s);

void setHour( int h);
void setMinute(int m);
void setSecond(int s);

int getHour();
int getMinute();
int getSecond();

void display();


private:
	int hour;
    int minute;
	int second;

};
