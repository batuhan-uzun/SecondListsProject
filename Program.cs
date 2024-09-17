List<string> coffeeName = new List<string>(); // Created List of type String
Console.WriteLine("Please enter 5 coffee names");
for (int i = 0; i < 5; i++) // For loop with 5 coffee names requested from the user
{
    coffeeName.Add(Console.ReadLine());
}

Console.WriteLine("Entered coffee names:");
foreach (string names in coffeeName) // Names in coffees were printed on the screen with a forach
{
    Console.WriteLine(names);
}
