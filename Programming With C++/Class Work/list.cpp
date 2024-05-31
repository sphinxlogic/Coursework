// let's practice array searching
// written by cae and students 4/23/08

#include <iostream>
using std::cin;
using std::cout;
using std::endl;

#include <string>
using std::string;

const int listSize = 5;

int search( string nameList[], string name );

int main()
{
    string nameList[listSize] = { "Alice", "Bob", "Daniel", "Jill", "Sally" };
    string name;
    
    cout << "Enter a name: ";
    cin >> name;

    int location = search( nameList, name );    
    
    if( location >= 0 )
    {
        cout << "Found it at location " << location << endl;
    }
    else
    {
        cout << "Not found." << endl;
    }
    
    system("pause");
    return 0;
}

// function to determine if name is in nameList
// if it is return the array index as the location
// it not found return a -1 for the location
int search( string nameList[], string name )
{    
    int location = -1;   
    for( int i = 0; i < listSize; i++ )
    {
         if( name == nameList[ i ] )
         {
             location = i;
         }
    }  
    
    return location;
}
