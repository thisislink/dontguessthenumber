using DontGuessTheNumber.Managers;
using DontGuessTheNumber.Models;

GameTitleManager _gameTitle = new GameTitleManager();
GameStorylineManager _storyline = new GameStorylineManager();
PlayerInputCheckManager _playerInput = new PlayerInputCheckManager();
GameDefaults _gameDefaults = new GameDefaults();

string _getGameTitle = _gameTitle.GetGameTitle();
string _getStoryline = _storyline.GetStoryline();
bool _gameover = _gameDefaults.Gameover;

// Intro and How to Play
Console.WriteLine($"{_getGameTitle}\n{_getStoryline}");

// Game Loop - 5 rounds
while (!_gameover)
{    
    _gameover = _playerInput.ProcessPlayerInput();
}

Console.WriteLine("\n\nPress any key to close the game.");
Console.ReadKey();