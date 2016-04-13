using System;

namespace LearnByPractice.Domain.Organizational
{
    /// <summary>Класа за видот на организацијата</summary>
    public class VidOrganizacija
    {
        /// <summary>Шифра </summary>
        /// <value>Ја зема/поставува шифрата на видот на организацијата</value>
        public int Id { get; set; }

        /// <summary>Име</summary>
        /// <value>Го зема/поставува името на видот на организацијата</value>
        public int Ime { get; set; }

        /// <summary> Конструктор на класата <c>VidOrganizacija</c>, без параметри. </summary>
        public VidOrganizacija() { }
    }
}
