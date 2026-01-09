using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Esimene_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///* näiteprogramm */
            //int palk = 2465;
            //int kulud = 1452;

            //Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? jah/ei");
            //string kasutajaVastus = "";
            //kasutajaVastus = Console.ReadLine();
            //if (kasutajaVastus == "jah")
            //{
            //    Console.WriteLine("sisesta kõik oma kulutused ühe arvuna");
            //    kulud = int.Parse(Console.ReadLine());
            //}

            //int kontojääk = palk - kulud;
            //    Console.WriteLine(kontojääk + " puulehtede jääk");
            //    Console.WriteLine("sisestage oma hästi tehtud töö boonus");
            //int boonus = int.Parse(Console.ReadLine());
            //kontojääk = kontojääk + boonus;
            //    Console.WriteLine("minu lõppväljavõte on: " + kontojääk + " puulehte");

            

            //Programm 2
            //Console.WriteLine("Tere tulemast baari, palun sisestage oma vanus");
            //int vanus;
            //vanus = int.Parse(Console.ReadLine());
            //if (vanus >= 18)
            //{
            //    Console.WriteLine("Tere, nautige meie mojitot 🍋‍");
            //}
            //else
            //{
            //    Console.WriteLine("Vabandust, alaealisi sisse ei lasta, head päeva");

            //Programm 3 vaheajaks
            //string kasutajanimi = "";
            //string parool = "";
            //Console.WriteLine ("tere, sisse logimiseks palun sisestage oma nimi");
            //kasutajanimi = Console.ReadLine();
            //if (kasutajanimi == "user1")
            //{
            //    Console.WriteLine(); ("tere user1, palun sisestage oma parool");
            //    parool = Console.ReadLine();
            //    if (parool == "qwerty")
            //    {
            //        Console.WriteLine ("tere tulemast user1, olete edukalt sisse logitud");
            //    }
            //    else
            //    {
            //        Console.WriteLine("kasutajanimi või parool on vale, sissepääs keelatud");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("kasutajanimi või parool on vale, sissepääs keelatud");
            //}

            //Programm 3 vaheajaks aga improved
            //string KasutajaNimi = "";
            //string Parool = "";
            //Console.WriteLine("Tere, sisse logimiseks palun sisestage oma nimi");
            //KasutajaNimi = Console.ReadLine();
            //Console.WriteLine("Palun sisestage oma parool");
            //Parool = Console.ReadLine();
            //if (KasutajaNimi == "user1" && Parool == "qwerty")
            //{
            //    Console.WriteLine("Olete edukalt sisse logitud, user1!");
            //}
            //else
            //{
            //    Console.WriteLine("Kasutajanimi või parool on vale, sissepääs keelatud.");
            //} 

            //Näiteülesanne 5
            //Console.WriteLine("Kui kaugele oli su viimane kuulitõuge (m)?");
            //float kaugus = float.Parse(Console.ReadLine());
            //if (kaugus <= 1.00 && kaugus >= 0.00)
            //{
            //    Console.WriteLine("Sa suudad kindlasti rohkem, cmon bruh");
            //}
            //else if (kaugus <= 2.00 && kaugus >= 1.01)
            //{
            //    Console.WriteLine("Noh tuleb juba, jõuad veel!");
            //}
            //else if (kaugus <= 3.00 && kaugus >= 2.01)
            //{
            //    Console.WriteLine("Tubli, kolm meetrit umbes, peaaegu, vist... not sure");
            //}
            //else if (kaugus < 0)
            //{
            //    Console.WriteLine("Ma ei käskinud selja taha visata...");
            //}
            //else
            //{
            //    Console.WriteLine("Ossaraks, seda on varsti orbiidilt näha");
            //}

            //Näiteülesanne 6
            Console.WriteLine("Palun sisesta oma vanus");
            int isikuVanus = 0;
            isikuVanus = int.Parse(Console.ReadLine());
            if (isikuVanus <=0)
            {
                Console.WriteLine("Ajarändureid me ei teeninda");
            }
            else if (isikuVanus > 0 && isikuVanus < 18)
            {
                Console.WriteLine("Palun sisesta oma nimi");
                string kasutajaNimi = "";
                kasutajaNimi = Console.ReadLine();
                Console.WriteLine($"Kallis {kasutajaNimi}, palun kutsuge siia oma lapsevanem");
            }
            else
            {
                Console.WriteLine("Palun kirjuta siia oma Eesnimi");
                string eesNimi = "";
                eesNimi = Console.ReadLine();
                Console.WriteLine("Palun kirjuta siia ka oma Perekonnanimi");
                string perekonnaNimi = "";
                perekonnaNimi = Console.ReadLine();
                if (eesNimi == "" || perekonnaNimi == "")
                {
                    Console.WriteLine("Sisestama pidi mõlemad nimed");
                }
                else
                {
                    Console.WriteLine($"Tere päevast {eesNimi} {perekonnaNimi}!");
                }
            }


                //*
                //Teooria

                //// andmetüübid
                //string tekst = "mingi loetav tekst";
                //char täht = 'a';
                //int arv = 1;
                //float komakohaga = 2.5f; //32bit
                //double suuremkomakohaga = 1.5d; //64bit
                //decimal kümnendsüsteemikomakohaga = 1.5M;
                //var x = 123; //umbmäärane andmetüübiga ajutine muutuja
                //var y = "tekst";
                //bool yesorno = false; //true or false

                ////string string = "abc"; //bad
                //string sõna = "abc"; //very gud
                //int mingiArv = 4;
                //int mingiArv += 15;

                //Console.WriteLine("Palun sisesta oma vanus");
                //int kasutajavanus = int.Parse(Console.ReadLine());
                //Console.WriteLine("Palun sisesta om vanavanema vanus");
                //int kasutajavanavanemavanus = int.Parse(Console.ReadLine());
                //int vanustevahe = kasutajavanavanemavanus - kasutajavanus;
                //Console.WriteLine("Ma ei tea mis see olema peaks, aga " + (kasutajavanavanemavanus - kasutajavanus));
                //Console.WriteLine("Kui palju vanem sa nüüd oled?");
                //kasutajavanus += int.Parse(Console.ReadLine());
                //Console.WriteLine("Vanuste vahe on nüüd: " + (kasutajavanavanemavanus - kasutajavanus));

                //* -= O M I S T U S O P E R A A T O R I D =-   */
                // =    -> üksik võrdusmärk omistab muutuja sisse väärtuse, mida adresseritakse muutuja enda nimega
                int muutuja = 1;
            // +=   -> võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva väärtuse
            muutuja += 2;
            // -=   -> võrdusmärk mille ees on miinus, automaatselt lahutab muutujas olevast väärtusest võrdusmärgi teisel pool oleva väärtuse
            muutuja -= 3;
            // *=   -> võrdusmärk mille ees on korrutusmärk, automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva väärtuse kordi
            muutuja *= 4;
            // /=   -> võrdusmärk mille ees on jagamismärk, automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva väärtuse osadeks
            muutuja /= 5;
            // %=   -> võrdusmärk mille ees on modulus, automaatselt jätab muutujasse jäägi
            muutuja %= 6;

            // ++   -> kiirtehe, mis muutujale liidab ainult ühe juurde
            muutuja++;
            // ++   -> kiirtehe, mis muutujale lahutab ainult ühe maha
            muutuja--;


            //* -= V Õ R D U S O P E R A A T O R I D =-   */
            // ==   -> "on võrdne/on täpselt sama" võrdusmärkide ühel pool olev objekt peab vastama oma olemuselt täpselt võrdusmärkide teisel pool oleva objektiga
            // >    -> "on suurem kui" märgist vasakul pool olev objekt peaks olema suurem kui paremal pool olev objekt
            // <    -> "on väiksem kui" märgist vasakul pool olev objekt peaks olema väiksem kui paremal pool olev objekt
            // >=   -> "on suurem kui, või samavõrdne" märgist vasakul pool olev objekt peaks olema vähemalt sama suur või suurem kui paremal pool olev objekt
            // <=   -> "on vöiksem kui, või samavõrdne" märgist vasakul pool olev objekt peaks olema vähemalt sama suur või väiksem kui paremal pool olev objekt
            // !=   -> "ei tohi olla" võrdusmärgi vasakul pool olev objekt ei tohi omada identset kuju paremal pool oleva objektiga, kõik muud väärtused on lubatud

            //* -= L O O G I L I S E D   T E H T E D =-   */
            // &&   -> "AND" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse "true"
            //         juhul kui mõlemal pool märki "&&" olevad tingimused omakorda annavad oma avaldise tulemusenda "true" või teisisõnu: true + true = true
            // ||   -> "OR" loogiline tehe, mida kasutatakse tingimuste kirjeldamisel, ning mis annab positiivse vastuse "true"
            //         juhul kui mõlemal pool märki "||" olev tingimus omakorda annab oma avaldise tulemusenda "true",
            //         ei ole vahet millisel pool märki või teisisõnu: true + true = true
            // !    -> "NOT" loogiline tehe, mida kasutatakse tingimuse avaldise tulemuse inverteerimiseks,
            //         tulemus mis muidu tagastaks "true", hüüumärgi abil nüüd tagastab "false", ja vastupidi - tulemus mis muidu tagastaks "false" nüüd tagastab "true".
            //         eh teisisõnu : true = false / false = true

        }
    }
}
