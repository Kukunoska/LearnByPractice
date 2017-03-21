using System;

namespace LearnByPractice.Domain.Organizational
{
    /// <summary>Класа за организацијата.</summary>
    public class Organizacija
    {
        /// <summary>Шифра </summary>
        /// <value>Ја зема/поставува шифрата на организацијата</value>
        public int Id { get; set; }

        /// <summary>Име </summary>
        /// <value>Го зема/поставува името на организацијата</value>
        public String Ime { get; set; }

        /// <summary>Адреса</summary>
        /// <value>Ја зема/поставува адресата на организацијата</value>
        public String Adresa { get; set; }

        /// <summary>Контакт телефон</summary>
        /// <value>Го зема/поставува контакт телефонот на организацијата</value>
        public String KontaktTelefon { get; set; }

        /// <summary>Веб страна</summary>
        /// <value>Го зема/поставува линкот на веб страната на организацијата</value>
        public String VebStrana { get; set; }

        /// <summary>Објект од класата <c>VidOrganizacija</c></summary>
        public VidOrganizacija vidOrganizacija { get { return _vidOrganizacija; } }

        private VidOrganizacija _vidOrganizacija = new VidOrganizacija();
        
        /// <summary> Конструктор на класата <c>Organizacija</c>, без параметри. </summary>
        public Organizacija() { }
    }
}
