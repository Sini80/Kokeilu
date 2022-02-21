// See https://aka.ms/new-console-template for more information

// Määritetään muuttuja

int luku;
string sukupuoli;


Console.Write("Minkä ikäinen olet ? ");
luku = Convert.ToInt32(Console.ReadLine()); // Lukumuuttuja on esitelty
Console.Write("Oletko nainen vai mies (N/M) ? "); //Tulostetaan kysymys
sukupuoli = Console.ReadLine(); //sukupuolimuuttuja esitellään string 

//Määritellään sukupuoli ja kirjain onko iso vai pieni kirjain
if (sukupuoli == "M" || sukupuoli == "m")
{
    if (luku < 14)
    {
        Console.WriteLine("Mitäs poitsu ?");
    }
    else if (luku >= 14 && luku <= 25)
    {
        Console.WriteLine("Mitäs nuori mies ?");
    }
    else if (luku > 25 && luku <= 56)
    {
        Console.WriteLine("Olet mies parhaassa iässä !");
    }
    else
    {
        Console.WriteLine("Mitäs vanha ukko ?");
    } 
}
if (sukupuoli == "N" || sukupuoli == "n")
{
    if (luku < 14)
    {
        Console.WriteLine("Mitäs tyttö ?");
    }
    else if (luku >= 14 && luku <= 25)
    {
        Console.WriteLine("Mitäs nuori nainen ?");
    }
    else if (luku > 25 && luku <= 56)
    {
        Console.WriteLine("Olet nainen parhaassa iässä !");
    }
    else
    {
        Console.WriteLine(" Mitäs vanha akka ?");
    }
}














