using System;

namespace LearnByPractice.Domain.Practice
{
    /// <summary>Класа за поврзување на пријавата и технологијата.</summary>
    public class PrijavaTehnologija
    {
        /// <summary>Шифра на пријавата </summary>
        /// <value>Ја зема/поставува шифрата на пријавата</value>
        public int IdPrijava { get; set; }

        /// <summary>Шифра на технологијата </summary>
        /// <value>Ја зема/поставува шифрата на технологијата</value>
        public int IdTehnologija { get; set; }

        /// <summary> Конструктор на класата <c>PrijavaTehnologija</c>, без параметри. </summary>
        public PrijavaTehnologija() { }
    }
}
