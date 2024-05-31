// april21.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using std::cin;
using std::cout;
using std::endl;

const int arraySizeA = 10;
const int arraySizeB = 5;
void loadArray(int a[], int size);
void sortArray(int a[], int size);
void printArray(int a[],int size);

int _tmain(int argc, _TCHAR* argv[])
{
	int a[arraySizeA];
	int b[arraySizeB];
	
	loadArray(a, arraySizeA);
	sortArray(a, arraySizeA);
	printArray(a, arraySizeA);

	loadArray(a, arraySizeB);
	sortArray(a, arraySizeB);
	printArray(a, arraySizeB);

	system("pause");
	return 0;
}


void loadArray(int a[], int size)
{
	cout << "Enter values: " << endl;
	for(int i = 0; i < size; i++)
	{
		cout << "Number: " << i + 1 << ": ";
		cin >> a[i];
	}
	cout << endl;
}

void sortArray(int a[], int size)
{
	for (int i = 0; i < size - 1; i++)
	{
		for( int j = 0; j < size - 1; j++)
		{
			if (a[j] > a [j+1])
			{
				int tmp = a[j];
				a [j] = a [j+1];
				a[j+1] = tmp;
			}
		}
	}
}


void printArray(int a[], int size)
{
	cout << "The values of the Array are:" << endl;
	for (int i  = 0 ; i < size; i++)
	{
		cout << "Number " << i + 1 << ":" << a[i] << endl;
	}
}






