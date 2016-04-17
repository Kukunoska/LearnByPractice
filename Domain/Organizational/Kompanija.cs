using System;

namespace LearnByPractice.Domain.Organizational
{
    /// <summary>Класа за компанијата.</summary>
    public class Kompanija
    {
        /// <summary>Шифра </summary>
        /// <value>Ја зема/поставува шифрата на компанијата</value>
        public int Id { get; set; }

        /// <summary>Име </summary>
        /// <value>Го зема/поставува името на компанијата</value>
        public String Ime { get; set; }

        /// <summary>Адреса</summary>
        /// <value>Ја зема/поставува адресата на компанијата</value>
        public String Adresa { get; set; }

        /// <summary>Контакт телефон</summary>
        /// <value>Го зема/поставува контакт телефонот на компанијата</value>
        public String KontaktTelefon { get; set; }

        /// <summary>Веб страна</summary>
        /// <value>Го зема/поставува линкот на веб страната на компанијата</value>
        public String VebStrana { get; set; }

        /// <summary>Објект од класата <c>VidOrganizacija</c></summary>
        public VidOrganizacija vidOrganizacija = new VidOrganizacija();

        /// <summary> Конструктор на класата <c>Kompanija</c>, без параметри. </summary>
        public Kompanija() { }
    }
}
