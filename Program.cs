using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {   int a = 12;
            int b = 0;

        try
        {
            a = a / b;
        }
        catch ( System.DivideByZeroException e) {
            Console.WriteLine(e.Source);
            Console.WriteLine("Wystąpił błąd dzielenia przez zero! Kończę działanie programu");
            return;
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }


            Osoba miki  = new Osoba();
            miki.setImie("Mikołaj");
            miki.setNazwisko("Radwański");

            Osoba tata = new Osoba();
            tata.setImie("Mirek");

            Console.WriteLine(miki.getImie() + ' ' + miki.getNazwisko() + ' ' + miki.getDataUr() );

            Console.WriteLine(tata.getImie() + ' ' + tata.getNazwisko() + ' ' + tata.getDataUr() );
        }
    }
}