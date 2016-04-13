using System;

namespace LearnByPractice.Domain.Organizational
{
    /// <summary>Класа за компанијата.</summary>
    public class Kompanija
    {
        /// <summary>Шифра </summary>
        /// <value>Ја зема/поставува шифрата на компанијата</value>
        public int Id { get; set; }

        /// <summary>Име </summary>
        /// <value>Го зема/поставува името на компанијата</value>
        public String Ime { get; set; }

        /// <summary> Конструктор на класата <c>Kompanija</c>, без параметри. </summary>
        public Kompanija() { }
    }
}
