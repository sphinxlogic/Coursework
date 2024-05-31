// maintest.cpp
// written by cae 2/25/08
// modified by Jonathan Moore 2/29/08

// This is the main program that you can use to test your new and
// improved date class.
//
// Note: It expects the parameters to initialize date objects to be
// in the order year, month, day.

// Note 2: It uses the strings "ymd", "mdy", and "dmy", to control how
// displayDate formats the date. If your displayDate method uses different
// values, you need to change this code.
//
 

#include <iostream>
using std::cout;
using std::cin;
using std::endl;

#include <string>

#include "date.h"

int main()
{
    // Just setting an arbitrary value
    cout << "Let's create a date and set it to  March 1, 2008\n";
    Date someDay( 2008, 3, 1 );
    // Let's display it in mdy format
    cout << "You should see March 1, 2008 displayed in mm/dd/yyyy format.\n";
    someDay.displayDate2();
    cout << endl;
    // Now display it in dmy format
    cout << "Here it is in dd/mm/yyyy format\n";
    someDay.displayDate3();
    cout << endl;
    // Now in ymd format
    cout << "Here it is in yyyy/mm/dd format\n";
    someDay.displayDate1();
    cout << endl << endl;
    
    // Let's check a bad year value
    cout << "Checking to see how invalid year values are handled.\n";
    cout << "Program will attempt to set the date Nov 30, 1799.\n";
    cout << "Let's see what happens.\n";
    Date anotherDay( 1799, 11, 30 );
    cout << "Your class changesthe value to ";
    anotherDay.displayDate2();
    cout << endl << endl;
 
    // Now let's check the nextDay function.
    cout << "Setting a date of June 28, 2007.\n";
    anotherDay.setYear( 2007 );
    anotherDay.setMonth( 6 );
    anotherDay.setDay( 28 );
    cout << "Starting with ";
    anotherDay.displayDate2();
    cout << endl;
    cout << "Let's count forward 4 days.  We should get to July 2, 2007\n";
    
    int count = 1;
    while( count <= 4 )
    {
        anotherDay.nextDay();
        anotherDay.displayDate2();
        cout << endl;
        count++;
    } 

    cout << endl << endl;
    cout << "Now let's set a date near the end of the year and watch.\n";
    Date yetAnotherDay( 2007, 12, 28);
    cout << "Starting with December 28, 2007\n";
    yetAnotherDay.displayDate2();
    cout << endl;
    cout << "Let's see what happens now.\n";
    count = 1;
    while( count <= 4 )
    {
        yetAnotherDay.nextDay();
        yetAnotherDay.displayDate2();
        cout << endl;
        count++;
    } 
    cout << endl;        

    // Let the user enter any arbitrary date values.   
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
    yourDate.displayDate1();
    cout << endl << endl;

    system("pause");
    return 0;
}

