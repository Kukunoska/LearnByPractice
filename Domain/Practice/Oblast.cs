using System;
using System.Collections.Generic;

namespace LearnByPractice.Domain.Practice
{
    /// <summary>Класа за област.</summary>
    public class Oblast
    {
        private TehnologijaCollection tehnologii;

        /// <summary>Колекција од објекти од класата <c>Tehnologija</c></summary>
        /// <value>Ја зема  колекцијата од објекти</value>
        public TehnologijaCollection Tehnologii
        {
            get {return tehnologii;}
            private set { tehnologii=value;}
        }

        /// <summary>Шифра.</summary>
        /// <value>Ја зема/поставува шифрата на областа.</value>
        public int Id { get; set; }

        /// <summary>Име. </summary>
        /// <value>Го зема/поставува името на областа.</value>
        public String Ime { get; set; }

        /// <summary> Конструктор на класата <c>Oblast</c>, без параметри. </summary>
        public Oblast() { }

        /// <summary>Конструктор на класата <c>Oblast</c>, со параметри.</summary>
        /// <param name="t">објект од класата <c>TehnologijaCollection</c></param>
        public Oblast(TehnologijaCollection t)
        {
            Tehnologii = t;
        }
    }
}
