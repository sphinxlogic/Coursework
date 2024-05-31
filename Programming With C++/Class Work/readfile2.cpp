// let's read through the file char by char
// note: this program skips whitespace
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
    ifstream messageFile;// the data file
    //used to hold the filename -- open doesn't like the string type
    char fileName[100];

    char ch; // used to read characters from the file
    
    cout << "Enter file name: ";
    cin >> fileName;
    
    messageFile.open(fileName);
    if( !messageFile ) // there was an error
    {
        cout << "Can't open file: " << fileName << endl;
        return 1;
    }
     
    messageFile >> ch;
    while( !messageFile.eof() )
    {
        cout << ch << endl;
        messageFile >> ch;
    }
    
    system("pause");
    return 0;
    
}


