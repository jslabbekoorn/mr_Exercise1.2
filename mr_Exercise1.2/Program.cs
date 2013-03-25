using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mr_Exercise1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij versie v0.2 van deze Applicatie");
            Console.WriteLine("We kunnen een specifieke berekening doen met 2 getallen." + Environment.NewLine);
            Console.WriteLine("Voer het eerste getal in:");
            string strInput1 = Console.ReadLine();
            int intNumber1 = int.Parse(strInput1);

            Console.WriteLine("Voer het tweede getal in:");
            string strInput2 = Console.ReadLine();
            int intNumber2 = int.Parse(strInput2);

            Console.WriteLine("Kies uit de volgende berekening:" + Environment.NewLine
                                + "1. Optellen" + Environment.NewLine
                                + "2. Aftrekken" + Environment.NewLine
                                + "3. Delen" + Environment.NewLine
                                + "4. Vermenigvuldigen");

            //string strInput3 = Console.ReadLine();
            //string strBewerking = strInput3.ToLower();

            string strBewerking = Console.ReadLine().ToLower();


            int intUitkomst = 0;

            if (strBewerking == "optellen" || strBewerking == "+" || strBewerking == "1")
            {
                intUitkomst = intNumber1 + intNumber2;
            }
            else
            {
                if (strBewerking == "aftrekken" || strBewerking == "-" || strBewerking == "2")
                {
                    intUitkomst = intNumber1 - intNumber2;
                }
                else
                {
                    if (strBewerking == "delen" || strBewerking == "/" || strBewerking == "3")
                    {
                        intUitkomst = intNumber1 / intNumber2;
                    }
                    else
                    {
                        if (strBewerking == "vermenigvuldig" || strBewerking == "*" || strBewerking == "4")
                        {
                            intUitkomst = intNumber1 * intNumber2;
                        }
                        else
                        {
                            Console.WriteLine("ERROR");
                        }
                    }
                }
            }

            Console.WriteLine("De uitkomst is " + intUitkomst);
            Console.ReadLine();

        }
    }
}
