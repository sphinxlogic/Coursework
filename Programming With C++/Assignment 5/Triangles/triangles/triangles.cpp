// This file contains method definitions for the Triangle class
// Written by Jonathan Moore 3/22-3/27


#include "stdafx.h"
#include "triangle.h"
#include <iostream>
#include <iomanip>
#include <cstdlib>

using std::setw;
using std::cout;
using std::cin;
using std::endl;
using std::setfill;
using std::abort;



Triangle::Triangle(int x, int y)
{
	 setSize(x);
	 setStyle(y);
}


void Triangle::setSize(int x)
{
	triangleSize = x;

	if (x < 2 || x > 20)	
	{
		cout << "Please enter a number 2-20 for the size" << endl;
		system("pause");
		abort();		
		
	}
}

void Triangle::setStyle(int y)
{
	triangleStyle = y;

	if (y > 4 || y < 1)
	{
		cout << "Please enter a number 1-4 for the style" << endl;
		system("pause");
		abort();		
		
	}

}

int Triangle::getSize()
{
	return triangleSize;
}

int Triangle::getStyle()
{
	return triangleStyle;
}

void Triangle::DrawTriangle1(int x)
{
	lineLen = x;

	for (int i = 1; i <= lineLen; i++)
	{			
		cout << setfill('*') << setw(i)<< "*" << endl;		
		
	}
	cout << endl;
	
}

void Triangle::DrawTriangle2(int x)
{
	lineLen = x;

	for (int i = lineLen; i >= 1; i--)
	{
		cout << setfill('*') << setw(i) << "*" << endl;
	}
	cout << endl;
}

void Triangle::DrawTriangle3(int x)
{
	
	lineLen = x;

	for(int i = 1; i <= lineLen; i++)
      {
            cout << setfill(' ') << setw(i);

            for(int j = lineLen; j >= i; j--)
			
                  cout << "*";
				  cout << endl;			
      }

	
}

void Triangle::DrawTriangle4(int x)
{
	lineLen = x;

	for(int i = lineLen; i >= 1; i--)
      {
            cout << setfill(' ') << setw(i);

            for(int j = lineLen; j >= i; j--)

                  cout << "*";
				  cout << endl;
      }

}

void Triangle::display()
{ 
	

	if (triangleStyle == 1)
	{ 
		DrawTriangle1(triangleSize);
	}
	if (triangleStyle == 2)
	{
		DrawTriangle2(triangleSize);
	}
	if (triangleStyle == 3)
	{
		DrawTriangle3(triangleSize);
	}
	if (triangleStyle == 4)
	{
		DrawTriangle4(triangleSize);
	}


}

