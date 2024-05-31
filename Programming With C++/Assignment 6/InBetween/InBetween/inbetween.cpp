//Class Definition File For the Game Class
//Written by Jonathan Moore April 11-14 2008

#include "stdafx.h"
#include <iostream>

using std::cin;
using std::cout;
using std::endl;

#include <cstdlib>
using std::srand;
using std::rand;

#include <ctime>
using std::time;

#include <string>
using std::string;

#include "inbetween.h"


Game::Game()
{
	won = 0;
	lost = 0;
}

void Game::play()
{
	char wantsToPlay = 'y';
	string name;	
	
	cout << "Welcome to the game In Between" << endl;
	cout << "What is your name? "; 
	cin >> name;
	cout << "Hello " << name << " Let's get started" << endl;

	while(wantsToPlay == 'y')
	{
		dealCards();
		
		displayScore();

		cout << "Do you want to play again? ";
		cin >> wantsToPlay;

				
	}
	cout << "See you later, " << name << " Thanks for playing" << endl;
}

void Game::dealCards()
{
	int iMinCard = 0;
	int iMaxCard = 0;
	
	firstCard = rand() % 13 + 1;
	secondCard = rand() % 13 + 1;
	thirdCard = rand() % 13 + 1;

	
	cout << "The two cards are "  << firstCard << " and " << secondCard << endl;
	cout << "Will the third card be in between them?";
	cin >> guess;
	cout << "The third card is " << thirdCard << endl;
	
	if (firstCard < secondCard)
	{
		iMinCard = firstCard;
		iMaxCard = secondCard;
	}
	else
	{
		iMinCard = secondCard;
		iMaxCard = firstCard;
	}
	
	if (thirdCard >= iMinCard && thirdCard <= iMaxCard)
	{
		if (guess == 'y')
		{
			cout << "You won that hand! ";
			won++;
		}
		else
		{
			cout << "Sorry, you lose. ";
			lost++;
		}
	}
	else
	{
		if (guess == 'n')
		{
			cout << "You won that hand! ";
			won++;
		}
		else
		{
			cout << "Sorry, you lose. ";
			lost++;
		}
	}
	
}

void Game::displayScore()
{
	cout << "You have won " << won
	<< " and lost " << lost << endl;

}




