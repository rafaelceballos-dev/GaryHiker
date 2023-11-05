using GaryHikerConsoleApp;
Console.WriteLine("Type the steps:");
var stringSteps = Console.ReadLine();
Console.WriteLine("Type the Gary Hiker path:");
var path = Console.ReadLine();

int steps = 0;
var isParsed = int.TryParse(stringSteps,out steps);
steps = isParsed ? steps : 0;

var garyHiker = new Hiker(path, steps);

var valleyCounter = garyHiker.CountingValleys();
var mountainCounter = garyHiker.CountingMountains();
Console.WriteLine();
Console.WriteLine($"Valleys: {valleyCounter}; Mountains: {mountainCounter}");

/// Different test cases

/// Test1
Console.WriteLine();
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
Console.WriteLine("TEST 1 - Case 'uuuddd', single mountain 3 units high.");
var test1 = new Hiker("uuuddd");

valleyCounter = test1.CountingValleys();
mountainCounter = test1.CountingMountains();

Console.WriteLine($"Valleys: {valleyCounter}; Mountains: {mountainCounter}");

/// Test2
Console.WriteLine();
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
Console.WriteLine("TEST 2 - Case 'uuuddd-ddddduudduuuuuuu', 1 mountain 3units, invalid char, 1 valey 5 units with 2 depressions.");
var test2 = new Hiker("uuuddd-ddddduudduuuuuuu");

valleyCounter = test2.CountingValleys();
mountainCounter = test2.CountingMountains();

Console.WriteLine($"Valleys: {valleyCounter}; Mountains: {mountainCounter}");

/// Test3
Console.WriteLine();
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
Console.WriteLine("TEST 3 - Case 'uuuddd-ddddduudduuu-*-uuuuudduuudddddddddd', long hike with invlid chars.");
var test3 = new Hiker("uuuddd-ddddduudduuu-*-uuuuudduuudddddd");

valleyCounter = test3.CountingValleys();
mountainCounter = test3.CountingMountains();

Console.WriteLine($"Valleys: {valleyCounter}; Mountains: {mountainCounter}");
