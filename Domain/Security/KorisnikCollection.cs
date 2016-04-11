using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Security
{
    /// <summary> Класа за колекција на објекти од класата <c>Korisnik</c>.</summary>
    public class KorisnikCollection : Collection<Korisnik>
    {
        /// <summary>Конструктор на класата <c>KorisnikCollection</c>, без параметри.</summary>
        public KorisnikCollection() : base() { }

        /// <summary> Конструктор на класата <c>KorisnikCollection</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>Korisnik</c>.</param>
        public KorisnikCollection(IList<Korisnik> list) : base(list) { }
    }
}
