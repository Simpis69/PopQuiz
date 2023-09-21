using System.Security.Cryptography;

Console.WriteLine("do you want to play my quiz?");
string svar = Console.ReadLine().ToLower();
int points = 0;



if (svar == "yes")
 {
    Console.WriteLine("When was the first F1 championship?");
    Console.WriteLine("A, 1950");
        Console.WriteLine("B, 1951");
            Console.WriteLine("C, 1955  ");
}

else if (svar == "no")
{
    Console.WriteLine("Slipp då gahba");
    Console.WriteLine("Tryck enter för att göra rätt");
}

string Alt = Console.ReadLine().ToLower();

if (Alt == "a")
{
    Console.WriteLine("Thats right! you get one point");
    points++;
}
else if (Alt == "b" || Alt == "c")
{
    Console.WriteLine("Sorry! thats wrong");
}


Console.WriteLine("Who is the world champion of F1 in 2023?");
Console.WriteLine("A, Lewis Hamilton");
Console.WriteLine("B, Michael schumaker");
Console.WriteLine("C, Max Verstappen");

string champis = Console.ReadLine().ToLower();

if (champis == "c"){
    Console.WriteLine("Very good its Mr.Max");
    points++;
}

else if (champis == "b" || champis == "a"){
    Console.WriteLine("No thats wrong, no points");
}

Console.WriteLine("How much does a F1 car weigh");
Console.WriteLine("A, 898kg");
Console.WriteLine("B, 798kg");
Console.WriteLine("C, 1098kg");
string tjock = Console.ReadLine().ToLower();

if (tjock == "b"){
    Console.WriteLine("Very god! it weighs around 798kg");
    points++;
}

else if (tjock == "a" || tjock == "c"){
    Console.WriteLine("nope thats wrong");
}


// japanese
Console.WriteLine("where is my house");
Console.WriteLine("a, Tokyo");
Console.WriteLine("b, Hiroshima");
Console.WriteLine("c, Osaka");
string house = Console.ReadLine().ToLower();
if(house == "b"){
    Console.WriteLine("perfect!");
    points++;
}
else if(house == "a" || house == "c"){
    Console.WriteLine("no thats wrong");
}





Console.WriteLine($"you got {points} questions right");

Console.ReadLine();