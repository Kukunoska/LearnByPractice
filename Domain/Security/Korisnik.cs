using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.Domain.Security
{
    public enum Pol { Mashki, Zhenski};
    class Korisnik
    {
        public Korisnik()
        { }
        public Korisnik(int idKorisnik, String username, String pass, String ime, String prezime, String studiskaP, String email, String mobilen)
        {
            IdKorisnik = idKorisnik;
            Username = username;
            Password = pass;
            Ime = ime;
            Prezime = prezime;
            StudiskaPrograma = studiskaP;
            Email = email;
            Mobilen = mobilen;
        }
        public int IdKorisnik
        { get; set; }
        public String Username
        { get; set; }
        public String Password
        { get; set; }
        public String Ime
        { get; set; }
        public String Prezime
        { get; set; }
        public String StudiskaPrograma
        { get; set; }
        public String Email
        { get; set; }
        public String Mobilen
        { get; set; }
        

    }
}
