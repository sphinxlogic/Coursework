// InBetween.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <ctime>
#include <cstdlib>
#include "inbetween.h"

using std::srand;
using std::rand;
using std::time;

int _tmain(int argc, _TCHAR* argv[])
{
	srand(time(0));
	Game myGame;
	myGame.play();	
	
	system("pause");
	return 0;
}

