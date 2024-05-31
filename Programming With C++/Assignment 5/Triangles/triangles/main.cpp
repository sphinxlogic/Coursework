// Test program for assignment #5 -- Drawing Triangles
// written by cae 3/21/08

#include "stdafx.h"
#include <iostream>
#include "triangle.h"

using std::cin;
using std::cout;
using std::endl;

int main()
{
			int triangleSize, triangleStyle;
			char userResponse = 'y';

			while( userResponse == 'y')
			{
				cout << "What size triangle? (2-20)?";
				cin >> triangleSize;
				cout << endl;				
				cout << "What style triangle (1-4)? ";
				cin >> triangleStyle;
				cout << endl;				
				Triangle t( triangleSize, triangleStyle);
				t.display();
        
				cout << "Do you want to draw another triangle? ";
				cin >> userResponse;
				cout << endl;   
			}
	
    system("pause");
    return 0;
}
