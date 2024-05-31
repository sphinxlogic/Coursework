// labsession.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <cstdlib>
#include <iostream>
#include <ctime>


using namespace std;
#include "labsession.h"


int _tmain(int argc, _TCHAR* argv[])
{
	srand(time(0));
	Game myGame;
	myGame.play();

	system("pause");
	return 0;
}

