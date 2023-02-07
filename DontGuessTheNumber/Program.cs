using DontGuessTheNumber.Managers;

RandomNumberManager _random = new RandomNumberManager();
GameTitleManager _gameTitle = new GameTitleManager();
GameStorylineManager _storyline = new GameStorylineManager();
int _getLosingNumber = _random.GetLosingNumber();
string _getGameTitle = _gameTitle.GetGameTitle();
string _getStoryline = _storyline.GetStoryline();
bool gameover = false;
int gameRound = 1;
decimal winnings = 0.00M;
List<int> playerNumbers = new();
int playerNumber = 0;

// Intro and How to Play
Console.WriteLine(_getGameTitle);
Console.WriteLine(_getStoryline);

// Game Loop - 5 rounds
while (!gameover)
{    
    if (gameRound <= 5 && playerNumber != _getLosingNumber)
    {
        Console.WriteLine($"\nRound: {gameRound}");
        // check if player input is non-numeric 
        do
        { 
            try
            {
                Console.WriteLine("\nChoose a number between 1 and 10. What number do you want to pick?: ");
                if(int.TryParse(Console.ReadLine(), out playerNumber))
                {
                    // check if number is between 1 and 10
                    // check if number was already entered
                    // if true, player must re-enter number, else continue with winning checks
                    if (playerNumber < 1 || playerNumber > 10)
                    {
                        Console.WriteLine($"\nInvalid entry. Try again: ");
                    } else if (playerNumbers.Contains(playerNumber))
                    {
                        Console.WriteLine($"You have already entered {playerNumber}. Try another number: ");                    
                    }  
                }
            } catch
            {
                Console.WriteLine($"\nYou must enter a number between 1 and 10. Try again: ");
            }
        } while(playerNumber < 1 || playerNumber > 10 || playerNumbers.Contains(playerNumber));

        // check if playerNumber is the random number
        // if true, end game else increment the winnings and go another round
        if (playerNumber == _getLosingNumber && gameRound < 3)
        {
            Console.WriteLine($"\nGameover, you guessed the random number: {_getLosingNumber}\nYou did not win any money.");
            gameover = true;
        } else if(playerNumber == _getLosingNumber && gameRound >= 3)
        {
            Console.WriteLine($"\nGameover, you guessed the random number: {_getLosingNumber}\n You won ${winnings}");
            gameover = true;
        } else
        {
            playerNumbers.Add(playerNumber);
            winnings += gameRound * 100.00M;
            gameRound++;
            Console.WriteLine($"So far, you have won ${winnings} dollars.");
        }
    }

    // check if player has won the game
    if (gameRound > 5 && playerNumber != _getLosingNumber)
    {
        Console.WriteLine($"\nCongratulations! You beat the game. You won ${winnings} dollars.");
        gameover = true;
    } 
}
