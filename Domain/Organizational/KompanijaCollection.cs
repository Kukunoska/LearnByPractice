using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Organizational
{
    public class KompanijaCollection : Collection<Kompanija>
    {
        public KompanijaCollection() { }
        public KompanijaCollection(IList<Kompanija> list) { }
    }
}
