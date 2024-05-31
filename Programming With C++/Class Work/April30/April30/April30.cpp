// April30.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>

using std::cin;
using std::cout;
using std::endl;
using std::string;

int _tmain(int argc, _TCHAR* argv[])
{
	string morseCode[26] = {".-", "..-.", "--." };

	char letter;

	cout << "Enter a letter from a to z ";
	cin >> letter;

	letter = toupper (letter);

	cout << "That Morse Code is "  << morseCode[letter-'A'] << endl;

	system("pause");

	return 0;
}

