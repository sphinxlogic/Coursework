#include <iostream>
using std::cin;
using std::cout;
using std::endl;

#include <fstream>
using std::ifstream;

#include <string>
using std::string;

int main()
{
    ifstream messageFile; // the data file
       
    //used to hold the filename -- open doesn't like the string type
    char fileName[100];
    
    string word; // used to read words from the file
    
    
    cout << "Enter file name: ";
    cin >> fileName;
    
    messageFile.open(fileName);
    if( !messageFile ) // there was an error
    {
        cout << "Can't open file: " << fileName << endl;
        return 1;
    }
    
    // get first word from file
    messageFile >> word;
    // if file is empty, loop will not execute
    while( !messageFile.eof() )
    {    
        // process data from file   
        cout << word << endl;
        
        // get next word from file
        messageFile >> word;
    }
    
    system("pause");
    return 0;
    
}
