Console.Write("Enter the name of the town: ");
string name = Console.ReadLine();
Console.Write("Enter the town's population: ");
int population = int.Parse(Console.ReadLine());
Console.Write("Enter the town's area: ");
double area = double.Parse(Console.ReadLine());

Console.WriteLine($"Town name: {name}");
Console.WriteLine($"{name}'s population: {population}");
Console.WriteLine($"{name}'s area: {area}");