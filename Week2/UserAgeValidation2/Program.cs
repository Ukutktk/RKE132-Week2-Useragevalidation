

//rakendus küsib kasutajal sisestada tema vanus 
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse 
//"you are too young to use instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to instagram"

Console.WriteLine("Enter your age");

string userAge = Console.ReadLine();

Console.WriteLine("Please, name");
string userName = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/False 

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");



if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine($"Welcome to instagram {userName}!");
    }
    else
    {
        Console.WriteLine($"{userName} you are too young to use instagram!");
    }
}
else
{
    Console.WriteLine($"{userName} we could not read tour age.");
}


