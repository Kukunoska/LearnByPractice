using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Education
{
    public class PredmetCollection : Collection<Predmet>
    {
        public PredmetCollection() { }
        public PredmetCollection(IList <Predmet> list) { }
    }
}
