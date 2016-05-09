using System;
using LearnByPractice.Domain.Security;

namespace LearnByPractice.Domain.Education
{
    /// <summary>Класа за оцената на студент по одреден предмет.</summary>
    public class Ocena
    {
        /// <summary> Објект од класа <c>Korisnik</c>.</summary>
        public Korisnik student = new Korisnik();

        /// <summary> Објект од класа <c>Predmet</c>.</summary>
        public Predmet predmet = new Predmet();

        /// <summary>Оцена на студентот со шифра <c>StudentID</c>, по предметот со шифра <c>PredmetID</c>.</summary>
        /// <value>Ја зема/поставува вредноста на оцената. </value>
        public int Ocenka { get; set; }

        /// <summary> Конструктор на класата <c>Ocena</c>, без параметри. </summary>
        public Ocena() { }
    }
}
