// randomly choose a number between 1 and 10 -- this is the number the player cannot guess
Random random = new Random();
int losingNumber = random.Next(1, 11);

Boolean gameover = false;
int gameRound = 1;

// Game Loop - 5 rounds
while (!gameover)
{
    if(gameRound <= 5)
    {
        Console.WriteLine($"Round: {gameRound}");
        gameRound++;
    } else
    {
        Console.WriteLine("Gameover");
        gameover = true;
    }
}
