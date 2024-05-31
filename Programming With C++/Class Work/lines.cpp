// Sample code using an asterisk "*" to draw lines on the screen
// written by cae 3/24/08

#include <iostream>
using std::cin;
using std::cout;
using std::endl;

#include <iomanip>
using std::setw;

int main()
{
    int lineLen; // holds the length of line to draw
    
    // get line info from the user
    cout << "What size line? ";
    cin >> lineLen;
    cout << endl;
    
    // draw horizontal line
    for( int i = 1; i <= lineLen; i++ )
    {
         cout << "*";
    }
    cout << endl << endl;
    
    
    // draw vertical line
    for( int i = 1; i <= lineLen; i++ )
    {
         cout << "*";
         cout << endl;
    }
    cout << endl << endl;

    // draw angle line -- upper left to lower right
    // using the setw format feature
    for( int i = 1; i <= lineLen; i++ )
    {
         cout << setw( i ) << "*";
         cout << endl;
    }

    cout << endl << endl;
    
    // draw angle line version 2 -- upper left to lower right
    // using nested loops
    for( int i = 1; i <= lineLen; i++ )
    {
         // put the appropriate number of spaces in front of the "*"
         for( int spaceCount = 1; spaceCount <= i - 1; spaceCount++ )
         {
              cout << " ";
         }
         cout << "*";
         cout << endl;
    } 
    cout << endl << endl;
    
    // draw angle line version 3 -- upper right to lower left
    for( int i = lineLen; i >= 1; i-- )
    {
         cout << setw(i ) << "*";
         cout << endl;
    }
    cout << endl << endl;
    
     
    // draw angle line version 4 -- upper right to lower left
    for( int i = lineLen; i >= 1; i-- )
    {
         for( int spaceCount = 1; spaceCount <= i - 1; spaceCount++ )
         {
              cout << " ";
         }
         cout << "*";
         cout << endl;
    } 
    cout << endl << endl;
    
    
    system("pause");
    return 0;
}
    