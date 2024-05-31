// maintest.cpp
// written by cae 2/13/08

// This is the main program that you can use to test your date class.
//
// Note: It expects the parameaters to initialize date objects to be
// in the order year, month day. 

#include <iostream>
#include "stdafx.h"
#include "date.h"

using std::cout;
using std::cin;
using std::endl;


int _tmain(int argc, _TCHAR* argv[])
{
    // Just setting an arbitrary value
    cout << "Let's create a date and set it to  Jan 1, 2008\n";
    Date newYearsDay( 2008, 1, 1 );
    newYearsDay.displayDate();
    cout << endl;
    
    // Using the same value to test out the get functions
    cout << "Let's test the get functions with that date.\n";
    cout << "The year is " << newYearsDay.getYear() << endl;
    cout << "The month is " << newYearsDay.getMonth() << endl;
    cout << "The day is " << newYearsDay.getDay() << endl;    
    cout << endl << endl;

    // Let's try setting a value less than 1 for the month
    cout << "Let's create a date and set a bad month >>> 0\n";
    Date testMonth( 2008, 0, 10 );
    cout << "We should see a date representing Jan 10, 2008\n";
    testMonth.displayDate();
    cout << endl << endl;

    // Let's set another bad value for the month using a value 
    // greater than 12
    cout << "Let's set another bad month >>> 13\n";
    Date testMonth2( 1900, 13, 31 );
    cout << "We should see a date representing Jan 31, 1900\n";
    testMonth2.displayDate();
    cout << endl << endl;

    // OK, now let's allow the user to enter some date value
    cout << "OK now, you enter values for month, day and year.\n";

    int mo, da, yr;

    cout << "Enter month: ";
    cin >> mo;
    cout << "Enter day: ";
    cin >> da;
    cout << "Enter year: ";
    cin >> yr;
    cout << endl;

    Date yourDate( yr, mo, da );
    cout << "The date you entered is ";
    yourDate.displayDate();
    cout << endl << endl;

    system("pause");
    return 0;
}

