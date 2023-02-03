﻿// randomly choose a number between 1 and 10 -- this is the number the player cannot guess
Random random = new Random();
int losingNumber = random.Next(1, 11);
Console.WriteLine($"\nLosing number: {losingNumber}");
Boolean gameover = false;
int gameRound = 1;
decimal winnings = 0.00M;
List<int> playerNumbers = new();
int playerNumber = 0;

// Game Loop - 5 rounds
while (!gameover)
{
    if (gameRound <= 5 && playerNumber != losingNumber)
    {
        Console.WriteLine($"\nRound: {gameRound}");
        Console.WriteLine("\nChoose a number between 1 and 10. What number do you want to pick?: ");
        playerNumber = Convert.ToInt32(Console.ReadLine());

        // check if number was already entered
        // if true, player must re-enter number, else continue with winning checks
        // check if playerNumber is the random number
        // if true end game else increment the winnings and go another round
        do
        {
            if (playerNumbers.Contains(playerNumber))
            {
                Console.WriteLine($"You have already entered {playerNumber}. Try another number: ");
                playerNumber = Convert.ToInt32(Console.ReadLine());

            }

        } while (playerNumbers.Contains(playerNumber));


        if (playerNumber == losingNumber)
        {
            Console.WriteLine($"\nGameover, you guessed the random number: {losingNumber}");
            gameover = true;
        } else 
        {
            playerNumbers.Add(playerNumber);
            winnings += gameRound * 100.00M;
            gameRound++;
        } 
    }

    // check if player has won the game
    if (gameRound > 5 && playerNumber != losingNumber)
    {
        Console.WriteLine($"\nCongratulations! You beat the game. You won ${winnings}.");
        gameover = true;
    } 
}
