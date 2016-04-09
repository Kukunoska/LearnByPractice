using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Security
{
    public class KorisnikCollection : Collection<Korisnik>
    {
        public KorisnikCollection() { }
        public KorisnikCollection(IList<Korisnik> list) { }
    }
}
