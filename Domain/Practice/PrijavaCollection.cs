using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Practice
{
    public class PrijavaCollection : Collection<Prijava>
    {
        public PrijavaCollection() { }
        public PrijavaCollection(IList<Prijava> list) { }
    }
}
