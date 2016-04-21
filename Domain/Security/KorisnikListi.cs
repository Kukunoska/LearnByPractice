using System;
using System.Collections.Generic;

namespace LearnByPractice.Domain.Security
{
    class KorisnikListi
    {
        public static void main(String[] args)
        {
            List<string> iminjaZenski = new List<string>();
            iminjaZenski.Add("Lence");
            iminjaZenski.Add("Simona");
            iminjaZenski.Add("Antoniela");
            iminjaZenski.Add("Andrea");
            iminjaZenski.Add("Martina");
            iminjaZenski.Add("Viktorija");
            iminjaZenski.Add("Tamara");
            iminjaZenski.Add("Marija");
            iminjaZenski.Add("Kristina");
            iminjaZenski.Add("Jasmina");
            iminjaZenski.Add("Elena");
            iminjaZenski.Add("Karolina");
            iminjaZenski.Add("Anastasija");
            iminjaZenski.Add("Natalija");
            iminjaZenski.Add("Irena");
            iminjaZenski.Add("Emilija");
            iminjaZenski.Add("Sofija");
            iminjaZenski.Add("Jana");
            iminjaZenski.Add("Daniela");
            iminjaZenski.Add("Elizabeta");
            iminjaZenski.Add("Matea");

            List<string> preziminjaZenski = new List<string>();
            preziminjaZenski.Add("Tanaskoska");
            preziminjaZenski.Add("Simoska");
            preziminjaZenski.Add("Gjogjievska");
            preziminjaZenski.Add("Stamenkovska");
            preziminjaZenski.Add("Roshkovska");
            preziminjaZenski.Add("Kukunoska");
            preziminjaZenski.Add("Kuzmanovska");
            preziminjaZenski.Add("Soluncevska");
            preziminjaZenski.Add("Ivanova");
            preziminjaZenski.Add("Andonovska");
            preziminjaZenski.Add("Gerovska");
            preziminjaZenski.Add("Petrova");
            preziminjaZenski.Add("Angelkovska");
            preziminjaZenski.Add("Petkoska");
            preziminjaZenski.Add("Nikoloska");
            preziminjaZenski.Add("Milevska");
            preziminjaZenski.Add("Mickoska");
            preziminjaZenski.Add("Cvetanovska");
            preziminjaZenski.Add("Vasilevska");
            preziminjaZenski.Add("Ilievska");
            preziminjaZenski.Add("Radeska");

            List<string> iminjaMashki = new List<string>();
            iminjaMashki.Add("Damjan");
            iminjaMashki.Add("Nikola");
            iminjaMashki.Add("Petar");
            iminjaMashki.Add("Stefan");
            iminjaMashki.Add("Antonio");
            iminjaMashki.Add("Aleksandar");
            iminjaMashki.Add("Dimitar");
            iminjaMashki.Add("Igor");
            iminjaMashki.Add("Darko");
            iminjaMashki.Add("Filip");
            iminjaMashki.Add("Boban");
            iminjaMashki.Add("Goran");
            iminjaMashki.Add("Zoran");
            iminjaMashki.Add("Matej");
            iminjaMashki.Add("Kristijan");
            iminjaMashki.Add("Ognen");
            iminjaMashki.Add("Zarko");
            iminjaMashki.Add("Mihajlo");
            iminjaMashki.Add("Mende");
            iminjaMashki.Add("Pece");
            iminjaMashki.Add("Ilija");

            List<string> preziminjaMashki = new List<string>();
            preziminjaMashki.Add("Tanaskoski");
            preziminjaMashki.Add("Simoski");
            preziminjaMashki.Add("Naumoski");
            preziminjaMashki.Add("Gjorgjievski");
            preziminjaMashki.Add("Efremov");
            preziminjaMashki.Add("Naumovski");
            preziminjaMashki.Add("Veljanovski");
            preziminjaMashki.Add("Kosteski");
            preziminjaMashki.Add("Avramoski");
            preziminjaMashki.Add("Kocoski");
            preziminjaMashki.Add("Petreski");
            preziminjaMashki.Add("Mitevski");
            preziminjaMashki.Add("Milevski");
            preziminjaMashki.Add("Mickoski");
            preziminjaMashki.Add("Todoroski");
            preziminjaMashki.Add("Pavlevski");
            preziminjaMashki.Add("Nastevski");
            preziminjaMashki.Add("Krsteski");
            preziminjaMashki.Add("Simonovski");
            preziminjaMashki.Add("Andonovski");
            preziminjaMashki.Add("Panovski");

            List<Korisnik> lista = new List<Korisnik>();
            for (int i = 0; i < 441; i++)
            {
                Korisnik kz = new Korisnik();
                Korisnik km = new Korisnik();
                Random a = new Random();
                Random b = new Random();
                int ime = a.Next(0, 21);
                int prezime = b.Next(0, 21);
                kz.Ime = iminjaZenski[ime];
                kz.Prezime = preziminjaZenski[prezime];
                km.Ime = iminjaMashki[ime];
                km.Prezime = preziminjaMashki[prezime];
                lista.Add(kz);
                lista.Add(km);
            }
        }
    }
}
