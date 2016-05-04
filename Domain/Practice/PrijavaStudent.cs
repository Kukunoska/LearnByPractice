using System;
using LearnByPractice.Domain.Security;

namespace LearnByPractice.Domain.Practice
{
    /// <summary>Класа за поврзување на студентот и пријавата.</summary>
    public class PrijavaStudent
    {
        /// <summary>Објект од класа корисник </summary>
        public Korisnik student = new Korisnik();

        /// <summary>Објект од класа пријава </summary>
        public Prijava prijava = new Prijava();

        /// <summary> Конструктор на класата <c>PrijavaStudent</c>, без параметри. </summary>
        public PrijavaStudent() { }
    }
}
