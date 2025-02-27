using System;

//Definējam delegātu ar nosaukumu "Matematika", kas saņem 2 doublu tipa mainīgos kā parametrus
//{modifier} delegate [return_type] [delegate_name] ([parameter_list]) 
public delegate double Matematika(double sk1, double sk2);

class Program
{
    //Funkcija atgriež summu no 2 skaitļiem
    static double Saskaitit(double x, double y) => x + y;

    //Funkcija atgriež starpibu no 2 skaitļiem
    static double Atnemt(double x, double y) => x - y;

    //Funkcija atgriež reizinājumu no 2 skaitļiem
    static double Reizinat(double x, double y) => x * y;

    //Funkcija atgriež dalijumu no 2 skaitļiem
    static double Dalit(double x, double y) => x / y;

    static void Main()
    {
        //Definē instanci delegāta "Matematika", ar nosaukumu "del" un vertibu null
        Matematika del = null;

        //Pieprasam, lai lietotājs veic izvēli darbībai
        Console.WriteLine("Izvelies darbibu 1 - saskaitit, 2 - atnemt, 3 - dalit, 4 - reizinat");
        var izvele = int.Parse(Console.ReadLine());

        //Pec izveles izveles pieškiram delegatam funkciju
        if(izvele == 1)
        {
            del = Saskaitit;
        }
        else if(izvele == 2)
        {
             del = Atnemt; 
        }
        else if (izvele == 3)
        {
            del = Dalit;
        }
        else if (izvele == 4)
        {
            del = Reizinat;
        }


        //Pieprasam lai lietotājs ievada 2 skaitļus, kuri tiks padoti delegātam
        Console.WriteLine("Ievadi skaitli 1: ");
        var sk1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ievadi skaitli 2: ");
        var sk2 = double.Parse(Console.ReadLine());


        //ar skaitļiem izpildam delegātu
        double result = del(sk1, sk2);
        Console.WriteLine("Delegats ir izpildits, seit ir rezultats: {0}",result);
    }
}