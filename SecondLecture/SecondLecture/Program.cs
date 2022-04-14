// First task

Console.WriteLine("Kā Tevi sauc?");
string name = Console.ReadLine();
Console.WriteLine($"Sveiks, {name}");

Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();


// Second task

Console.WriteLine("Kāds ir tavs vecums?");
int userNumber = int.Parse(Console.ReadLine());
userNumber++;
Console.WriteLine($"Nakamgad Tev paliks {userNumber}, Tu esi pilngadīgs");

Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();

// Third task

Console.WriteLine("Lūdzu, ievadi skaitli");
int maxNumberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi vēlvienu skaitli skaitli");
int maxNumberTwo = int.Parse(Console.ReadLine());

int largerNumber = Math.Max(maxNumberOne, maxNumberTwo);

Console.WriteLine($"Lielākais skaitlis ir {largerNumber}.");

Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();


// Fourth task

Console.WriteLine("Lūdzu, ievadi skaitli");
int minNumberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi vēlvienu skaitli skaitli");
int minNumberTwo = int.Parse(Console.ReadLine());

int smallerNumber = Math.Min(minNumberOne, minNumberTwo);

Console.WriteLine($"Mazākais skaitlis ir {smallerNumber}.");

Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();

// Fifth task

Console.WriteLine("Lūdzu, ievadi skaitli");
int numberOne = int.Parse(Console.ReadLine());

Console.WriteLine("Lūdzu, ievadi vēlvienu skaitli skaitli");
int numberTwo = int.Parse(Console.ReadLine());

int divisionLeft = numberOne % numberTwo;

Console.WriteLine($"Dalījuma atlikums ir {divisionLeft}.");

Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();

// Sixth task

Console.WriteLine("Lūdzu, ievadi skaitli");
int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;
Console.WriteLine($"Skaitlis ir pāra skaitlis: {isEven}.");

Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();

// Seventh task

Console.WriteLine("Lūdzu, ievadi taisnstūra malas garumu");
double sideLength = double.Parse(Console.ReadLine());
Console.WriteLine("Lūdzu, ievadi taisnstūra malas platumu");
double sideWidth = double.Parse(Console.ReadLine());

double s = sideLength * sideWidth;
Console.WriteLine($"Taisnstūra laukums ir {s}.");

Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();

// Eight task

Console.WriteLine("Lūdzu, ievadi trīsstūra malas garumu");
int length = int.Parse(Console.ReadLine());

int area = length * length / 2;
Console.WriteLine($"Trīsstūra laukums ir {s}.");

Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();

// Ninth task

Console.WriteLine("Kāds ir Tavs vārds?");
string username = Console.ReadLine();
Console.WriteLine("Kāds ir Tavs vecums?");
string userAge = Console.ReadLine();

Console.WriteLine($"Sveiks {username}, tavs vecums ir {userAge}.");

Console.WriteLine();
Console.WriteLine("---------------");
Console.WriteLine();