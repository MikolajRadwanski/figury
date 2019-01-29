using System;
using System.Collections.Generic;

namespace csharp
{
    class Program
    {
        static void Main(string[] args) {

            Figura figura = new Kolo(4.666);
            Console.WriteLine( figura.powierzchnia() );
            figura = new Kwadrat(4.666);
            Console.WriteLine( figura.powierzchnia() );

        List<Figura> figury = new List<Figura>();

        figury.Add(new Kolo(4.77));
        figury.Add(new Prostokat(2.3, 4.5));
        figury.Add(new Prostokat());
        figury.Add(new Kwadrat(7.5));

        Console.WriteLine("Liczba figur w kolekcji wynosi " + figury.Count);
        foreach (var element in figury)
        {
            Console.WriteLine(element.powierzchnia());
        }

        }
    }
}