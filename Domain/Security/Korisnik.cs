using LearnByPractice.Domain.Education;
using LearnByPractice.Domain.Organizational;
using System;

namespace LearnByPractice.Domain.Security
{
    /// <summary>Пол на корисникот</summary>
    public enum PolEnum {
        /// <summary>дифолт вредност</summary>
        Nepoznat,
        /// <summary>машки род</summary>
        Mashki, 
        /// <summary>женски род</summary>
        Zhenski };

    /// <summary>Класа за корисник. </summary>
    public class Korisnik
    {
        /// <summary>Шифра</summary>
        /// <value>Ја зема/поставува шифрата на корисникот</value>
        public int Id { get; set; }

        /// <summary>Корисничко име</summary>
        /// <value>Го зема/поставува корисничкото име на корисникот</value>
        public String Username { get; set; }

        /// <summary>Лозинка</summary>
        /// <value>Ја зема/поставува лозинката на корисникот</value>
        public String Password { get; set; }

        /// <summary>ЛозинкаОдБаза</summary>
        /// <value>Ја зема/поставува лозинката на корисникот од база</value>
        public byte[] PasswordOdNiza { get; set; }

        /// <summary>Име</summary>
        /// <value>Го зема/поставува името на корисникот</value>
        public String Ime { get; set; }

        /// <summary>Презиме</summary>
        /// <value>Го зема/поставува презиме на корисникот</value>
        public String Prezime { get; set; }

        /// <summary>Пол</summary>
        /// <value>Ја зема/поставува вредноста на пол за корисникот</value>
        public PolEnum Pol { get; set;}

        /// <summary>Објект од класа <c>StudiskaPrograma</c></summary>
        public StudiskaPrograma studiskaPrograma = new StudiskaPrograma();
        
        /// <summary>Објект од класа <c>Kompanija</c></summary>
        public Kompanija organizacija = new Kompanija();

        /// <summary>Електронска пошта</summary>
        /// <value>Ја зема/поставува електронската пошта на корисникот</value>
        public String Email { get; set; }

        /// <summary>Телефонски број</summary>
        /// <value>Го зема/поставува телефонскиот број на корисникот</value>
        public String Mobilen { get; set; }

        /// <summary>Корисник Администратор</summary>
        /// <value>Ја зема/поставува вистинитоста на исказот "Корисникот е Администратор" </value>
        public Boolean Administrator { get; set; }

        /// <summary>Корисник Ментор</summary>
        /// <value>Ја зема/поставува вистинитоста на исказот "Корисникот е Ментор" </value>
        public Boolean Mentor { get; set; }

        /// <summary>Корисник Студент</summary>
        /// <value>Ја зема/поставува вистинитоста на исказот "Корисникот е Студент" </value>
        public Boolean Student { get; set; }

        /// <summary> Конструктор на класата <c>Korisnik</c>, без параметри. </summary>
        public Korisnik() 
        {
            Pol = PolEnum.Nepoznat;
        }
    }
}
