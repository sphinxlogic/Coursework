#include <iostream>

using std::cin;
using std::cout;
using std::endl;

#include <cstdlib>
using std::srand;
using std::rand;

#include <time>
using std::time;

#include "labsession.h"

Game::Game()
{
	won = 0;
	lost = 0;
	
}

void Game::play()
{
	char wantsToPlay = 'y';
	int userGuess;
	int coinValue;

	cout << " Welcome to the coin toss game" << endl;
	while(wantsToPlay == 'y')
	{
		userGuess= getGuessFromUser();
		coinValue = tossCoin();
		if (userGuess==coinValue)
		{
			cout << "You Won!" << endl;
			won++;
		}
		else
		{
			cout << "Sorry. You lose. " << endl;
			lost++;
		}
			displayScore();
		
			cout << "Do you want to play again? ";
			cin >> wantToPlay;
	}
}

int Game::getGuessFromUser()
{
	int guess;
	
	cout << " What is your guess? " << endl;
	cout << "Type 1 for heads and 0 for tails.";

	return guess;

}

int Game::tossCoin()
{
	return rand() % 2;
	//rand() % 13 + 1;
}

void Game::displayScore()
{
	cout << "You have won " << won
		<< " and lost" << lost << endl;
}

