//This header file defines my date class
//Written by Jonathan Moore

#include <iostream>
#include <string>

using std::cin;
using std::cout;
using std::endl;
using std::string;

class Date
{ 
public:

Date( int y, int m, int d);

void setYear(int y);
void setMonth(int m);
void setDay(int d);
void nextDay();

int getYear();
int getMonth();
int getDay();

void displayDate1();
void displayDate2();
void displayDate3();


private:
	int year;
    int month;
	int day;

	

};
