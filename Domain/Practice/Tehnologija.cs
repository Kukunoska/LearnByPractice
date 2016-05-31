using System;

namespace LearnByPractice.Domain.Practice
{
    /// <summary>Класа за технологија.</summary>
    public class Tehnologija
    {
        /// <summary>Шифра.</summary>
        /// <value>Ја зема/поставува шифрата на технологијата.</value>
        public int Id { get; set; }

        /// <summary>Име.</summary>
        /// <value>Го зема/поставува името на технологијата.</value>
        public String Ime { get; set; }

        /// <summary>Објект од класата <c>Oblast</c></summary>
        public Oblast oblast { get { return _oblast; } }

        private Oblast _oblast = new Oblast();

        /// <summary> Област</summary>
        public String oblastIme { get { return _oblast.Ime; } }

        /// <summary> Конструктор на класата <c>Tehnologija</c>, без параметри.</summary>
        public Tehnologija() { }
    }
}
