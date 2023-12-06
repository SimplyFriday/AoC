using AoC.Day02;

var gameConfig = new GameConfiguration
{
    MaxRedCount = 12,
    MaxGreenCount = 13,
    MaxBlueCount = 14
};

// In a real program you'd define this in a config file but idfc
var inputFilePath = $"{Directory.GetCurrentDirectory()}/Day02/GameInput.txt";

var gameRunner = new GameRunner(gameConfig);

if (gameRunner.TryLoadInputFile(inputFilePath))
{
    Console.WriteLine($"The result for Day 2 is: {gameRunner.RunSimulation()}");
}
