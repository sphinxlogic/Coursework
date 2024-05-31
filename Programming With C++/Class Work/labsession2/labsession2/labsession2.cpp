// labsession2.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using std::cin;
using std::cout;
using std::endl;


int _tmain(int argc, _TCHAR* argv[])
{
	if (section == 1)
		morsetocode();
	else
		engtoMorse();

	return 0;
}

