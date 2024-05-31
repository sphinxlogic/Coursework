//This is the main program that will be used
//to test my Time class
//written by Jonathan Moore 

#include <iostream>
#include "stdafx.h"
#include "time.h"

int _tmain(int argc, _TCHAR* argv[])
{
	Time midnight(0, 0, 0 );
	std::cout << "Here is the display for midnight\n";
	midnight.display();
    
	Time firstClass( 9, 0, 0 );
	std::cout << "Here is the display for my first class of the day\n";
	firstClass.display();

	system("pause");
	return 0;
}

