//This file contains the class prototypes for the Triangle class.
//Written by Jonathan Moore 3/22-3/27

#include "stdafx.h"
#include <iostream>
using std::cin;
using std::cout;
using std::endl;

class Triangle
{
public:

	Triangle(int x, int y);	

	void DrawTriangle1(int x);
	void DrawTriangle2(int x);
	void DrawTriangle3(int x);
	void DrawTriangle4(int x);

	void setSize(int x);
	void setStyle(int y);

	int getSize();
	int getStyle();

	void display();

private:
	int lineLen;
	int triangleStyle;
	int triangleSize;

};