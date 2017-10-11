using System;
using static System.Console;

namespace array_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // type der im array enthaltenen Elemente,
                    // name des array
                                // object anlegt
                                            // reserviert 5 Plätze im Speicher
            string[] warenkorb = new string[7];
            warenkorb[0] = "200 gr. Tüte Gummibären";
            warenkorb[1] = "1 Pfund Butter";
            warenkorb[2] = "1 Paprika";
            warenkorb[3] = "1 kg Kaffee";
            
            // WriteLine("Wir wollen kaufen:\n{0}\n{2}\n{3}\n{1}\n", warenkorb);
            // mein WriteLine erspart folgende Schleife
            for(int artikel = 0; artikel < warenkorb.Length; artikel++) // 7 maximal, angegeben 4, lässt für die fehlenden eine Zeile
            {
                WriteLine("| {0} |", warenkorb[artikel]);
            }


            object[] universal = new object[10];
            universal[0] = "200 gr. Tüte Gummibären";
            universal[1] = 555;
            universal[2] = 'a';

            // WriteLine("{0}\n{1}", universal);
            for(int artikel = 0; artikel < universal.Length; artikel++)
            {
                WriteLine("| {0} |", universal[artikel]);
            }

            ReadLine();
        }
    }
}
