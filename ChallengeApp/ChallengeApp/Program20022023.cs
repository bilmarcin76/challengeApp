//zadanie domowe dzień 4

var name = "EWA";
var sex = "f";
var age = 33;

if (sex == "f")
{
    if (age < 30)
    {
        Console.WriteLine("kobieta poniżej 30 lat");
    }
    else if (name == "EWA" && age == 33) 

    {
        Console.WriteLine("EWA lat 33");
    }

    else if (age == 30) 
    {
        Console.WriteLine("kobieta lat 30");
    }

    else if (age > 30) 
    {
        Console.WriteLine("kobieta powyżej 30 lat");
    }

}

else
{
    if (age < 18)
    {
        Console.WriteLine("niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }    
}

