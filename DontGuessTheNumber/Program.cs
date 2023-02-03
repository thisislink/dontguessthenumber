// randomly choose a number between 1 and 10 -- this is the number the player cannot guess
Random random = new Random();
int losingNumber = random.Next(1, 11);
Console.WriteLine($"\nLosing number: {losingNumber}");
Boolean gameover = false;
int gameRound = 1;

// Game Loop - 5 rounds
while (!gameover)
{
    int playerNumber = 0;
    double winnings = 0.00;

    if (gameRound <= 5 && playerNumber != losingNumber)
    {
        
        Console.WriteLine($"\nRound: {gameRound}");
        Console.WriteLine("\nChoose a number between 1 and 10. What number do you want to pick?: ");
        playerNumber = Convert.ToInt32(Console.ReadLine());
        
        // check if playerNumber is the random number
        // if true end game else go another round and increment winnings
        if(playerNumber == losingNumber)
        {
            Console.WriteLine($"\nGameover, you guessed the random number: {losingNumber}");
            gameover = true;
        }
        winnings += 100.00;
        gameRound++;
        
    } else if(gameRound > 5 && playerNumber != losingNumber)
    {
        Console.WriteLine("\nGameover, you did not guess the number");
        gameover = true;
    } else 
    {
        Console.WriteLine($"\nGameover, you guessed the random number: {losingNumber}");
    }

    // check if player has won the game
    if (gameRound == 6 && playerNumber != losingNumber)
    {
        Console.WriteLine($"\nCongratulations! You beat the game. You won ${winnings}.");
        gameover = true;
    }
}
