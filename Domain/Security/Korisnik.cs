using System;

namespace LearnByPractice.Domain.Security
{
    /// <summary>Пол на корисникот</summary>
    public enum Pol { 
        /// <summary>машки род</summary>
        Mashki, 
        /// <summary>женски род</summary>
        Zhenski };

/// <summary>Класа за корисник. </summary>
    public class Korisnik
    {
        /// <summary>Шифра</summary>
        /// <value>Ја зема/поставува шифрата на корисникот</value>
        public int IdKorisnik { get; set; }

        /// <summary>Корисничко име</summary>
        /// <value>Го зема/поставува корисничкото име на корисникот</value>
        public String Username { get; set; }

        /// <summary>Лозинка</summary>
        /// <value>Ја зема/поставува лозинката на корисникот</value>
        public String Password { get; set; }

        /// <summary>Име</summary>
        /// <value>Го зема/поставува името на корисникот</value>
        public String Ime { get; set; }

        /// <summary>Презиме</summary>
        /// <value>Го зема/поставува презиме на корисникот</value>
        public String Prezime { get; set; }

        /// <summary>Студиска програма</summary>
        /// <value>Ја зема/поставува студиската програма на корисникот</value>
        public String StudiskaPrograma { get; set; }

        /// <summary>Електронска пошта</summary>
        /// <value>Ја зема/поставува електронската пошта на корисникот</value>
        public String Email { get; set; }

        /// <summary>Телефонски број</summary>
        /// <value>Го зема/поставува телефонскиот број на корисникот</value>
        public String Mobilen { get; set; }

        /// <summary> Конструктор на класата <c>Korisnik</c>, без параметри. </summary>
        public Korisnik() { }
    }
}
