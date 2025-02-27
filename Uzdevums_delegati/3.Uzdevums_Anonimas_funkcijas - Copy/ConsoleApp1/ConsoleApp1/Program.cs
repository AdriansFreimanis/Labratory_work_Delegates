using System;
using System.Collections.Generic;



class Program
{

    static void PrintList(List<int> numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\n");
    }


    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static void FindAllPrimes(List<int> numbers, Predicate<int> isPrime)
    {
        List<int> primeNumbers = numbers.FindAll(isPrime);
        Console.WriteLine("Pirmskaitli saraksta:");
        PrintList(primeNumbers);
    }

    static void FindFirstPrime(List<int> numbers, Predicate<int> isPrime)
    {
        int firstPrime = numbers.Find(isPrime);
        if (firstPrime != 0)
        {
            Console.WriteLine("Pirmais atrastais pirmskaitlis: " + firstPrime);
        }
        else
        {
            Console.WriteLine("Neviens pirmskaitlis netika atrasts.");
        }
    }

    static void RemoveFirstPrime(List<int> numbers, Predicate<int> isPrime)
    {
        int firstPrime = numbers.Find(isPrime);
        if (firstPrime != 0 && numbers.Remove(firstPrime))
        {
            Console.WriteLine($"Nonemam pirmo pirmskaitli: {firstPrime}");
        }
        else
        {
            Console.WriteLine("Nav pirmskaitlu, ko nonemt.");
        }
    }

    static void RemoveAllPrimes(List<int> numbers, Predicate<int> isPrime)
    {
        int removedCount = numbers.RemoveAll(isPrime);
        Console.WriteLine($"Nonemam {removedCount + 1} pirmskaitlus no saraksta.");
    }


    static void Main()
    {
        List<int> randomNumbers = new List<int>();
        Random random = new Random();


        for (int i = 0; i < 10; i++)
        {
            int randomNumber = random.Next(1,101);
            randomNumbers.Add(randomNumber);
        }

        
        Console.WriteLine("Generetie gadijuma skaitli:");
        foreach (int number in randomNumbers) 
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\n");

        Predicate<int> isPrime = IsPrime;

        FindAllPrimes(randomNumbers, isPrime);
        FindFirstPrime(randomNumbers, isPrime);
        RemoveFirstPrime(randomNumbers, isPrime);
        RemoveAllPrimes(randomNumbers, isPrime);

        Console.WriteLine("\nSaraksts pec darbibam:");
        PrintList(randomNumbers);
    }
}
