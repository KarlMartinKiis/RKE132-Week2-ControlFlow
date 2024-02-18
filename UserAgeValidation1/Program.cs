// See https://aka.ms/new-console-template for more information

//rakendus kusib kasutajal sisestada tema vanuse
//kui kasutaja vanus on vaiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your aeg:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Prase result {isAgeNumber}. User is {userAgeNum} years oled.");

if (isAgeNumber)
{
    if (userAgeNum >= 13)
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






//int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap. 13 - stack

//if (userAge >= 13)
//{
    //Console.WriteLine("Welcome to Instagram!");
//}
//else
//{
  //  Console.WriteLine("You are too young to use Instagram.");
//}

