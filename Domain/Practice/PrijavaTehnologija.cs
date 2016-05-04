using System;

namespace LearnByPractice.Domain.Practice
{
    /// <summary>Класа за поврзување на пријавата и технологијата.</summary>
    public class PrijavaTehnologija
    {
        /// <summary>Објект од класа пријава </summary>
        public Prijava prijava = new Prijava();

        /// <summary>Објект од класа технологија </summary>
        public Tehnologija tehnologija = new Tehnologija();

        /// <summary> Конструктор на класата <c>PrijavaTehnologija</c>, без параметри. </summary>
        public PrijavaTehnologija() { }
    }
}
