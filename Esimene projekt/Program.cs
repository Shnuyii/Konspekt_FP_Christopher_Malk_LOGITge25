using System.ComponentModel.Design;
using System.Threading.Channels;
using System;
using System.Net.Http.Headers; // <-- enne nimeruumi, viidatakse selles failis/klassis kasutatud pakettidele/moodulitele ja süsteemi muudele osadele. süsteemi muuks osaks võib olla kas operatsioonisüsteemi võimalused või ka teised projektid. teised projektid viidatakse tavalist solution (.sln) failist.

namespace Esimene_projekt  // <-- Nimeruum, sisaldab {} sulgude vahel konteinerit kus asub kogu programmi kood nime all "Esimene_projekt"
{
    internal class Program  // <-- programmi klass, mis on ka omakorda konteiner tüüp, kus sees on kogu programmi kood
    {
        static void Main(string[] args) // <-- "Main" on programmi sees olev meeotd mid vaikeväärtusena alati käivitatakse, kui ei ole teist meetodit käivituseks määratud
        {
            ///* näiteprogramm 1*/
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
            //Console.WriteLine("Palun sisesta oma vanus");
            //int isikuVanus = 0;
            //isikuVanus = int.Parse(Console.ReadLine());
            //if (isikuVanus <=0)
            //{
            //    Console.WriteLine("Ajarändureid me ei teeninda");
            //}
            //else if (isikuVanus > 0 && isikuVanus < 18)
            //{
            //    Console.WriteLine("Palun sisesta oma nimi");
            //    string kasutajaNimi = "";
            //    kasutajaNimi = Console.ReadLine();
            //    Console.WriteLine($"Kallis {kasutajaNimi}, palun kutsuge siia oma lapsevanem");
            //}
            //else
            //{
            //    Console.WriteLine("Palun kirjuta siia oma Eesnimi");
            //    string eesNimi = "";
            //    eesNimi = Console.ReadLine();
            //    Console.WriteLine("Palun kirjuta siia ka oma Perekonnanimi");
            //    string perekonnaNimi = "";
            //    perekonnaNimi = Console.ReadLine();
            //    if (eesNimi == "" || perekonnaNimi == "")
            //    {
            //        Console.WriteLine("Sisestama pidi mõlemad nimed");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Tere päevast {eesNimi} {perekonnaNimi}!");
            //    }
            //}

            //* Näiteülesanne 8 *//
            //kirjuta program mis
            //küsib kasutajatelt pikkust *sentimeetritest*
            //küsib tema teiste perekonnaliikmete pikkust (ema isa vend)
            // programm arvutab välja perekonnaliikmete pikkuse, vanemate keskmise pikkus, laste keskmise pikkuse ja kahe keskmise vahe
            // kõik arvud peab programm esitama komakohtadega arvudena
            //int kasutajapikkus = 0;
            //int vennapikkus = 0;
            //int emapikkus = 0;
            //int isapikkus = 0;
            //Console.WriteLine("Mis sinu pikkus sentimeetritest?: ");
            //kasutajapikkus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Mis sinu isa pikkus sentimeetritest?: ");
            //isapikkus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Mis sinu ema pikkus sentimeetritest?: ");
            //emapikkus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Mis sinu venna pikkus sentimeetritest?: ");
            //vennapikkus = int.Parse(Console.ReadLine());
            //float perekeskmine = ((float)(kasutajapikkus + emapikkus + isapikkus + vennapikkus)/4)/100;
            //float vanematekeskmine = ((float)(emapikkus + isapikkus)/2)/100;
            //float lastekeskmine = ((float)(kasutajapikkus + vennapikkus)/2)/100;
            //float vahe = 0;
            //if (vanematekeskmine > lastekeskmine)
            //{
            //    vahe = vanematekeskmine - lastekeskmine;
            //}
            //else
            //{
            //    vahe = lastekeskmine - vanematekeskmine;
            //}
            //Console.WriteLine($"Perekeskmine on {Math.Round(perekeskmine)} m, vanemate keskmine on {Math.Round(vanematekeskmine)} m ja laste keskmine on {Math.Round(lastekeskmine)} m, ning kahe keskmine vahe on {Math.Round(vahe)} m.");

            //* Näiteülesanne 8 list *//
            //int kasutajapikkus = 0;
            //int vennapikkus = 0;
            //int emapikkus = 0;
            //int isapikkus = 0;
            List<int> vanused = new List<int>();
            List<string> isikud = new List<string>() {"sinu",  "oma venna", "oma isa", "oma ema" };
            int i = 0;
            do
            {
                Console.WriteLine("Sisesta "+isikud.ElementAt(i)+" pikkus sentimeetrites");
                //kuvame kasutajale teate, koos isikuga mida adresseeritakse tsüklimuutuja abil järjendist "isikud"
                vanused.Add(int.Parse(Console.ReadLine()));
                //Add on listi meetod elemendi listamiseks, lisatakse otse parsitud täisarv käsurea pealt
                i++;
                // suurendame i-d ühe võrra
            } while (i < isikud.Count);
            
            float perekeskmine = ((float)(vanused.ElementAt(0) + vanused.ElementAt(1) + vanused.ElementAt(2) + vanused.ElementAt(3)) / 4) / 100;
            float vanematekeskmine = ((float)(vanused.ElementAt(2) + vanused.ElementAt(3)) / 2) / 100;
            float lastekeskmine = ((float)(vanused.ElementAt(0) + vanused.ElementAt(1)) / 2) / 100;
            float vahe = 0;
            if (vanematekeskmine > lastekeskmine)
            {
                vahe = vanematekeskmine - lastekeskmine;
            }
            else
            {
                vahe = lastekeskmine - vanematekeskmine;
            }
            Console.WriteLine($"Perekeskmine on {Math.Round(perekeskmine)} m, vanemate keskmine on {Math.Round(vanematekeskmine)} m ja laste keskmine on {Math.Round(lastekeskmine)} m, ning kahe keskmine vahe on {Math.Round(vahe)} m.");

            //* Näiteülesanne 7 *//
            //int minuarv = 9001;
            //Console.WriteLine(minuarv);
            //double minuDouble = minuarv;
            //Console.WriteLine(minuDouble);

            //double minuuusDouble = 6.7;
            //Console.WriteLine(minuuusDouble);
            //int minuuusArv = (int)minuuusDouble;
            //Console.WriteLine(minuuusArv);

            double newData1 = 1.23d;
            float newFloat1 = (float)newData1;
            long newLong1 = (long)newFloat1;
            int newInt1 = (int)newLong1;
            char newChar1 = (char)newInt1;

            int backToInt = newChar1;
            long backToLong = backToInt;
            float backToFloat = backToLong;
            double backToDouble = backToFloat;

            //* Näiteülesanne 4 *//
            //Console.WriteLine("Palun sisesta oma vanus");
            //int kasutajavanus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Palun sisesta om vanavanema vanus");
            //int kasutajavanavanemavanus = int.Parse(Console.ReadLine());
            //int vanustevahe = kasutajavanavanemavanus - kasutajavanus;
            //Console.WriteLine("Ma ei tea mis see olema peaks, aga " + (kasutajavanavanemavanus - kasutajavanus));
            //Console.WriteLine("Kui palju vanem sa nüüd oled?");
            //kasutajavanus += int.Parse(Console.ReadLine());
            //Console.WriteLine("Vanuste vahe on nüüd: " + (kasutajavanavanemavanus - kasutajavanus));

            //Console.WriteLine("Palun sisesta esimene arv.");
            //float arv1 = 0;
            //arv1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Palun sisestada teine arv.");
            //float arv2 = 0;
            //arv2 = float.Parse(Console.ReadLine());

            //string tehteTüüp = "";
            //Console.WriteLine("Palun sisestada tehte tüüp (+, -, *, /, ^, v)");
            //tehteTüüp = Console.ReadLine();

            //double tulemus = 0.0d;

            //Kalkulaator programm
            //if (tehteTüüp != "")
            //{
            //    switch (tehteTüüp)
            //    {
            //        default:
            //            Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
            //            break;
            //        case "+":
            //            tulemus = arv1 + arv2;
            //            break;
            //        case "*":
            //            tulemus = arv1 * arv2;
            //            break;
            //        case "-":
            //            tulemus = arv1 - arv2;
            //            break;
            //        case "/":
            //            tulemus = arv1 / arv2;
            //            break;
            //        case "^":
            //            tulemus = Math.Pow(arv1, arv2);
            //            break;
            //        case "v":
            //            tulemus = Math.Pow(arv1, 1 / arv2);
            //            break;
            //    }
            //    Console.WriteLine($"Teie tehte tulemus on {arv1} {tehteTüüp} {arv2} =  {tulemus}");
            //}
            //else
            //{
            //    Console.WriteLine("Tehet ei saa sooritada, tehte tüüp puudub");
            //}
            
            //Kalkulaator programm if ja else ifiga
            //Console.WriteLine("Palun sisesta esimene arv.");
            //float arv1 = 0;
            //arv1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Palun sisestada teine arv.");
            //float arv2 = 0;
            //arv2 = float.Parse(Console.ReadLine());

            //string tehteTüüp = "";
            //Console.WriteLine("Palun sisestada tehte tüüp (+, -, *, /, ^, v)");
            //tehteTüüp = Console.ReadLine();

            //double tulemus = 0.0d;


            //if (tehteTüüp == "+")
            //{
            //    tulemus = arv1 + arv2;
            //    Console.WriteLine($"Teie tehte tulemus on {arv1} {tehteTüüp} {arv2} = {tulemus}");
            //}
            //else if (tehteTüüp == "-")
            //{
            //    tulemus = arv1 - arv2;
            //    Console.WriteLine($"Teie tehte tulemus on {arv1} {tehteTüüp} {arv2} = {tulemus}");
            //}
            //else if (tehteTüüp == "*")
            //{
            //    tulemus = arv1 * arv2;
            //    Console.WriteLine($"Teie tehte tulemus on {arv1} {tehteTüüp} {arv2} = {tulemus}");
            //}
            //else if (tehteTüüp == "/")
            //{
            //    tulemus = arv1 / arv2;
            //    Console.WriteLine($"Teie tehte tulemus on {arv1} {tehteTüüp} {arv2} = {tulemus}");
            //}
            //else if (tehteTüüp == "^")
            //{
            //    tulemus = Math.Pow(arv1, arv2);
            //    Console.WriteLine($"Teie tehte tulemus on {arv1} {tehteTüüp} {arv2} = {tulemus}");
            //}
            //else if (tehteTüüp == "v")
            //{
            //    tulemus = Math.Pow(arv1, 1 / arv2);
            //    Console.WriteLine($"Teie tehte tulemus on {arv1} {tehteTüüp} {arv2} = {tulemus}");
            //}
            //else
            //{
            //    Console.WriteLine("Tehet ei saa sooritada, tehte tüüp puudub");
            //}
            


            //*
            //Teooria

            https://meet.google.com/qjt-wofj-gdb

            ///* -= S Ü N T A K S =-   */
            //Console.WriteLine("Ommik"); // <-- "1"
            //string vastus = Console.ReadLine(); // <-- "2"
            //Console.WriteLine(":)");
            // ;            - iga koodilause koodipoloki sees lõppeb lauselõpumärgiga
            // console      - Console on windowsi süsteemi/C# käsurea adresseerimise paktt, millega saab erinevaid käsurea operatsioone teha
            // .            - kasutatakse adresseerimiseks et saada punktile eelnevast objektist mingisugune meetod funktsioon, mis kirjutatakse pärast punkti, võib mõelda kui kaustasuunas olevat / slashi. Antud juhul kui adresseeritakse reas "1" Console tööriista
            // WriteLine    - funktsioon mida parasjagu kasutatakse. writeline kuvab käsurealse teksti, või kaasaantud parameetreid.
            // ()           - Sulupaar mis omab funktsiooni tööks vajalikku infot/parameetreid.
            // {}           - tähistab koodiplokki konteineri jaoks.
            // []           - tähistab massiivi.
            // ""           - tähistavad sõne andmetüüpi andmeid. Andmed ise asuvad jutumärkide vahel
            // "string"     - andmetüüp mis kirjutatakse alati muutuja ette. andmetüübis endas asuvad ka andmetüübile vajalikud funktsioonid
            // "vastus"     - muutuja, mille nimi on "vastus" mis omab string-tüüpi andmed mis omistatakse sinna sisse omistusoperaatoriga
            // ReadLine     - funktsioon mida reas "2" kasutatakse. ReadLine loeb käsurea pealt vaikeväärtusena sõne-tüüpi andmeid
            // //           - tähistab üherealist kommentaari
            // /**/         - tähistab plokk-kommentaari, kõik tärnide vahel olev on välja kommenteeritud
            // ///          - Funktsiooni summary kommentaar, kirjeldab meetodeid, mille tekst kuvatakse välja tooltipina
            //          - taane - aitab arendajal aru saada, kuskohas millise koodiploki sees kood parasjagu asub, ning aitab järge pidada

            //*  -= A N D M E T Ü Ü B I D =-    *//
            //string tekst = "mingi loetav tekst";
            //char täht = 'a';
            //int arv = 1;
            //float komakohaga = 2.5f; //32bit
            //double suuremkomakohaga = 1.5d; //64bit
            //decimal kümnendsüsteemikomakohaga = 1.5M;
            //var x = 123; //umbmäärane andmetüübiga ajutine muutuja
            //var y = "tekst";
            //bool yesorno = false; //true or false

            ///* -= M U U T U J A D =-   */
            ////string string = "abc"; //bad
            //string sõna = "abc"; //very gud

            // -------------------------------------------------------

            ///* -= K A I T S T U D  S Õ N A D =-       */
            // Kaitstud sõnad on kindlad nimisõnad/tegusõnad, mida C# kasutab oma koodistruktuuride tähistamiseks et ära hoida keerukat näpuga jälje ajamist, ning kompilaatori töö lihtsustamist
            // ei saa järgnevaid sõnu muutuja nimetusel kasutada, nendeks on:
            // abstract     as          base        bool        break       byte        case        catch       char            checked         class       count       continue
            // decimal      default     delegate    do          double      else        enum        event       explicit        extern          false       finally     fixed
            // float        for         foreach     goto        if          implicit    in          int         interface       internal        is          lock        long
            // namespace    new         null        object      operator    out         override    params      private         protected       public      readonly    ref
            // return       sbyte       sealed      short       sizeof      stackalloc  static      string      struct          switch          this        throw       try
            // true         typeof      uint        ulong       unchecked   unsafe      ushort      using       virtual         void            volatile    while

            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            //int mingiArv = 4;
            //int mingiArv += 15;

            // 1     2    3   4  5
            string näidis = "def"; // 1 - Muutuja kirjutatakse alustades andmetüübist, ilma andmetüübita ei saa C# muutujat deklareerida
                                   // 2 - Seejärel kirjutatakse muutuja nimi mis väljendab andmeid ja nende andmele eesmärki nimisõnana
                                   //     soovitavalt kasutada muutujate nimetamisel camelCase stiili, esimene täht on väike, ülejäänud sõnad muutuja nimes algavad suure tähega
                                   // 3 - omistusoperaator mis annab muutujale andmed sisse
                                   // 4 - andmed mida omistatakse
                                   // 5 - lauselõpumärk

            

            /* -= O M I S T U S O P E R A A T O R I D =-   */
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


            /* -= V Õ R D U S O P E R A A T O R I D =-   */
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

            /* -= T I N G I M U S L A U S E =-   */
            if (true)      //kaitstud sõna "if" kutsub esile tingimuslause, mille tingimuse avaldis on sellele järgnevatele () sulgude vahel
            {              //Järgneb {} loogiliste sulgude vahel koodiplokk, mis teostatakse siis, kui tingimuse avaldis annab tulemusena "true", "false" tulemuse puhul jäetakse kood vahele
            }
            else if (true) // Kaitstud sõna "else" ja "if" (koos "else if") kutsuvad esile sekundaarse tingimuslause, mille tingimus on samamoode sellele järgnevate sulgude vahel, ning millele peab alati eelnema "if" või teine "else if"
            { }            // Else if tingimust kontrollitakse ainult siis, kui sellele eelnev tingimus tagastab avaldise tulemusena "false"
                           // "false" puhul jäetakse plokk vahele
            else           // kaitstud sõna "else" kutsub esile järeltingimuslause, millele peab eelnema alati kas "if" või "else if" tingimuslause
                           // mille koodploki sisu täidetakse ilma oma tingimuse avaldise kontrollita (ei oma avaldist) kuna else koodiplokk teostatakse
                           // kõikide teiste tingimuste läbikukkumisel (kõik eelnevad tagastavad tulemusena "false")
            {

            }
            /* -= T I N G I M U S L A U S E - SWITCHCASE =-   */
            int option = 3; // --------
            switch (option) // "Switch" on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saad if-elseif-else asemel kasutada. sulgude vahel käib muutuja nimi, mille põhjal tingimuslik 
                            // ümberlülitus toimub. Siin sulgude vahel ei ole tingimus ise, vaid kõige kontrollitav muutuja, või omakorda sulgude vahel muu tingimuse avaldis. Pärast lülitusvalikut tuleb koodiplokk
            {
                case 1:     // koodiploki sees on erinevad juhtumid või vasted väärtuste korral mis võivad olla lülitusvalikus oleva muutuja sees
                            // Iga juhtum/vaste kirjutatakase kaitstud sõnaga "case" ning väärtus selle järel millele see juhtum vastab. antud juhul see juhtum toimib, kui muutujas "option" on täisarv 1. Peale võimalikku väärtust on koolon väljendades juhtumi täitumisel tehtavad programmikoodi.
                    Console.WriteLine("Nope"); //antud juhul kuvatakse juhtumi 1 puhul kasutajale sõnum
                    break;
                case 2:     // Juhtumeid võib olla mitmeid, antud juhul on siin näidises neid 3+1 (3 kindlat väärtust ja 1 vaikeväärtus)
                    break;
                case 3:
                    Console.WriteLine(option);  // Antud juhul kuvatakse juhumi 3 puhul kasutajale muutujas "option" asuv väärtus välja.
                    break;    
                default:    //default juhtum täitub siis, kui ülejäänud kirjeldatud juhtumid ei kata switchi lülitusvalikus olevas muutujas asuval väärtust. Toimib nagu else, kui erinevalt if-elseif-else struktuurist võib default olla ka alguses
                    break;  // kui antud juhtumi tegevus on tehtud, väljutakse mitte ainult juhtumist, vaid ka kogu käesolevat switch-case tingimustikust. Peale breaki on lauselõpumärk.
            }


            /* -= T E I S E N D A M I N E / C A S T I M I N E =-   */
            // automaatne castimine toimub siis, kui teisendatakse väiksemast andmetüübist suuremasse, sellisel juhul programmeerija spetsiifiliselt castima ei pea.
            //Manuaalne castimine toimub siis, kui teisendatakse suuremast andmetüübist väiksemasse, sellisel juhul on vaja suurema andmetüübiga muutuja ette asetada sulupaar, kus on soovitav andmetüüp sees

            // Manuaalne castimine (explicit)
            double newData2 = 1.23d; // tekitatakse, või on olemas doubletüüpi andmed muutujas newData2
            float newFloat2 = (float)newData2; //Toimub teisendus väiksemasse float andmetüüpi, double andmetüübist.
            long newLong2 = (long)newFloat2; //Toimub teisendus väiksemasse long andmetüüpi, float andmetüübist.
            int newInt2 = (int)newLong2; //Toimub teisendus väiksemasse int andmetüüpi, long andmetüübist.
            char newChar2 = (char)newInt2; //Toimub teisendus väiksemasse char andmetüüpi, int andmetüübist.

            //Automaatne castimine (Implicit)
            int backToInt2 = newChar2; //Toimub teisendus suuremasse int andmetüüpi, char andmetüübist.
            long backToLong2 = backToInt2; //Toimub teisendus suuremasse long andmetüüpi, int andmetüübist.
            float backToFloat2 = backToLong2; //Toimub teisendus suuremasse float andmetüüpi, long andmetüübist.
            double backToDouble2 = backToFloat2; //Toimub teisendus suuremasse double andmetüüpi, float andmetüübist.

            //Suuremast väiksemasse teisendus kaotab andmeresolutsiooni,
            //kaotatud andmeid ei saa tagasi suuremasse andmetüüpi castimisega tagasi

            // Parsimine on tekstist katse teisendada mingit tüüpi arvandmeid. Teisendus toimub küsides mingist andmetüübist talle siiseehtatud
            // meetodi "Perse()" abil mingist sõnest arvandmeid.
            //string seeontekst = "";                         //Mingisugune sõne mis omab endas potentsiaalselt mingit arvulist väärtust
            //int teisendatud = int.Parse(seeontekst);        //muutuja "teisendatud" kuhu omistatakse "Prase()" meetodi abil sonest arvväärtust
            //Console.WriteLine(teisendatud);                 //teisenduse väljakuvamine

            // Parsimisel on olemas ka alternatiivne meetod "TryParse()". TryParse üritab teisendada, ning kui teisendus kukub läbi, tagastatakse
            // algne väärtus/false
            string seeOnTekst = "1";                                        //Mingisugune sõne mis omab endas potentsiaalselt mingit arvulist väärtust
            Console.WriteLine(int.TryParse(seeOnTekst, out int result));    //teisenduse tulemuse väljakuvamine

            //konverteerimine on mingisuguse andme otsene teisendus ükskõik millisesse teise andmetüüpi. Selle jaoks on olemas moodul "Convert".
            //Convert moodulis on sarnaselt arvandmetüüpides olevale ToString() meetodile ka muude andmetüüpide vastavad konverteerimismeetodid
            //var mingiinfo = "65.44";                                    //On olemas mingisugune teisendamist vajav info
            //string mingiinfoTekst = Convert.ToString(mingiinfo);        //Convert.ToString() teisendab tundmatust andmetüübist info stringiks/sõneks
            //char mingiInfoChar = Convert.ToChar(mingiinfo);             //teisendus täheks
            //int mingiInfoInt = Convert.ToInt32(mingiinfo);              //teisendus int andmetüüpi
            //long mingiInfoLong = Convert.ToInt64(mingiinfo);            //teisendus long andmetüüpi
            //float mingiInfoFloat = Convert.ToSingle(mingiinfo);         //teisendus float andmetüüpi
            //double mingiInfoDouble = Convert.ToDouble(mingiinfo);       //teisendus double andmetüüpi
            //decimal mingiInfoDecimal = Convert.ToDecimal(mingiinfo);    //teisendus decimaliks
            //byte mingiInfoByte = Convert.ToByte(mingiinfo);             //teisendus baidiks
            //bool mingiInfoBool = Convert.ToBoolean(mingiinfo);          //teisendus booleani


        }
    }
}
