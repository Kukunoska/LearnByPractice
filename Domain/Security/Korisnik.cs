using System;

namespace LearnByPractice.Domain.Security
{
    public enum Pol { Mashki, Zhenski };
    public class Korisnik
    {
        public int IdKorisnik { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String StudiskaPrograma { get; set; }
        public String Email { get; set; }
        public String Mobilen { get; set; }

        public Korisnik() { }
    }
}
