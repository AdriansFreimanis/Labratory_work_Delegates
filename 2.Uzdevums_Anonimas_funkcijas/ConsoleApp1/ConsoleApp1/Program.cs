using System;

//Definējam delegātu ar nosaukumu "Matematika", kas saņem 2 doublu tipa mainīgos kā parametrus
//{modifier} delegate [return_type] [delegate_name] ([parameter_list]) 
public delegate double Matematika(double sk1, double sk2);

class Program
{

   public static void LietotajaOperacijas(Matematika del)
    {
        //Pieprasam lai lietotājs ievada 2 skaitļus, kuri tiks padoti delegātam
        Console.WriteLine("Ievadi skaitli 1: ");
        var sk1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ievadi skaitli 2: ");
        var sk2 = double.Parse(Console.ReadLine());

        //ar skaitļiem izpildam delegātu
        double result = del(sk1, sk2);

        //Izvadam rezultātu
        Console.WriteLine("Delegats ir izpildits, seit ir rezultats: {0}", result); 
    }

    static void Main()
    {
        //Pieprasam, lai lietotājs veic izvēli darbībai
        Console.WriteLine("Izvelies darbibu 1 - saskaitit, 2 - atnemt, 3 - dalit, 4 - reizinat");
        var izvele = int.Parse(Console.ReadLine());


        //Pec izveles pieškiram delegatam funkciju
        if (izvele == 1)
        {
            Matematika del = delegate (double a, double b)
            { return a + b; };

            LietotajaOperacijas(del);
        }
        else if (izvele == 2)
        {
            Matematika del = delegate (double a, double b)
            { return a - b; };

            LietotajaOperacijas(del);
        }
        else if (izvele == 3)
        {
            Matematika del = delegate (double a, double b)
            { return a / b; };

            LietotajaOperacijas(del);
        }
        else if (izvele == 4)
        {
            Matematika del = delegate (double a, double b)
            { return a * b; };

            LietotajaOperacijas(del);
        }

        
    }
}