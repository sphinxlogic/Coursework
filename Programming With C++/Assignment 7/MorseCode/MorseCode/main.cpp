// This program translates Morse code to English and English to Morse code.
// Written by: Jonathan Moore and Alex Edwards 
//

#include "stdafx.h"
#include <iostream>
#include <fstream>
#include <string>

using std::cin;
using std::cout;
using std::endl;
using std::string;
using std::ifstream;

//Method Prototypes
int English2Morse();
int Morse2English();

const int listSize = 26;

//Declare arrays
string morseList[listSize] = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};
string alphaList[listSize] = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V","W","X","Y","Z"};

//Main entry point
int _tmain(int argc, _TCHAR* argv[])
{
	int selection;

	cout << "Welcome to the Morse Code Translator." << endl;
	while(selection !=9)
	{
	cout << endl;
	cout << "What do you want to do?" << endl;
	cout << "Type 1 for English to Morse Code." << endl;
	cout << "Type 2 for Morse Code to English."<< endl;
	cout << "Type 9 to exit." << endl;
	cout << "Selection? ";
	cin >> selection;

	if (selection == 1)
	{	
		  English2Morse();
	}

	if (selection == 2)
	{			
		  Morse2English();
	}	 
		 
	if (selection == 9)
	{		
	   cout << "Thanks for using the translator." << endl;
	}
	}
		
	system("pause");
	return 0;
	
}
//Method that converts English the Morse code.
int English2Morse()
{
	ifstream messageFile;
    
    char fileName[100];

    char ch; 
    
    cout << "Enter the filename containing the text to be translated: ";
    cin >> fileName;
    
    messageFile.open(fileName);
    if( !messageFile ) 
    {
        cout << "Can't open file: " << fileName << endl;
        return 1;
    }
     
    messageFile >> ch;

	cout << endl << "The translation is " << endl;

    while( !messageFile.eof() )
    {
        cout << morseList[ch - 'A'] << " "; 
        messageFile >> ch;		
	}
}

//Method that converts Morse code to English
int Morse2English()
{
	ifstream messageFile;

	char fileName[100];

	string word = ""; 

	cout << "Enter the filename containing the morse code to be translated:";
	cin >> fileName;

	messageFile.open(fileName);

	if( !messageFile ) 
	{
		cout << "Can't open file: " << fileName << endl;
		return 1;

	}

	messageFile >> word;

	cout << "The file contains the message: " << endl;

	while( !messageFile.eof() )
	{ 
		
		for(int i=0; i < listSize; i++)
		{
			if(morseList[i] == word)	
			{
			cout << alphaList[i];

			messageFile >> word;
			
		    }
			
	    }

    }
} 





	
    
   



