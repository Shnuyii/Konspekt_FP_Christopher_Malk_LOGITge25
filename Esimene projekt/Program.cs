using System.ComponentModel.Design;
using System.Threading.Channels;
using System;
using System.Net.Http.Headers;
using System.ComponentModel.DataAnnotations; // <-- enne nimeruumi, viidatakse selles failis/klassis kasutatud pakettidele/moodulitele ja süsteemi muudele osadele. süsteemi muuks osaks võib olla kas operatsioonisüsteemi võimalused või ka teised projektid. teised projektid viidatakse tavalist solution (.sln) failist.

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
            //List<int> vanused = new List<int>();
            //List<string> isikud = new List<string>() {"sinu",  "oma venna", "oma isa", "oma ema" };
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Sisesta "+isikud.ElementAt(i)+" pikkus sentimeetrites");
            //    //kuvame kasutajale teate, koos isikuga mida adresseeritakse tsüklimuutuja abil järjendist "isikud"
            //    vanused.Add(int.Parse(Console.ReadLine()));
            //    //Add on listi meetod elemendi listamiseks, lisatakse otse parsitud täisarv käsurea pealt
            //    i++;
            //    // suurendame i-d ühe võrra
            //} while (i < isikud.Count);

            //float perekeskmine = ((float)(vanused.ElementAt(0) + vanused.ElementAt(1) + vanused.ElementAt(2) + vanused.ElementAt(3)) / 4) / 100;
            //float vanematekeskmine = ((float)(vanused.ElementAt(2) + vanused.ElementAt(3)) / 2) / 100;
            //float lastekeskmine = ((float)(vanused.ElementAt(0) + vanused.ElementAt(1)) / 2) / 100;
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

            /* Näiteülesanne 9 -sünoptiku sõnum */

            //Kirjuta programm mis küsib kasutajalt viie järgmise päeva temperatuuri ja ilma kirjeldust
            //kui sünoptik on sisestuse lõpetanud, kuvab viis rida, mis kirjeldab viis päeva mõlema omadusega

            //Console.WriteLine("Tere sünoptik, ");
            //float[] temps = new float[5]; //temperatuuride massiiv
            //string[] kirjeldus = new string[5]; //kirjelduse massiiv
            //for (int i = 0; i < temps.Length; i++)
            //{
            //    Console.WriteLine("Esita palun järgmine temperatuur: ");
            //    temps[i] = float.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Ole hea ja kirjelda ka eesolev nädal,");
            //for (int i = 0; i < kirjeldus.Length; i++)
            //{
            //    Console.WriteLine("kirjelda " + (i + 1) + ". päeva:");
            //    kirjeldus[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Palun edasta uudistejaamale ilmateade:");
            //for (int i = 0; i < temps.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". päeval on temperatuur " + temps[i] + " kraadi ja ilm on " + kirjeldus[i] + ".");
            //    ;
            //}

            //List<float> graphData = new List<float>()
            //{
            //    3.6f,   //positiivne
            //    0,      //0
            //    0,
            //    4.5f,
            //    23.8f,
            //    106f,   //maksimaalne väärtus
            //    42.2f,
            //    -5.2f,  //negatiivne
            //    0,
            //    0,
            //    7f,
            //    6f,
            //};
            //int keskPunkt = 45;
            //foreach (var unitOfData in graphData)
            //{
            //    string displayableData = "";    //Kuvatav rida

            //    float calculatedData = keskPunkt + unitOfData;  //normaliseeritud andmed keskpunkti suhtes

            //    int i = 0;  //while-tsükli muutuja
            //    while (i<90)    //tsükkel töötab niikaua kuni i ei ole 90 ega suurem
            //    {
            //        int sm0 = (int)(45 + unitOfData);   //sm0 rea alguspunkt nähtavale pulgale, mitte tühjale alale
            //        if (0>i && i<sm0)   //kui i on vahemikus 0 ja sm0
            //        {
            //            displayableData += "▓";
            //        }
            //        else if (sm0 >= i && i < 45)    //kui i on vahemikus sm0 ja 45
            //        {
            //            displayableData += "█";
            //        }
            //        else if (sm0 >= i && i < 90)    //kui i on vahemikus sm0 ja 90
            //        {
            //            displayableData += "░";
            //        }
            //        else if (i >= sm0 && i <45)     //kui i on vahemikus sm0 ja 45
            //        {
            //            displayableData += "▓";
            //        }
            //        else
            //        {
            //            displayableData += "X";
            //        }
            //        i++;
            //    }
            //    Console.WriteLine(displayableData);
            //}

            /*
            Harjutused

            https://meet.google.com/qjt-wofj-gdb
            
            Teooria
            */
            

        

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

            //*  -= K O M P O S I I T A N D M E T Ü Ü B I D =-    *//
            //1. Massiiv
            //2. Loend
            //3. Sõnastik
            //4. Tuple

            /* 1 - MASSIIV */
            // [] - > Massiiv on komposiitandmetüüp, mille sees saab olla mitmeid sama tüüpi lihtandmeid. massiivi tähistatakse kantsulgudega.
            //        Massiive saab olla ükskõik millist lihtandmetüüpi massiive. massiivi tekitamisel peab ära ütlema kui pikk või kui suur
            //        vastav massiiv on. kuigi massiivis saab olla lihtandmetüübid, saab massiive moodustada ka teistel massiividest ja muudest
            //        komposiitandmetüüpidest. kui on moodustatud massiiv mis koosneb teistest massiividest on tegu mitmedimensioonilise massiiviga.
            //        näiteks on 20 massiiv selline massiiv kus on sees omakorda veel kaks lihtandmetüübist koosnevat massiivi, näiteks float.
            // Esimene tekitusviis:
            int[] uusMassiiv = new int[3];  //andmetüüp int väljendab, et tegu on täisarvutüüpi andmega, mis on massiiv, ja omab endas täisarve
                                            //muutuja nimi on "uusMassiiv" ning võrdusmärgi taga omistatakse sinna massiiv kolme elemendiga,
                                            //kus mitte ükski element hetkel veel väärtust ei oma. kui mitu elementi väljendatakse kantsulgude vahel,
                                            //peale andmetüüpi ja peale kaitstud sõna "new". New ütleb, et tegu on uue väärtusega selle muutuja sees.
                                            // Teine tekitusviis
            int[] uusMassiiv2 = [1, 2, 3];  //Teine masiivi tekitusviis, kus massiivi pikkuse sätestamise asemel antakse muutujasse kohe kindlate
                                            //väärtusega elemedid kaasa. Massiivi pikkus sätestama ei pea, kuna see tuletatakse sisestatud
                                            //elementide arvust.

            // - - Massiivi sisemised meetodid - -
            int kuiPaljuOn = uusMassiiv.Length;     //Massiivi meetod "Length" mille saame kasutusele võtta/adresseerida punkti abil. Loendab kokku
                                                    //mitu elementi massiivis on ja tagastab selle väärtuse. Selles näites omistatakse tagastatav
                                                    //väärtus muutujasse "kuiPaljuOn". väärtus saab olla ainult täisarv, sest poolikuid või osalisi
                                                    //elemente ei ole olemas

            /* 2 - LOEND */
            //List<T>   -> Loend on komposiitandmetüüp, kus sarnaselt massiiviga. saab olla mitmeid samat tüüpi andmeid. List kirjutatakse kui oma andmetüüp,
            //             kus sulgude vahel on loendis olevate individuaalsete elementide andmetüüp. Samamoodi nagu massiive, saab loendeid olla ükskõik
            //             millist lihtandmetüüpi ja komposiitandmetüüpi (isegi kui see on teine list). Erinevalt massiivist aga ei pea ütlema kui pikk loend
            //             ise on, massiivis tuleb see ette öelda. Loendi eripära on see, et teda saab dünaamiliselt oma pikkusel muuta, see tähendab et
            //             elemente saab eemaldada koos selle elemendi asukohaga. Massiivi puhul nii teha ei saa sest massiiv on konstantne ehk
            //             muutumatu pikkusega. Listi üksikelemendi andmetüüp asub noolsulgude vahel "<>" kaitstud sõna "List" järel.
            // Esimene tekitusviis:
            List<int> arvuLoend = new List<int>();  //Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, Listi noolsulgude vahel on loendis olevate
                                                    //andmete andmetüüp, antud juhul on siin täisarvud, ehk "int". Muutuja enda nimeks, kus andmeid
                                                    //hoitakse, on "arvuloend". Sellesse muutujasse omistatakse kaitstud sõna "new" abil uus, PIKKUSETA ja tühi
                                                    //loend täisarvudega.
            // Teine tekitusviis
            List<int> arvuLoend2 = new List<int>() {1,2,3};     //Teine loendi tekitusviis, andmetüübi kirjeldus "List<>" näitab et tegu on loendiga.
                                                                //Listi noolsulgude vahel on loendis olevate andmete andmetüüp, antud juhul on siin
                                                                //täisarvud, ehk "int". Muutuja enda nimeks, kus andmeid hoitakse, on "arvuloend2". Sellesse
                                                                //muutujasse omistatakse kaitstud sõna "new" abil uus ja tühi loend täisarvudega, kuid pärast
                                                                //andmetüübi gaga oleaid sulge, anname loogiliste sulgude vahel talle kaasa kohe ka elemendid.
                                                                //Antud juhul on tegu täisarvudega 1, 2 ja 3. Enam ei ole tegua PIKKUSETA EGA TÜHJA loendiga,
                                                                //vaid sarnaselt massiivile, tekib selle loendi pikkus, põhinedes selle mitu elementi on kaasa antud.
            // Kolmas tekitusviis:
            List<int> arvuLoend3 = new List<int>(3);       //Kolmas loendi tekitusviis, andmetüübi kirjeldus "List<>" näitab et tegu on loendiga.
                                                           //Listi noolsulgude vahel on loendis olevate andmete andmetüüp, antud juhul on siin
                                                           //täisarvud, ehk "int". Muutuja enda nimeks, kus andmeid hoitakse, on "arvuloend2". Sellesse
                                                           //muutujasse omistatakse kaitstud sõna "new" abil uus ja tühi loend täisarvudega, kuid loend omab kolme
                                                           //tühja elementi. Elementide arv sätestatakse peale noolsulge olevate tavaliste sulgude vahele.
                                                           //Arve, ega väärtusi, nende elementide sees veel ei ole.

            /* 3 - SÕNASTIK */
            //Dictionary<T, T>      -> Dictionary on komposiitandmetüüp, mis omab võtiväärtuspaare. Erinevalt eelnevatest komposiitandmetüüpidest, saab Dictionary omada
            //                         kahte erinevat andmetüüpi, millest esimene väljendab võtme andmetüüpi ning teine võtme taga olevat väärtuse andmetüüpi. Need
            //                         andmetüübid saavad üksteisest erineda või isegi omada klasse andmetüüpidena. 
            // Esimene tekitusviis:
            Dictionary<int, string> sõnastik = new Dictionary<int, string>();
            //Andmetüübi kirjeldus "Dictionary<>" näitab et tegu on sõnastikuga, ehk loendiga võtiväärtuspaaridest. Dictionary noolsulgude vahel asetatakse
            //kaks andmetüüpi, esimene neist on võtme andmetüüp (antud juhul "int") teine neist on võtme taga oleva väärtuse andmetüüp (antud juhul "string")
            //Muutuja nimeks on "sõnastik" kuhu omistatakse käsusõnaga "new" uus tühi sõnastik vastavate andmetüüpidega.

            Dictionary<int, string> sõnastik2 = new Dictionary<int, string>() { { 1, "astelpaju" }, { 2, "muulukas" }, { 3, "maasikas" } };
            //Andmetüübi kirjeldus "Dictionary<>" näitab et tegu on sõnastikuga, ehk loendiga võtiväärtuspaaridest. Dictionary noolsulgude vahel asetatakse
            //kaks andmetüüpi, esimene neist on võtme andmetüüp (antud juhul "int") teine neist on võtme taga oleva väärtuse andmetüüp (antud juhul "string")
            //Muutuja nimeks on "sõnastik" kuhu omistatakse käsusõnaga "new" uus sõnastik koos elementidega, mis asuvad sulgude taga olevatest loogilises
            //sulgudes ja iga element ise on veel omakorda loogilistes sulgudes infoga, mis vastab dictionary andmetüüpide sätestustele.

            //Sõnastiku tööriistad:
            sõnastik.Add(4, "tikker");          //.Add() võimaldab olemasoleva sõnaraamatu lõppu lisada elementi. Sulgude vahel on andmed, mille andmetüübid
                                                //vastavad täiendatava sõnastiku andmetüüpide sätestusega.
            sõnastik.Remove(2);                 //.Remove() eemaldab kindla võtme järgi sõnastikus oleva elemendi. Sulgude vahel on selle võtme andmetüübile vastav
                                                //väärtus, mitte võtme taga oleva väärtuse väärtus.
            sõnastik.Clear();                   //.Clear() teeb sõnastikku täielikult tühjaks.

            sõnastik.ContainsKey(4);            //.ContainsKey() tagastab kas "true" või "false" vastavalt sellele kas ta leiab antud sõnastikust parameetrina
                                                //kaasa antud võtme.
            sõnastik.ContainsValue("tikker");   //.ContainsValue() tagastab kas "true" või "false" vastavalt sellele kas ta leiab antud sõnastikust parameetrina
                                                //kaasa antud väärtuse.

            //Dictionary<List<int>, string> sõnastikkast = new Dictionary<List<int>, string>();

            //*  -= J U H U A R V =-    *//
            //
            // Random klass annab võimaluse programmeerijale genereerida pseudo-random väärtusi
            Random juhuArv = new Random();      //klassinimi "Random" on kasutatav kui andmetüüpi, mis ütleb et järgnevas muutujas nimega "juhuArv" on
                                                //uus random tüüpi objekt, mis omistatakse sinna "new Random()" käsuga. Konstruktor ulatab muutuja sisse
                                                //Random tüüpi klassi. Antud muutuja nüüd ise ei ole see juhuarv, ta toimib kui juhuarvude generaatorina
                                                //millest punkti abil saab adresseerida Random genereerimise tööriistu.
            int a = juhuArv.Next();             //.Next() on meetod Random klassis mis on genereeriv meetod juhuarvu genereerimiseks. Seda saab kasutada
                                                //kui väärtusena, ning ta tagastab suvalise arvu. Ilma parameetrita tagastab andmetüübi maksimaalpiirides
                                                //mingisuguse juhuarvu
            int miski = juhuArv.Next(5);        //.Next() ühe parameetriga anname talle ülemise piiri, mille alumine piir on vaikeväärtusena 0
            int miski2 = juhuArv.Next(-5, 5);   //.Next() kahe parameetriga kirjeldab ära täieliku vahemiku, olgu see siis negatiivne või positiivne
            double aDbl = juhuArv.NextDouble(); //.NextDouble() annab double-tüüpi väärtusi, parameetri kasutus on identne.
            float aLng = juhuArv.NextSingle();  //.NextSingle() annab float-tüüpi väärtuse mis on vahemikus 0.0 ja 1.0.

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
            
            ///* -= M U U T U J A D =-   */
            ////string string = "abc"; //bad
            //string sõna = "abc"; //very gud

            //int mingiArv = 4;
            //int mingiArv += 15;

            // 1     2    3   4  5
            string näidis = "def"; // 1 - Muutuja kirjutatakse alustades andmetüübist, ilma andmetüübita ei saa C# muutujat deklareerida
                                   // 2 - Seejärel kirjutatakse muutuja nimi mis väljendab andmeid ja nende andmele eesmärki nimisõnana
                                   //     soovitavalt kasutada muutujate nimetamisel camelCase stiili, esimene täht on väike, ülejäänud sõnad muutuja nimes algavad suure tähega
                                   // 3 - omistusoperaator mis annab muutujale andmed sisse
                                   // 4 - andmed mida omistatakse
                                   // 5 - lauselõpumärk
            //                    6
            List<bool> näidis2 = new List<bool>();  // 6 - kaitstud sõna "new" kasutatakse siis kui tahetakse instantseerida uude muutujasse
                                                    //     väärtust mille andmetüüp on kompleksne, ja vajab konstruktori väljakutset
                                                    //     komplekssetel andmetüüpidel on tihti vaja sisemiselt üles ehitada ennast
                                                    //     teiste andmetüüpide põhjal



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
            // ++   -> kiirtehe, mis muutujast lahutab ainult ühe maha
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

            /*      -= T I N G I M U S L A U S E - SWITCHCASE =-       */
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
            //Console.WriteLine(teisendatud );                 //teisenduse väljakuvamine

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

            /* -= T S Ü K L I D =-   */

            //Tsüklid on programmeerimises viis, kuidas automatiseerida korduv tegevus ära, see aitab hoida andmemahtu kokku, programmeerija sama
            //koodi mitu korda kirjutamist, ning väldib ka kordustest tekkinud vigu. C# on neli peamist tsükli liiki -
            // 1. do-while
            // 2. while
            // 3. for
            // 4. foreach
            // Tsüklitel on 3 peamist komponenti - käsklus ise, tsükli tingimus ja tehtav kood.

            /* -= T S Ü K L I D   DO-WHILE =-   */

            // Do-While tsükkel erineb kõigist teistest tsüklitest sellega, et tingimusekontroll toimub pärast esimest tegevusringi, kõikides
            // teistes tsüklites toimub tingimusekontroll enne esimest ringi.
            int tsükliMuutuja1 = 0;                 //Mingisugune muutuja, mis omab tsükli töö tingimuse abil kontrollimiseks vajalikku väärtust
                                                    //ehk tsüklimuutuja
            do                                      //"do" on kaitstud sõna, mis alustab do while tsüklit, sellele järgneb tsüklis tehtav koodiplokk
                                                    //ning mis esimene ring täidetakse ilma tingimuse kontrollita
            {
                Console.WriteLine(tsükliMuutuja1);  //koodiploki sees olev tegevus, antud juhul kuvatakse tsüklimuutuja arv välja
                tsükliMuutuja1++;                   //ning tsüklimuutuja suurendatakse
                //ILMA TSÜKLIMUUTUJA KAASAMISETA TSÜKLI TÖÖSSE, KÄIB TSÜKKEL RINGI LÕPMATULT, TSÜKLIMUUTUJA TULEB MINGIL KUJUL MUUTA KAS KAUDSELT VÕI
                //OTSESELT, ET SÜSTEEM SAAKS EDASI TEISTE TEGEVUSTE JUURDE MINNA, ILMA SELLETA SEE EI OLE VÕIMALIK
            } while (tsükliMuutuja1 != 5);          //*while* on kaitstud sõna mis do-while tsükli lõpetab, pärast seda toimub esimene tingimuse
                                                    //kontroll, kus kontrollitakse tsükli töösse kaasatud muutuja olukorda, kui tingimus täitub
                                                    //ehk tingimuse avaldise tulemus on "true" täidetakse veel üks ring, ning kontrollitakse tingimust uuesti.
                                                    //antud juhul tsükkel toimub niikaua, kuni tsüklimuutuja ei ole 5, ta saab olle 4 ja 6 ja ükskõik mis muu, aga mitte 5

            /* -= T S Ü K L I D   WHILE =-   */

            // While tsükkel on kõige tüüpilisem laadi tsükkel, tal on tingimusekontroll esimese ringi alguses, kuid tsükkel ei oma sisseehitatud tsüklimuutujat,
            // selle peab sätestama programmeerija
            string tsükliMuutuja2 = "10";                // Mingisugune muutuja, mis omab tsükli töö tingimuse abil kontrollimiseks vajalikk väärtust ehk tsüklimuutuja
            while (tsükliMuutuja2 != "0") ;               // "While" on kaitstud sõna, mis alustab while tsüklit, sellele järgneb sulgude vahel "()" olev
                                                          // tingimusekontroll, kus kontrollitakse tsüklimuutuja hetkeseisu, ning kui avaldis tagastab "true"
                                                          // tsükkel töötab veel ühe ringi, kui tingiumus ei täitu, siis ei täideta ka järgnevat ringi, ning
                                                          // tsükli töö katkeb. Antud juhul kontrollitakse, et tsüklimuutuja ei oleks võrdne sõnega, kus on tähemärk arvu 0 jaoks
            {
                Console.WriteLine("Esita tekst: ");      //koodiploki "()" sees olev tegevus, antud juhul küsitakse kasutajalt teksti esitust
                tsükliMuutuja2 = Console.ReadLine();     //mis seejärel omistatakse tsüklimuutuja enda sisse. 
            }

            /* -= T S Ü K L I D   FOR =-   */

            //for tsükkel, võrreldes dowhile või while tsükliga omab endas tsükli töö edasiviimiseks tsükli enda sätetuse sees, peale tingimusekontrolli
            //ka iseenda tsüklimuutujat, ning selle iseenda tsüklimuutuja muutmist. Tal on olemas kõik vajal, et teha oma tööd automaatsemalt kui while
            //võo dowhile tsüklit.

            int[] arvumassiiv = new int[5];              // muutuja, kus on andmed, mida tsükkel läbi töötleb.
            for (int k = 0; k < arvumassiiv.Length; k++) //kaitstud sõna "for" alustab for tsüklit, pärast mida on sulud, mille vahel on kõik tsükli töö
                                                         //jaoks vajalik. Esimene parameeter tekitab tsükli töö jaoks kohaliku muutuja - tsüklimuutuja
                                                         //ei eksisteeri väljaspool tsükli enda konteksti. selles eätestuses on kohaliku muutuja "int k = 0;"
                                                         //Teine parameeter on tsükli töö kontrollimiseks vajalik tingimusekontroll. samamoodi nagu while või
                                                         //dowhile juures, tingimuses täitumisel ("true") tsükkel teeb ühe ringi, mittetäitumisel tsükli töö
                                                         //katkeb. kolmas parameeter on tsüklimuutuja muutmine, selles näites seda kiirtehtega ++ seda
                                                         //inkrementeeritakse. on võimalik ka muud for sulgude vahelise operatsiooni konfiguratsioonid.
                                                         //iga for tsükli parameeter on tegelikult ka oma täielik koodilause. seega, eraldatakse sulgude vahel
                                                         //lauselõpumärgiga, välja arvatud viimane. viimase lõpetab sulg.
                                                         //sulgudele järgneb koodiplokk {}
            {
                Console.WriteLine("sisesta " + k + ". arv"); //Tegevus koodiploki sees, kus küsitakse kasutades tsüklimuutujat, kasutajalt mingindat arvu.
                arvumassiiv[k] = int.Parse(Console.ReadLine());//kasutades tsüklimuutujat, täidetakse massiiv.
            }

            /* -= T S Ü K L I D   FOREACH =-   */

            //Foreach tsükkel, võrreldes for-tsükliga, ei oma mitut parameetrit, vaid kindlat kollektsiooni kontrollivat tingimust, koos
            //iga elemendi jaoks tekitatava ajutise muutujaga. Foreach tsükkel käib ainult senikaua kuni elemendid pole otsa saanud. Foreach tsükkel tööd saab kontrollida
            //ainult läbi selle töödeldava kollektsiooni enda, et seda et tsüklimuutuja on kollektsiooni elementide arv, selle tsükli jaoks EI TEKITATA eraldi muutujat.

            List<string> sõnad = new List<string>() { "maasikas", "muulikas", "mustikas" }; //Muutujas, kus on andmed, mida tsükkel läbi töötleb
            foreach (var üksSõna in sõnad)      //Kaitstud sõna "foreach" alustab foreach tsükli, pärast mida on sulud mille vahel on tsükli töö
                                                //kontrolliv tingimus. selle tingimuse sees tekitatakse ajutine muutuja andmetüübiga "var"
                                                //töödeldava andmekogumi üksikelemendi jaoks. Tingimuse keskel on teine kaitstud sõna "in" mis
                                                //kontrollib, et tsükkel töötaks selle elemendi jaoks. Peale ühte ringi, vaadatakse kas elemente on järgi
                                                //kui on, omistatakse muutujasse "üksSõna" järgmine element, ning tsükkel käib veel ühe ringi. kui aga
                                                //elemente rohkem ei ole, tsükkel lõppeb. Tsükli tööd saab kontrollida näiteks kontrollitava kollektsiooni
                                                //suurendamisega. tsüklil ei ole tsüklimuutujat, kuna kollektsiooni järgi tsükkel töötab.
                                                //peale sulge on koodiplokk "{}" mille seees mingi tegevus tehakse.
            {
                Console.WriteLine(üksSõna);     //antud juhul, kuvatakse element välja
            }
            //NB - tsükli töö ei pea olema üldse seotud kontrollitava kollektsiooniga. kollektsioon ise võib olla ainult tsüklimuutuja eesmärgil sätestatud
        }
    }
}
