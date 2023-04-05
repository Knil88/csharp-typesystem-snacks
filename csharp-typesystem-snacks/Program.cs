// See https://aka.ms/new-console-template for more information

//1-snack creare due numeri e stampare il maggiore 

using System;

int numero1;
int numero2;

Console.WriteLine("Inserisci il primo numero : ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Il primo numero da te immesso è {numero1}");

Console.WriteLine("Inserisci il secondo numero : ");
numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Il Secondo numero da te immesso è {numero2}");


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

//2-snack L’utente inserisce due parole in successione.Il software stampa prima la parola più corta, poi la parola più lunga.

string parola1;

string parola2;

Console.WriteLine("Inserisci la prima parola");
parola1 = Console.ReadLine();
Console.WriteLine(parola1);
Console.WriteLine("Inserisci la seconda parola");
parola2 = Console.ReadLine();
Console.WriteLine(parola2);

if (parola1.Length > parola2.Length)
{
    Console.WriteLine($"La Parola con più caratteri è : {parola1} con {parola1.Length} caratteri");
    Console.WriteLine($"La Parola con meno caratteri è : {parola2} con {parola2.Length} caratteri");
}
else if (parola2.Length > parola1.Length)
{
    Console.WriteLine($"La Parola con più caratteri è : {parola2} con {parola2.Length} caratteri");
    Console.WriteLine($"La Parola con meno caratteri è : {parola1} con {parola1.Length} caratteri");
}

else
    Console.WriteLine("Le parole hanno gli stessi caratteri");

//3-snack l software deve chiedere per 10 volte all’utente di inserire un numero.Il programma stampa la somma di tutti i numeri inseriti.

int n;
int somma = 0;

Console.WriteLine("Inserisci 10 numeri ");

for (int i = 0; i < 10; i++)
{
   n = Convert.ToInt32(Console.ReadLine());

    somma += n;

  
} ;
Console.WriteLine($"La somma è {somma}");

//  4. Calcola la somma e la media dei numeri da 2 a 10.
int numeri;
int sommaNumeri = 0;
int media;

Console.WriteLine("Inserisci numeri da 2 a 10 e fai la media ");

for (int i = 0; i < 9; i++)
{
    numeri = Convert.ToInt32(Console.ReadLine());

    sommaNumeri += numeri;
   


};
media = sommaNumeri / 9;
Console.WriteLine($"La somma è {sommaNumeri}");
Console.WriteLine($"La media è {media}");

//   5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

int numero;


Console.WriteLine("Stampa un numero");




    numero = Convert.ToInt32(Console.ReadLine());

    if (numero % 2 == 1)
    {
        Console.WriteLine("Inserisci un numero Pari");
        numero = Convert.ToInt32(Console.ReadLine());
    }
    else
   
        Console.WriteLine($"Il numero inserito è {numero} ed è pari");

//6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] invitati = { "Yari", "Giacomo", "Aldo", "Giovanni" };
bool accettato = false;

Console.WriteLine("Salve inserisci il tuo nome per scoprire se sei nella lista");
string mioNome = Console.ReadLine();

if (invitati.Contains(mioNome))
{
    Console.WriteLine($"Benvenuto alla festa {mioNome}");
}
else
{
    Console.WriteLine($"Spiacente ma il tuo nome non compare nella lista");
}

//7. Crea un array vuoto.Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

  int[] arrayNumeri = new int[6];

Console.WriteLine("inserisci numeri");

for(int i =0; i<6; i++)
{
   int numeroDaMettere = Convert.ToInt32(Console.ReadLine());

    if(numeroDaMettere % 2 == 1)
    {
        arrayNumeri[i] = numeroDaMettere;
        
    }

    

  

    


}

for (int i = 0; i < arrayNumeri.Length; i++)
{
    Console.WriteLine(arrayNumeri[i]);
}


//    8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.


int[] arrayInteri = { 5, 6, 8, 5, 4 };

for (int i = 0; i < arrayInteri.Length; i++)
{
    Console.WriteLine(arrayInteri[i]);
}

int sommaIntero = 0;

foreach (int intero in arrayInteri)
{
    if (intero % 2 != 0)
    {
        sommaIntero += intero;
    }


}



Console.WriteLine($"La somma dei soli numeri dispari è {sommaIntero}");

//   9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.


int[] numbers = new int[0];

int sommaNumeri50 = 0;

while (sommaNumeri50 < 50)
{
    Console.WriteLine($"Inserisci numeri somma max 50: ");
    int inputNumber = Convert.ToInt32(Console.ReadLine());

    // creazione di un nuovo array con un elemento in più rispetto a quello originale
   int[] nuovoArray = new int[numbers.Length + 1];

    for(int i = 0; i < numbers.Length; i++)
    {
        nuovoArray[i] = numbers[i];
    }

    nuovoArray[numbers.Length] = inputNumber;

    numbers = nuovoArray;

    sommaNumeri50 += inputNumber;
}

Console.WriteLine("Array completo: ");
foreach (var item in numbers)
{
    Console.WriteLine(item + " ");
}

Console.WriteLine("La somma degli elementi è: " + sommaNumeri50);




//Snack 10 Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.

Console.Write("Inserisci un numero: ");
int n_1 = int.Parse(Console.ReadLine());

Random rnd = new Random();

for (int i = 0; i < n_1; i++)
{
    int[] array = new int[10];
    for (int j = 0; j < 10; j++)
    {
        array[j] = rnd.Next(1, 101);
    }
    Console.WriteLine("Array " + (i + 1) + ": " + string.Join(", ", array));
}








        









