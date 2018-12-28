using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args) {

            Figura figura = new Kolo(4.666);
            Console.WriteLine( figura.powierzchnia() );
            figura = new Kwadrat(4.666);
            Console.WriteLine( figura.powierzchnia() );
        }
    }
}