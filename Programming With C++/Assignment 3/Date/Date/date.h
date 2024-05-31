


#include <iostream>

using std::cin;
using std::cout;
using std::endl;

class Date
{ 
public:
Date( int y, int m, int d);

void setYear(int y);
void setMonth(int m);
void setDay(int d);

int getYear();
int getMonth();
int getDay();

void displayDate();


private:
	int year;
    int month;
	int day;

};
