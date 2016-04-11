using System;

namespace LearnByPractice.Domain.Education
{
    /// <summary>Класа за студиска програма.</summary>
    public class StudiskaPrograma
    {
        /// <summary>Шифра </summary>
        /// <value>Ја зема/поставува шифрата на студиската програма</value>
        public int Id { get; set; }

        /// <summary>Име</summary>
        /// <value>Го зема/поставува името на студиската програма</value>
        public String Ime { get; set; }

        /// <summary> Конструктор на класата <c>StudiskaPrograma</c>, без параметри. </summary>
        public StudiskaPrograma() { }
    }
}
