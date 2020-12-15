using System;

namespace Metoder11._1_11._9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kor = true;
            while(kor == true)
            {
                Console.Clear();
                Console.WriteLine("Skriv in namnet på uppgiften du vill se. Namnet är samma sak som uppgiftens siffor.\nT.ex. Övning [11.1] skriv in 11.1\n[A]vsluta");
                string val = Console.ReadLine();
                switch (val)
                {
                    case "11.1":
                        string meddelande;
                        Console.WriteLine("Skriv in ett ord");
                        meddelande = Console.ReadLine();
                        Hello(meddelande);
                        Console.ReadKey();
                        break;

                    case "11.2":
                        Console.WriteLine("Skriv in två ord");
                        string inmatning1 = Console.ReadLine();
                        string inmatning2 = Console.ReadLine();
                        LaggSammanTvaVariablar(inmatning1, inmatning2);
                        string sammanSlagning = LaggSammanTvaVariablar(inmatning1, inmatning2);
                        Console.WriteLine(sammanSlagning);
                        Console.ReadKey();
                        break;

                    case "11.3":
                        Console.WriteLine("Skriv in två tal");
                        int term1 = Convert.ToInt32(Console.ReadLine());
                        int term2 = Convert.ToInt32(Console.ReadLine());
                        int summa = Addera(term1, term2);
                        Console.WriteLine(summa);
                        Console.ReadKey();
                        break;
                    case "11.4":
                        Console.WriteLine("Skriv in ett tal så lägger programmet på momsen");
                        double moms = Convert.ToDouble(Console.ReadLine());
                        double momsatSvar = Moms(moms);
                        Console.WriteLine(momsatSvar);
                        Console.ReadKey();
                        break;
                    case "11.5":
                        Console.WriteLine("Skriv in ett tal");
                        double moms2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Skriv in momsen i procent form");
                        double momsProcent = Convert.ToDouble(Console.ReadLine());
                        double momsatSvar2 = Moms2(moms2, momsProcent);
                        Console.WriteLine(momsatSvar2 + " kr blir den totala kostnaden");
                        Console.ReadKey();
                        break;
                    case "11.6":
                        Console.WriteLine("Skriv in ett decimal tal så returnerar programmet det i procent form");
                        double procent = Convert.ToDouble(Console.ReadLine());
                        double procentForm = Procent(procent);
                        Console.WriteLine(procentForm + "%");
                        Console.ReadKey();
                        break;
                    case "11.7":
                        Console.WriteLine("Skriv in hur gammal du är");
                        int age = Convert.ToInt32(Console.ReadLine());
                        if (Myndig(age) == true)
                        {
                            Console.WriteLine("Du är myndig");
                        }
                        else
                        {
                            Console.WriteLine("Du är inte myndig");
                        }
                        Console.ReadKey();
                        break;
                    case "A":
                        kor = false;
                        break;
                    default:
                        Console.WriteLine("Felaktig inmatning");
                        break;
                }
            }
            
        }

 
        static bool Myndig(int age)
        {
            if(age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static double Procent(double procent)
        {
            procent = procent * 100;
            procent = Math.Round(procent);
            return procent;
        }

        static double Moms2(double moms2, double momsProcent)
        {
            momsProcent = (momsProcent / 100) + 1;
            moms2 = moms2 * momsProcent;
            return moms2;
        }

        static double Moms(double moms)
        {
            moms = moms * 1.25;
            return moms;
        }

        static int Addera(int term1, int term2)
        {
            int summa = term1 + term2;
            return summa;
        }

        static string LaggSammanTvaVariablar(string inmatning1, string inmatning2)
        {
            string sammanSlagning = inmatning1 +" "+ inmatning2;
            return sammanSlagning;
        }

        static void Hello(string meddelande)
        {            
            Console.WriteLine(meddelande + " är ett coolt ord!");
        }
    }
}
