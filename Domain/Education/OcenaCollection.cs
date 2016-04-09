using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Education
{
    public class OcenaCollection : Collection<Ocena>
    {
        public OcenaCollection() { }
        public OcenaCollection(IList <Ocena> list) { }
    }
}
