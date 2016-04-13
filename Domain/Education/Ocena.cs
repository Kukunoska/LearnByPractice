using System;

namespace LearnByPractice.Domain.Education
{
    /// <summary>Класа за оцената на студент по одреден предмет.</summary>
    public class Ocena
    {
        /// <summary> Шифрата на студентот.</summary>
        /// <value>Ја зема/поставува вредноста на шифрата на студентот.</value>
        public int StudentId { get; set; }

        /// <summary> Шифрата на предметот.</summary>
        /// <value>Ја зема/поставува вредноста на шифрата на предметот.</value>
        public int PredmetId { get; set; }

        /// <summary>Оцена на студентот со шифра <c>StudentID</c>, по предметот со шифра <c>PredmetID</c>.</summary>
        /// <value>Ја зема/поставува вредноста на оцената. </value>
        public int Ocenka { get; set; }

        /// <summary> Конструктор на класата <c>Ocena</c>, без параметри. </summary>
        public Ocena() { }
    }
}
