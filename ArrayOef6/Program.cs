using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOef6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens     
            // 29/01/2024
            // Oef6: Array

            // Velden 

            String[] _voornamen = new string[0];
            Byte[] _aanbodGekomen = new Byte[0];

            int _aantal = 0;

            byte _keuze = 0;

            // Programma
            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Stap 1:  Toon menu (ingeven aantal Leerlingen, namen ingeven, Willekeurige leerling tonen, namen aanpassen, namen verwijderen, leerlingen tonen die al geweest zijn,  afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Ingeven aantal leerlingen \n   2) Alle namen ingeven \n   3) Willekeurige leerlingen kiezen \n   4) Leerlingen Aanpassen \n   5) Leerlingen wissen \n   6) Weergeven leerlingen \n   7) Afsluiten");
                Console.Write("\n\n: uw keuze: ");


                try
                {
                    // Keuze opslaan
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm wissen
                    Console.Clear();

                    // Als 1: Vraag het aantal leerlingen + sla op 
                    if (_keuze == 1)
                    {
                        Console.Write($"Hoeveel leerlingen telt je klas : ");
                        _aantal = int.Parse(Console.ReadLine());

                        _voornamen = new string[_aantal];
                        _aanbodGekomen = new byte[_aantal];

                        // Scherm wissen
                        Console.Clear();

                        // Gebruiker begeleiden
                        Console.WriteLine("\n\nDe klas werd aangemaakt.");
                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    // Als 2: Vraag alle namen + sla op 
                    else if (_keuze == 2)
                    {
                        // Vraag de namen 
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {
                            Console.Write($"Geef leerling {(i + 1).ToString()} in : ");
                            _voornamen[i] = Console.ReadLine();
                        }

                        // Gebruiker begeleiden
                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }
                    //Als 3: Toon willekeurige leerling .
                    else if (_keuze == 3)
                    {
                        // Maak een random aan 
                        Random rdm = new Random();
                        // Neem een random getal + opslaan 
                        byte llnIndex = Convert.ToByte(rdm.Next(0,_voornamen.Count()));

                        // toon de leerling
                        Console.WriteLine($"de leerling die naar voren moet gaan is: {(llnIndex+1).ToString() }{_voornamen[llnIndex]}");
                        Console.WriteLine("Druk op enter om verder te gaan.");
                        Console.ReadKey();

                        // Scherm wissen 
                        Console.Clear();

                        // Vraag of de leerling zijn beurt heeft afgewerkt
                        Console.WriteLine ("Heeft de leerling zijn beurt afgewerkt?");
                        Console.Write("J / N :");
                        
                        // Verwerking 
                        if(Console.ReadLine().ToUpper() == "J")
                        {
                            _aanbodGekomen[llnIndex] = 1;
                        }

                    }
                    //Als 4: Leerlingen Aanpassen 
                    else if (_keuze == 4)
                    {
                        // Array overlopen 
                        for(int i = 0; i<_voornamen.Count();i++)
                        {
                            Console.WriteLine($"{(i+1).ToString()}) {_voornamen[i]}");
                        }

                        Console.WriteLine("\n\nGeef het nummer van de leerlingen die je wilt aanpassen.");
                        Console.Write("Nummer: ");
                        byte llnNummer = Byte.Parse(Console.ReadLine());

                        // Scherm wissen 
                        Console.Clear();

                        Console.Write("Geef de nieuwe naam: ");
                        _voornamen[llnNummer-1] = Console.ReadLine();

                        // Scherm wissen 
                        Console.Clear();
                        Console.WriteLine("Deze leerling werd aangepast.");
                        Console.WriteLine("Druk op een toets om verder te gaan.");
                        Console.ReadKey(); 


                    }
                    //Als 5: Leerlingen wissen.
                    else if (_keuze == 5)
                    {
                        // Array overlopen 
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {
                            Console.WriteLine($"{(i + 1).ToString()}) {_voornamen[i]}");
                        }

                        Console.WriteLine("\n\nGeef het nummer van de leerlingen die je wilt verwijderen.");
                        Console.Write("Nummer: ");
                        byte llnNummer = Byte.Parse(Console.ReadLine());

                        // Scherm wissen 
                        Console.Clear();

                        _voornamen[llnNummer - 1] = null;
                        _aanbodGekomen[llnNummer - 1] = 0;

                        // Scherm wissen 
                        Console.Clear();
                        Console.WriteLine("Deze leerling werd gewist.");
                        Console.WriteLine("Druk op een toets om verder te gaan.");
                        Console.ReadKey();

                    }
                    //Als 6: Toon de namen op het scherm in 2 groepen.
                    else if (_keuze == 6)
                    {
                        // Array overlopen 
                        Console.WriteLine("Volgende mensen zijn reeds aan bod gekomen:\n");
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {

                            if (_aanbodGekomen[i] == 1)
                            {
                                Console.WriteLine($"{(i + 1).ToString()}) {_voornamen[i]}");
                            }
                            
                        }

                        Console.WriteLine("\n\nVolgende mensen moeten nog aan bod komen:\n");
                        // Array overlopen 
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {
                            if (_aanbodGekomen[i] == 0)
                            {
                                Console.WriteLine($"{(i + 1).ToString()}) {_voornamen[i]}");
                            }

                        }
                    }

                    // Als 4: Sluit af.
                    else if (_keuze == 7)
                    {
                        // afsluiten
                        Console.WriteLine("Dag en tot een volgende keer.");
                        Console.WriteLine("Druk op enter om af te sluiten.");
                        Console.ReadKey();
                    }
                    else
                    {

                        // foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();

                }

            } while (_keuze != 7);
        }
    }
}
