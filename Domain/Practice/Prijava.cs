using System;

namespace LearnByPractice.Domain.Practice
{
    /// <summary>Класа за пријава.</summary>
    public class Prijava
    {
        private DateTime datum;
        /// <summary>Шифра </summary>
        /// <value>Ја зема/поставува шифрата на пријавата</value>
        public int Id { get; set; }
        
        /// <summary>Шифра на комапнијата </summary>
        /// <value>Ја зема/поставува шифрата на компанијата</value>
        public int IdKompanija { get; set; }

        /// <summary>Датум на пријавата</summary>
        /// <value>Го зема/поставува датумот на пријавата</value>
        public String Datum
        {
            set { DateTime.TryParse(value, out datum); }
            get { return datum.Date.ToString(); }
        }

        /// <summary> Конструктор на класата <c>Prijava</c>, без параметри. </summary>
        public Prijava() { }
    }
}
