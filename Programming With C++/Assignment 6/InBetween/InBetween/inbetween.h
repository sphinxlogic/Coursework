//My game class and its prototypes
//Written by Jonathan Moore on April 11-14 2008


class Game
{

public:

Game();
void play();

private:

void dealCards();
void displayScore();

int won;
int lost;
int firstCard;
int secondCard;
int thirdCard;
char guess;

};
