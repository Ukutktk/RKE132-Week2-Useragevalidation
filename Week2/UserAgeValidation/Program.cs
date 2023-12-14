// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajalt valida teama sugu (m/f)
//rakendus küsib kasutajalt sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"welcome, Mr. [Kasutaja perekonnanimi] / "Welcome, Ms. [Kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f)");
char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andemeid string (sõne) formaadis

Console.WriteLine("Please, enter your last name");
string userSirName = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userSirName}!");
} 
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userSirName}!");
}
else
{
    Console.WriteLine($"Welcome, {userSirName}!");
}
