// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutaja vanust 
//kui vanus alla 13 siis konsool ütleb 
//"you are too young for instagram"
//else
//"welcome to instagram"

using System.ComponentModel;

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;
//boolean true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge = Int32.Parse(Console.ReadLine()); //"13" heapis, 13 stackis 

if (isAgeNumber == true)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram");
    }
    else
    {
        Console.WriteLine("You are too young for Instagram");
    }
}
if (isAgeNumber == false)
{
    Console.WriteLine("Beep Boop");
}

//if (userAge >= 13)
{
    //Console.WriteLine("Welcome to Instagram");
}
//else
{
    //Console.WriteLine("You are too young for Instagram");
}