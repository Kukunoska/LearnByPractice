using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Education
{
    /// <summary> Класа за колекција на објекти од класата <c>Ocena</c></summary>
    public class OcenaCollection : Collection<Ocena>
    {
        /// <summary>Конструктор на класата <c>OcenaCollection</c>, без параметри.</summary>
        public OcenaCollection() : base() { }

        /// <summary> Конструктор на класата <c>OcenaCollection</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>Ocena</c></param>
        public OcenaCollection(IList<Ocena> list) : base(list) { }
    }
}
