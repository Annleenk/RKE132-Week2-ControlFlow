// See https://aka.ms/new-console-template for more information

// rakendus küsib sugu m/f 
//küsib nime 
//vast valikust tervitab kasutajat
//"Welcome mr. (pk nimi)" või "welcome ms (pk. nimi)"

Console.WriteLine("Please enter your last name");

string userName;

userName = Console.ReadLine();

Console.WriteLine("Please select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb string e sõne formaadis, seega char parse 

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr {userName}");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms {userName}");
}
else
{
    Console.WriteLine($"Welcome {userName}");
}

