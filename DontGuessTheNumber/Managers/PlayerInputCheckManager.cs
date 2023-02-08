using DontGuessTheNumber.Interfaces;
using DontGuessTheNumber.Models;

namespace DontGuessTheNumber.Managers
{
    internal class PlayerInputCheckManager : IPlayerInputCheck
    {
        RandomNumberManager _getLosingNumber = new();
        GameDefaults _gameDefaults = new();
        WinnerManager _winnerManager = new();

        private int losingNumber;
        private int gameRound;
        private int playerInput;
        private bool gameover;
        private decimal winnings;
        private List<int> playerNumbers = new();
            
        public PlayerInputCheckManager()
        {
            gameRound = _gameDefaults.GameRound;
            playerInput = _gameDefaults.PlayerNumber;
            gameover = _gameDefaults.Gameover;
            winnings = _gameDefaults.Winnings;
            losingNumber = _getLosingNumber.GetLosingNumber();
        }
        public bool ProcessPlayerInput()
        {
            Console.WriteLine($"\nRound: {gameRound}");
            if (gameRound <= 5 && playerInput != losingNumber)
            {
                // check if player input is non-numeric 
                do
                {
                    try
                    {
                        Console.WriteLine("\nChoose a number between 1 and 10. What number do you want to pick?: ");
                        if (int.TryParse(Console.ReadLine(), out playerInput))
                        {
                            // check if number is between 1 and 10
                            // check if number was already entered
                            // if true, player must re-enter number, else continue with winning checks
                            if (playerInput < 1 || playerInput > 10)
                            {
                                Console.WriteLine($"\nInvalid entry. Try again: ");
                            }
                            else if (playerNumbers.Contains(playerInput))
                            {
                                Console.WriteLine($"You have already entered {playerInput}. Try another number: ");
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine($"\nYou must enter a number between 1 and 10. Try again: ");
                    }
                } while (playerInput < 1 || playerInput > 10 || playerNumbers.Contains(playerInput));
                //return "ok";
                if (playerInput == losingNumber && gameRound < 3)
                {
                    Console.WriteLine($"\nGameover, you guessed the random number: {losingNumber}\nYou did not win any money.");
                    gameover = true;
                }
                else if (playerInput == losingNumber && gameRound >= 3)
                {
                    Console.WriteLine($"\nGameover, you guessed the random number: {losingNumber}\n You won ${winnings}");
                    gameover = true;
                }
                else
                {
                    playerNumbers.Add(playerInput);
                    winnings += gameRound * 100.00M;
                    gameRound++;
                    Console.WriteLine($"So far, you have won ${winnings} dollars.");
                }
            }
            gameover = _winnerManager.CheckForWinner(gameRound, playerInput, losingNumber, winnings, gameover);
            return gameover;
        }
    }
}
