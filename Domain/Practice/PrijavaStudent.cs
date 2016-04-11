using System;

namespace LearnByPractice.Domain.Practice
{
    /// <summary>Класа за поврзување на студентот и пријавата.</summary>
    public class PrijavaStudent
    {
        /// <summary>Шифра на студентот </summary>
        /// <value>Ја зема/поставува шифрата на студентот</value>
        public int IdStudent { get; set; }

        /// <summary>Шифра на пријавата </summary>
        /// <value>Ја зема/поставува шифрата на пријавата</value>
        public int IdPrijava { get; set; }

        /// <summary> Конструктор на класата <c>PrijavaStudent</c>, без параметри. </summary>
        public PrijavaStudent() { }
    }
}
