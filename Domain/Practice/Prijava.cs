using System;

namespace LearnByPractice.Domain.Practice
{
    /// <summary>Класа за пријава.</summary>
    public class Prijava
    {
        /// <summary>Шифра </summary>
        /// <value>Ја зема/поставува шифрата на пријавата</value>
        public int Id { get; set; }
        
        /// <summary>Шифра на комапнијата </summary>
        /// <value>Ја зема/поставува шифрата на компанијата</value>
        public int IdKompanija { get; set; }

        /// <summary> Конструктор на класата <c>Prijava</c>, без параметри. </summary>
        public Prijava() { }
    }
}
