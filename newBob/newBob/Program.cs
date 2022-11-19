using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newBob
{
    internal class Program
    {
        //oppgave 2
        //Let etter gunnar og ikke bob. hva skjer? må noe endres?
        // Måtte bytte bob.Contains og bomb.IndexOf til gunnar.

        //Oppgave 3
        //ikke let etter gunnar mer. endre tilbake til bob.
        //stringen bob skal leses inn fra en fil https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file
        //lag en stooor textfil. tar det lang tid? lag en enda større fil. test på nytt. fortsett. hvor stor fil kan vi ha?
        //Jeg kunne ha en 300kb fil som brukte 27 sek for å laste inn, noe større enn det viste ikke noe resultat.

        //oppgave 4
        //ta tiden på dette. Bruk datetime og datediff https://www.tutorialsteacher.com/articles/get-difference-between-two-dates-in-csharp
        //27 sekunder

        //oppgave 5
        //istedfor å ha alt i main, lag en metode av dette. Hva det letes etter og i hvor det letes skal være parametre. Returtype int

        //oppgave 6
        //lag en metode som heter KlassiskBob. Det er denne bobløsningen som bruker for loops
        //ta tiden på denne og avansert bob. hvem er raskest? her er det viktig at det er samme inputfil som brukes.
        //har ikke loop bobløsningen hjemme. men avansertbob er raskere, fordi på skolen når jeg hadde samme størrelse på tekstfil, så brukte den flere minutter

        static void AvansertBob()
        {
            int counter = 0;
            string bob = System.IO.File.ReadAllText(@"D:\Code\bob.txt"); //"aaabobobaaagunnarpergunnar";
            string newBob = "";
            int hvor = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (bob.Contains("bob"))
            //if (bob.Contains("bob"))
            {
                hvor = bob.IndexOf("bob");
                newBob = bob.Substring(hvor + 3, bob.Length - hvor - 3);//overwrite bob
                bob = newBob;
                counter++;
            }
            stopwatch.Stop();
            Console.WriteLine(counter);
            Console.WriteLine("Tid brukt: {0}", stopwatch.Elapsed);
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            AvansertBob();
        }
    }
}
