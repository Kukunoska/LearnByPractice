using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Practice
{
    public class PrijavaTehnologiiCollections : Collection<PrijavaTehnologii>
    {
        public PrijavaTehnologiiCollections() { }
        public PrijavaTehnologiiCollections(IList<PrijavaTehnologii> list) { }
    }
}
