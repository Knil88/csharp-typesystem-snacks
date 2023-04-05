// See https://aka.ms/new-console-template for more information

//1-snack creare due numeri e stampare il maggiore 

int numero1;
int numero2;

Console.WriteLine("Inserisci il primo numero : ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Il primo numero da te immesso è {numero1}");

Console.WriteLine("Inserisci il secondo numero : ");
numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Il Secondo numero da te immesso è {numero2}");

//Creiamo le condizioni che portano a stampare il nummero più grande

if (numero1 > numero2)
{
    Console.WriteLine($"il numero più grande è {numero1}");
}

else if (numero2 > numero1)
{
    Console.WriteLine($"il numero più grande è {numero2}");
}
else
{
    Console.WriteLine("I numeri sono pari");
}




