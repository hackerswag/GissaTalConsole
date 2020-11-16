using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Slumpa heltalsvariabel slumpTal mellan 1 och 100
            //Skapa heltalsvariabel antalGiss
            //Skriv ut "Skriv in din gissning:"
            //Be användaren mata in talGiss
            //Om talGiss är större än slumpTal
            //  Skriv ut "För stort" och låt användaren gissa igen
            //  Addera 1 till antalGiss
            //Om talGiss är mindre än slumpTal
            //  Skriv ut "För litet" och låt användaren gissa igen
            //   Addera 1 till antalGiss
            //Om talGiss är lika med slumpTal 
            //  Skriv ut "Rätt! Antal gissningar: antalGiss" 
            //  Stoppa programmet

            Random slumpTal1 = new Random();
            int slumpTal = slumpTal1.Next(1, 100);

            int antalGiss = 0;
            bool finish = false;

           
            while (!finish)
            {
                Console.WriteLine("Skriv in din gissning:");
                int talGiss = int.Parse(Console.ReadLine());
                
                if (talGiss > slumpTal)
                {
                    Console.WriteLine("För stort!");
                    antalGiss += 1;
                }
                if (talGiss < slumpTal)
                {
                    Console.WriteLine("För litet!");
                    antalGiss += 1;
                }
                if (talGiss == slumpTal)
                {
                    antalGiss += 1;
                    Console.WriteLine("Rätt! Antal gissningar: " + antalGiss);
                    Console.WriteLine("Tryck på valfri knapp för att avsluta");
                    Console.ReadLine();
                    finish = true;
                }


            }



            
           



           

            
        }

        



    }
}
