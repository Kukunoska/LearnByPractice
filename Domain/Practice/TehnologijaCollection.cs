using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Practice
{
    public class TehnologijaCollection : Collection<Tehnologija>
    {
        public TehnologijaCollection() { }
        public TehnologijaCollection(IList<Tehnologija> list) { }
    }
}
