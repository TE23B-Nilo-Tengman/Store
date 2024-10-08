
bool success = !true;
int ageNum = 0;
bool lol = false;
int g = 100;


while (success != true)

{

    Console.WriteLine("Ålder:");
    string age = Console.ReadLine();


    success = int.TryParse(age, out ageNum);

    if (success == false)
    {
        Console.WriteLine("skriv en siffra, dumhuvve");
    }
}

if (ageNum >= 18)
{
    Console.WriteLine("Välkommen!");
}

else if (ageNum <= 17)
{
    lol = true;
    while (lol == true)
    {
        Console.WriteLine("lämmna min affär, ungjävel");
        Console.ReadLine();
        Environment.Exit(0);
    }
}
Console.WriteLine("vad vill du köpa?");
Console.WriteLine("vi har soppa (5g), vin (10g) och mer soppa (15g)");
Console.WriteLine($"du har {g}guld");
string vad = Console.ReadLine();






Console.ReadLine();