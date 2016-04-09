using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Practice
{
    public class OblastCollection : Collection<Oblast>
    {
        public OblastCollection() { }
        public OblastCollection(IList<Oblast> list) { }
    }
}
