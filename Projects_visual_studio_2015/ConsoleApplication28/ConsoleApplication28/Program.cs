using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperSeponSuunnistusSimulaattori
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Setit
            int sijoitus = 0;
            int ero = 0;
            int terveys = 0;
            int pummikerroin = 0;
            string peesaus = "";

          

            Random random = new Random();
            Console.WriteLine("Jos teksti on liian pienellä säädä se consolin asetuksista isoksi, in myös suositeltavaa venyttää ikkuna isoksi.");
            Console.WriteLine("Paina enteriä tämän jälkeen");
            Console.ReadLine();
            #endregion

            #region Aloitus
            Console.WriteLine("Tervetuloa pelaamaan super-Sepon-Suunnistussimulaattoria.");
            Console.WriteLine("Paina aina enteriä viestin jälkeen, jos sinulta ei kysytä jotain vastausta.");
            Console.ReadKey();
            Console.WriteLine("Valintasi vaikuttavat suunnistus suoritukseen sekä täten lopputulokseen.");
            Console.ReadKey();
            Console.Write("Aluksi, anna nimesi: ");
            string nimi = Console.ReadLine();
            while (nimi =="")
            {
                Console.WriteLine("Anna nimesi");
                nimi = Console.ReadLine();
                Console.WriteLine("");

            }
            #endregion

            #region Valmistelu
            Console.WriteLine(nimi + ", olet viestin ensimmäisellä osuudella ja kilpailun maasto on polkurikasta avokalliota. Maasto on yleisesti nopeakulkuista.");
            Console.ReadKey();
            Console.WriteLine("Ota huomioon, että kisassa on hajonta rasteja ja niillä et tiedä tilannetta verrattuna muihin.");
            Console.ReadKey();
            Console.WriteLine("Otit mukaan nastarit ja nappulakengät.");
            Console.ReadKey();
            Console.WriteLine("Valitse toiset kengät, jos haluat nastarit kirjoita \"1\" tai jos haluat nappulakengät kirjoita \"2\".");
            Console.ReadKey();
            Console.Write("Anna vastauksesi: ");
            string kengät = Console.ReadLine();
            while (true)
            {
                if (kengät == "1" || kengät == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kirjotitko varmasti \"1\" tai \"2\" ?");
                }
                kengät = Console.ReadLine();
                
            }
            Console.WriteLine("Nyt on aika suunnata alkuverryttelyyn");
            Console.WriteLine("");

            Console.ReadKey();

            #endregion

            #region Rastiväli1
            Console.WriteLine("Alkuverryttely on ohi ja lähtöön on enää aikaa 1 minuutti.");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Lähtö on tapahtunut ja luet ensimmäistä rastiväliä.");
            Console.ReadKey();
            Console.WriteLine("Ensimmäinen rastiväli on n. 400m päässä pitkän ja loivan avokalliomäen takana.");
            Console.ReadKey();
            Console.WriteLine("Reitinvalinnoissa esitellää neljä kohtaa: 1. välin yleinen kuvaus, 2. poikkeana yhdysviivasta, 3. letkan suuruus, mikä suuntaa samaan reitinvalintaan sekä nousumäärä.");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("1. Reitinvalinta: 1. nouse mäen päälle ja kuljen sitä pitkin, 2. kuljen mäen reunaa pitkin, 3. Kierrän polkua pitkin");
            Console.WriteLine("Poikkeama: 1. 15m, 2. 5m, 3. 50m | Letkat: 1. Runsas, 2. Runsas, 3. Runsas | Nousu: 1. 5m, 2. 3m, 3. 0m");
            Console.ReadLine();
            Console.Write("Anna vastauksesi: ");
            string reitinvalinta1 = Console.ReadLine();
            while (true)
            {
                if (reitinvalinta1 == "1" || reitinvalinta1 == "2" || reitinvalinta1 == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kirjotitko varmasti \"1\", \"2\" tai \"3\"?");

                    reitinvalinta1 = Console.ReadLine();
                }
            }
            Console.WriteLine("Rastilla sinulle kerrotaan ero kärkeen ja online-rasteilla kuulet myös sijoituksesi");
            Console.ReadKey();

            int sattuma = random.Next(0, 100);
            int sattuma2 = random.Next(0, 10);
            int sattuma3 = random.Next(5, 15);
            int sattuma4 = random.Next(10, 30);
            int sattuma5 = random.Next(30, 60);


            if (reitinvalinta1 == "1" && kengät == "2" && sattuma > 60)
            {
                Console.WriteLine("Liukastuit mäen päällä mutta et satuttanut itseäsi sen pahemmin");
                Console.ReadKey();
                ero += sattuma4;
            }
            else if (reitinvalinta1 == "1" && kengät == "2" && sattuma > 20)
            {
                Console.WriteLine("Suoritit välin suunnitellusti ja leimaat kärjen tuntumassa rastilla.");
                Console.ReadKey();
                ero += sattuma2;
            }
            else if (reitinvalinta1 == "1" && kengät == "2" && sattuma >= 0)
            {
                Console.WriteLine("Liukastuit mäen päällä ja satutit polvesi.");
                Console.WriteLine("Kipu kuitenkin katosi nopeasti mielestäsi.");
                Console.ReadKey();
                terveys += sattuma4;
                ero += sattuma5;
            }
            else if (reitinvalinta1 == "1" && kengät == "1" && sattuma >= 20)
            {
                Console.WriteLine("Suoritit välin suunnitellusti ja leimaat kärjen tuntumassa rastilla.");
                Console.ReadKey();
                ero += sattuma2;
            }
            else if (reitinvalinta1 == "1")
            {
                Console.WriteLine("Laskeudut rastille n. 10m sivuun.");
                Console.ReadKey();
                ero += sattuma3;

            }
            else if (reitinvalinta1 == "2" && sattuma > 20)
            {
                Console.WriteLine("Suoritit välin suunnitellusti ja leimaat kärjen tuntumassa rastilla.");
                Console.ReadKey();
                ero += sattuma2;
            }
            else if (reitinvalinta1 == "2")
            {
                Console.WriteLine("Ajaudut rastin ohi n. 10m ennen kuin huomaat ohittaneesi rastin.");
                Console.ReadKey();
                ero += sattuma3;
            }
            else if (reitinvalinta1 == "3")
            {
                Console.WriteLine("Luukutat välin tietä ja ehdit lukea tulevia rastivälejä, mutta huomaat jääneesi, että kärki on jo mennyt.");
                Console.ReadKey();
                pummikerroin -= 10;
                ero += sattuma3;
            }
            Console.WriteLine("");

            Console.WriteLine("Eroa kärkeen ei voida tietää hajonta rastilla.");
            Console.WriteLine("");

            Console.ReadKey();
            #endregion

            #region Rastiväli 2
            Console.WriteLine("Toinen rastiväli on n. 200m toisessa mäessä, mäkien välissä on suota sekä ojia.");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("2. Reitinvalinta: 1. Juokset suoraan viivaa pitkin, 2. Kierrät vasemmalta mäen reunoja pitkin");
            Console.WriteLine("Poikkeama: 1. 0m, 2. 15m | Letkat: 1. Runsas, 2. Runsas | Nousu: 1. 10m, 2. 5m");
            Console.ReadKey();
            Console.WriteLine("Anna vaihtoehtosi");
            string reitinvalinta2 = Console.ReadLine();
            while (true)
            {
                if (reitinvalinta2 == "1" || reitinvalinta2 == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kirjotitko varmasti \"1\" tai \"2\"?");
                    reitinvalinta2 = Console.ReadLine();
                }
            }
            sattuma = random.Next(0, 100);
            sattuma2 = random.Next(0, 10);
            sattuma3 = random.Next(5, 15);
            sattuma4 = random.Next(10, 30);
            sattuma5 = random.Next(30, 60);
            if (reitinvalinta2 == "1" && sattuma > 50)
            {
                Console.WriteLine("Suo kestää hyvin painosi ja suoritat välin suunnitellusti");
                ero -= sattuma3;
            }
            else if (reitinvalinta2 == "1")
            {
                Console.WriteLine("Suo olikin upottavaa, mutta selviydyt kohtalaisen nopeasti");
                ero += sattuma2;
            }
            else if (reitinvalinta2 == "2" && sattuma > 50)
            {
                Console.WriteLine("Kiersit rastille suunnitellusti, mutta osa suoraan menneistä olivat vähän nopeampia");
                ero += sattuma2;
            }
            else if (reitinvalinta2 == "2")
            {
                Console.WriteLine("Kiersit rastille suunnitellusti ja huomasit taivoittaneesi kärkeä");
                ero -= sattuma2;
            }
            Console.ReadLine();
            Console.WriteLine("");

            if (ero > 0)
            {
                Console.WriteLine("Olit rastilla " + ero + " sekuntia kärjestä.");
            }
            else
            {
                Console.WriteLine("Olet "+ero+" edellä toista.");
            }
            Console.WriteLine("");

            Console.ReadKey();
            #endregion

            #region Rastiväli 3
            Console.WriteLine("Kolmas rastiväli on n. 1200m päässä. Suora reitti kulkee usean mäen läpi.");
            Console.WriteLine("Mäet on mahdollista kiertää joko pohjoisesta soita pitkin tai etelästä peltoa sekä polkuja pitkin pitkin");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("3. Reitinvalinta: 1. nouse mäen päälle ja kulje niitä pitkin, 2. kulje pohjoisesta soita pitkin, 3. kierrä etelästä peltoa sekä polkuja pitkin");
            Console.WriteLine("Poikkeama: 1. 15m, 2. 175m, 3. 300m | Letkat: 1. Kohtalainen, 2. Vähäinen, 3. Kohtalainen | Nousu: 1. 40m, 2. 5m, 3. 10m");
            Console.ReadLine();
            Console.Write("Anna vastauksesi: ");
            string reitinvalinta3 = Console.ReadLine();
            while (true)
            {
                if (reitinvalinta3 == "1" || reitinvalinta3 == "2" || reitinvalinta3 == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kirjotitko varmasti \"1\", \"2\" tai \"3\"?");

                    reitinvalinta3 = Console.ReadLine();
                }
            }

            sattuma = random.Next(0, 100);
            sattuma2 = random.Next(0, 10);
            sattuma3 = random.Next(5, 15);
            sattuma4 = random.Next(10, 30);
            sattuma5 = random.Next(30, 60);

            if (reitinvalinta3 == "1" && kengät == "2" && sattuma > 50)
            {
                Console.WriteLine("Selviydyt rastivälistä suunnitellusti, mutta huomasit jäänesi nopeimmille.");
                ero += sattuma4;
            }
            else if (reitinvalinta3 == "1" && kengät == "2")
            {
                Console.WriteLine("Joudut varomaan liukkailla kallioilla, joten jäät välillä kärkeen");
                ero += sattuma4;
            }
            else if (reitinvalinta3 == "1")
            {
                Console.WriteLine("Selviydyt rastivälistä suunnitellusti, mutta huomasit jäänesi nopeimmille.");
                ero += sattuma4;
            }
            else if (reitinvalinta3 == "2" && sattuma > 60)
            {
                Console.WriteLine("Suot ovat kuivia ja huomaat reitin olleen nopea.");
                ero -= sattuma4;
            }
            else if (reitinvalinta3 == "2")
            {
                Console.WriteLine("Suot ovat märkiä, mutta selviydyt välistä kohtalaisen nopeasti");
                ero += sattuma3;
            }
            else if (reitinvalinta3 == "3")
            {
                Console.WriteLine("Huomaat reitin olleen hyvä, vaikka kierto tuli kohtalaisen paljon.");
                ero -= sattuma3;
            }
            Console.ReadKey();
            Console.WriteLine("");

            if (ero > 0)
            {
                Console.WriteLine("Olit rastilla " + ero + " sekuntia kärjestä.");
            }
            else
            {
                Console.WriteLine("Olet " + ero + " edellä toista.");
            }
            Console.ReadLine();
            Console.WriteLine("");

            #endregion

            #region Rastiväli 4
            Console.WriteLine("Neljäs rastiväli on n. 400m päässä mäen päällä. Rasti on kumpare pienien soiden välissä.");
            Console.WriteLine("Rastivälillä epämäräinen määrä pieniä kumpareita sekä kiviä.");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("4. Reitinvalinta: 1. kuljet suoraan yhdysviivaa pitkin, 2. kierrät etelästä ylimääräiset nousut");
            Console.WriteLine("Poikkeama: 1. 0m, 2. 35m | Letkat: 1. Vähäinen, 2. Runsas | Nousu: 1. 40m, 2. 25m");
            Console.ReadLine();
            Console.Write("Anna vastauksesi: ");
            string reitinvalinta4 = Console.ReadLine();

            while (true)
            {
                if (reitinvalinta4 == "1" || reitinvalinta4 == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kirjotitko varmasti \"1\" tai \"2\".");
                    reitinvalinta4 = Console.ReadLine();
                }
            }

            sattuma = random.Next(0, 100);
            sattuma2 = random.Next(0, 10);
            sattuma3 = random.Next(5, 15);
            sattuma4 = random.Next(10, 30);
            sattuma5 = random.Next(30, 60);

            if (reitinvalinta4 == "1")
            {
                Console.WriteLine("Kuljet välin lähes yksin, mutta rastilla huomaat muiden menneen omille hajoinnoilleen.");
                if (ero > 60)
                {
                    ero -= sattuma2;
                }
            }
            else if (reitinvalinta4 == "2")
            {
                Console.WriteLine("");

                Console.WriteLine("Huomaat olevasi jo vähän väsynyt ja samaan aikaan rankin johtaja tulee takaasi vetäen isoa letkaa.");
                Console.ReadLine();
                Console.WriteLine("Peesaatko letkaa seuraavalle rastille ? Kyllä = \"1\" En = \"2\" ");
                peesaus = Console.ReadLine();
                while (true)
                {
                    if (peesaus == "1" || peesaus == "2")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kirjotitko varmasti \"1\" tai \"2\".");
                        peesaus = Console.ReadLine();
                    }
                }
                if (peesaus == "1")
                {
                    if (sattuma > 20)
                    {
                        Console.WriteLine("Saavut rastille, mutta huomaat, että koodi ei täsmää...");
                        Console.ReadLine();
                        Console.WriteLine("Huomaat olevasi liian etelässä ja suuntaat takaisin päin kohti omaa rastia.");
                        Console.ReadLine();
                        ero += sattuma5;
                    }
                    else
                    {
                        Console.WriteLine("Juokset letkan mukana, mutta et ole ollenkaan kartalla...");
                        Console.ReadLine();
                        Console.WriteLine("Saavut omalle rastillesi ja huomaat letkan kulkeneen hyvää vauhtia.");
                        Console.ReadLine();
                        ero -= sattuma2;
                    }
                }
                else
                {
                    Console.WriteLine("Saavut rastillesi, mutta huomaat, että suunnistus ei ollut tarpeaksi sujuvaa ja jäit nopeampiin.");
                    Console.ReadLine();
                    ero += sattuma3;
                }
                Console.WriteLine("");

                Console.WriteLine("Eroa kärkeen ei voida tietää hajonta rastilla."); 
                Console.WriteLine("");

            }
            #endregion

            #region Rastiväli 5
            Console.WriteLine("Viides rastiväli on n. 150m. Väli sisältää laskua sekä tietä.");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("Huomaat rastin olevan juoma- sekä onlinerasti");
            Console.ReadLine();
            Console.WriteLine("Otatko juoman? Kyllä = \"1\" tai En = \"2\"");
            string juoma = Console.ReadLine();
            while (true)
            {
                if (juoma == "1" || juoma == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kirjotitko varmasti \"1\" tai \"2\"?");
                    juoma = Console.ReadLine();
                }
            }
            sattuma = random.Next(0, 100);
            if (kengät == "2")
            {
                Console.WriteLine("Huomaat, että jaksat juosta tiepätkällä kovempaa kuin muut.");
                ero -= sattuma2;
            }
            if (juoma == "1")
            {
                Console.WriteLine("Juot virkistävää vettä.");
                ero += sattuma2;
            }

            Console.ReadLine();
            Console.WriteLine("");
            if (ero > 60)
            {
                sijoitus = 30;

                Console.WriteLine("Olet " + sijoitus + ". paikkeilla, kärkeen on vielä matkaa.");
            }
            else if (ero > 30)
            {
                sijoitus = 20;

                Console.WriteLine("Olet " + sijoitus + ". paikkeilla, kärkeen on vielä matkaa.");
            }
            else if (ero > 10)
            {
                sijoitus = 10;
                Console.WriteLine("Olet " + sijoitus + ". paikkeilla.");
            }
            else if (ero > 0)
            {
                sijoitus = 3;
                Console.WriteLine("Olet kärki letkassa sijalla" + sijoitus + ".");
            }
            else
            {
                sijoitus = 1;
                Console.WriteLine("Olet kärjessä");
            }
            if (ero > 0)
            {
                Console.WriteLine("Olit rastilla " + ero + " sekuntia kärjestä."); ;
            }
            else
            {
                Console.WriteLine("Olet " + ero + " edellä toista.");
            }
            Console.WriteLine("");

            Console.ReadKey();
            #endregion

            #region Rastiväli 6
            Console.WriteLine("Kuudes rastiväli on n. 800m pitkä. Rasti on rinteessä keskellä pitkää mäkeä.");
            Console.WriteLine("Rastiväli kulkee useiden mäkien läpi.");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("6. Reitinvalinta: 1. kuljet mäkien reunoja pitkin, 2. nouset mäkien päälle ja kuljet niitä pitkin, 3. kierrät mäet peltoja sekä polkuja pitkin");
            Console.WriteLine("Poikkeama: 1. 40m, 2. 15m, 3. 200m | Letkat: 1. kohtalainen, 2. kohtalainen, 3. vähäinen | Nousu: 1. 15m, 2. 40m, 3. 20");
            Console.ReadLine();
            Console.Write("Anna vastauksesi: ");
            string reitinvalinta6 = Console.ReadLine();

            while (true)
            {
                if (reitinvalinta6 == "1" || reitinvalinta6 == "2" || reitinvalinta6 == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kirjotitko varmasti \"1\", \"2\" tai \"3\".");
                    reitinvalinta6 = Console.ReadLine();
                }
            }

            sattuma = random.Next(0, 100);
            sattuma2 = random.Next(0, 10);
            sattuma3 = random.Next(5, 15);
            sattuma4 = random.Next(10, 30);
            sattuma5 = random.Next(30, 60);

            if (reitinvalinta6 == "1" && sattuma > 50)
            {
                Console.WriteLine("Suoritat rastivälin suunnitellusti.");
                ero -= sattuma2;
            }
            else if (reitinvalinta6 == "1" && sattuma > 5)
            {
                Console.WriteLine("Teet pienen koukun rastinotossa, mutta löydät rastin sen jälkeen.");
                ero += sattuma2;
            }
            else if (reitinvalinta6 == "1")
            {
                Console.WriteLine("Huomaat, että olet seurannut väärää mäkeä. Saavut kuitenkin rastille korjauksenjälkeen, mutta aikaa meni huomattavsati hukkaan.");
                ero += sattuma5;
            }
            else if (reitinvalinta6 == "2" && sattuma > 50 && kengät == "1")
            {
                Console.WriteLine("Kuljet rastivälin suunnitellusti ja huomaat, että olet kulkenut jotakuinkin kärjen vauhtia.");
                ero += sattuma3;
            }
            else if (reitinvalinta6 == "2" && sattuma > 5 && kengät == "1")
            {
                Console.WriteLine("Suoritat rastivälin suunnitellusti, mutta teet rastinotossa pienen virheen.");
                ero += sattuma3;
            }
            else if (reitinvalinta6 == "2" && kengät == "1")
            {
                Console.WriteLine("Teet samaistusvirheen ja ajaudut väärään mäkeen.");
                ero += sattuma5;
            }
            else if (reitinvalinta6 == "2" && kengät == "2" && sattuma > 40)
            {
                Console.WriteLine("Kompastut liukkailla kallioilla muutaman kerran, mutta mitään vakavampaa ei tapahdu.");
                ero += sattuma3;
            }
            else if (reitinvalinta6 == "2" && kengät == "2")
            {
                Console.WriteLine("Kaadut liukkaalla kalliolla ja satutat jalkaasi. Rastin löytäminen tuottaa täten ongelmia.");

                ero += sattuma5;

            }
            else if (reitinvalinta6 == "3" && sattuma > 50)
            {
                Console.WriteLine("Suoritat välin suunnitellusti ja huomaat, että etenit vähän nopeimpia hitaammin.");
                ero += sattuma2;
            }
            else if (reitinvalinta6 == "3")
            {
                Console.WriteLine("Sinulla on vaikeuksia löytää polkua, jolle olit menossa. Teet myös pienen rastinotto virheen.");
                ero += sattuma4;
            }
            else
            {
                Console.WriteLine("asdasdsa");
            }

            Console.WriteLine("Eroa kärkeen ei voida tietää hajonta rastilla.");
            Console.WriteLine("");
            Console.ReadKey();
            #endregion

            #region Rastiväli 7
            Console.WriteLine("Seitsemäs rastiväli on n. 400m pitkä. Rasti on rinteen vastakkaisella laidalla.");
            Console.WriteLine("Rinteen päällä on pieniä soita ja rinteen reunoilla on tiheikköjä sekä jyrkänteitä.");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("7. Reitinvalinta: 1. kuljet mäen päällä, 2. kuljet mäen reunaa pitkin, 3. laskeudut mäen alas ja kuljet mäen reunaa pitkin");
            Console.WriteLine("Poikkeama: 1. 10m, 2. 15m, 3. 40m | Letkat: 1. kohtalainen, 2. kohtalainen, 3. vähäinen | Nousu: 1. 15m, 2. 5m, 3. 20");
            Console.ReadLine();
            Console.Write("Anna vastauksesi: ");
            string reitinvalinta7 = Console.ReadLine();

            while (true)
            {
                if (reitinvalinta7 == "1" || reitinvalinta7 == "2" || reitinvalinta7 == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Kirjotitko varmasti \"1\", \"2\" tai \"3\".");
                    reitinvalinta7 = Console.ReadLine();
                }
            }
            Console.ReadKey();
            Console.WriteLine("");

            sattuma = random.Next(0, 100);
            sattuma2 = random.Next(0, 10);
            sattuma3 = random.Next(5, 15);
            sattuma4 = random.Next(10, 30);
            sattuma5 = random.Next(30, 60);

            if (reitinvalinta7 == "1" && sattuma > 50)
            {
                Console.WriteLine("Suoritat rastivälin odotetusti.");
                ero -= sattuma2;
            }
            else if (reitinvalinta7 == "1" && sattuma > 10)
            {
                Console.WriteLine("Suoritat rastivälin odotetusti kunnes teet rastinotossa pienen virheen.");
                ero += sattuma2;
            }
            else if (reitinvalinta7 == "1")
            {
                Console.WriteLine("Ajaudut rinteessä sivuun ja teet ison virheen.");
                ero += sattuma4;
            }
            else if (reitinvalinta7 == "2" && sattuma > 50)
            {
                Console.WriteLine("Suoritat rastivälin odotetusti.");
                ero -= sattuma2;
            }
            else if (reitinvalinta7 == "2" && sattuma > 10)
            {
                Console.WriteLine("Suoritat rastivälin odotetusti kunnes teet rastinotossa pienen virheen.");
                ero += sattuma2;
            }
            else if (reitinvalinta7 == "2")
            {
                Console.WriteLine("Laskeudut liian alas rinteessä, täten häviät runsaasti aikaa.");
                ero += sattuma5;
            }
            else if (reitinvalinta7 == "3" && sattuma > 50)
            {
                Console.WriteLine("Suoritat rastivälin odotetusti, mutta huomaat jääneesi nopeimmille.");
                ero += sattuma3;
            }
            else if (reitinvalinta7 == "3")
            {
                Console.WriteLine("Suoritat rastivälin odotetusti, mutta huomaat jääneesi nopeimmille.");
                Console.WriteLine("LIsäksi menetät aikaa, kun teet virheen rastinotossa.");
                ero += sattuma5;
            }
            else
            {
                Console.WriteLine("Virheee");
            }
            Console.WriteLine("");
            Console.ReadKey();

            if (ero < 0)
            {
                Console.WriteLine("Olet kärjessä {0} sekuntia.", ero);
            }
            else
            {
                Console.WriteLine("Olet kärjestä {0} sekuntia.", ero);
            }
            Console.ReadKey();
            Console.WriteLine("");
            #endregion

            Console.WriteLine("Kahdeksas rastiväli on n. 1100m pitkä. Kumpare suon laidalla.");
            Console.WriteLine("Rastiväli kulkee useidenj soiden sekä pienien mäkien kautta.");
            Console.ReadKey();
            Console.WriteLine("");

            Console.WriteLine("7. Reitinvalinta: 1. kuljet mäen päällä, 2. kuljet mäen reunaa pitkin, 3. laskeudut mäen alas ja kuljet mäen reunaa pitkin");
            Console.WriteLine("Poikkeama: 1. 10m, 2. 15m, 3. 40m | Letkat: 1. kohtalainen, 2. kohtalainen, 3. vähäinen | Nousu: 1. 15m, 2. 5m, 3. 20");
            Console.ReadLine();
            Console.Write("Anna vastauksesi: ");
            string reitinvalinta8 = Console.ReadLine();
        }
    }
}
