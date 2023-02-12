// Rakendus palub kasutajal sisestada oma vanuse
// kui vanus on väiksem kui 13, siis kuvatakse:
// "You are too young to use Instagram"
// muul juhul kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine($"Parse result is {isAgeNumber}. User age is {userAgeNum} years old.");

//int userAge = Int32.Parse(Console.ReadLine()); // Sisend loetakse sõnena ja teisendatske int

if (isAgeNumber)
{
    if(userAgeNum >= 13)
{
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}