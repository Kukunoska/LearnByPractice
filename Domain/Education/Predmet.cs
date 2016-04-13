using System;

namespace LearnByPractice.Domain.Education
{
    /// <summary>Класа за предмет кој го слуша студентот</summary>
    public class Predmet
    {
        /// <summary>Шифра </summary>
        /// <value>Ја зема/поставува шифрата на предметот</value>
        public int Id { get; set; }

        /// <summary>Име</summary>
        /// <value>Го зема/поставува името на предметот</value>
        public String Ime { get; set; }

        /// <summary> Конструктор на класата <c>Predmet</c>, без параметри. </summary>
        public Predmet() { }
    }
}
