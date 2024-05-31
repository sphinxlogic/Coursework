

#include "stdafx.h"

class Game
{

public:
Game();
void play();
void displayScore();

private:
int getGuessFromUser();
int tossCoin();

int won;
int lost;

};





