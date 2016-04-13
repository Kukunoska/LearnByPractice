using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Practice
{
    /// <summary> Класа за колекција на објекти од класата <c>Tehnologija</c>.</summary>
    public class TehnologijaCollection : Collection<Tehnologija>
    {
        /// <summary>Конструктор на класата <c>TehnologijaCollection</c>, без параметри.</summary>
        public TehnologijaCollection() : base() { }

        /// <summary> Конструктор на класата <c>TehnologijaCollection</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>Tehnologija</c>.</param>
        public TehnologijaCollection(IList<Tehnologija> list) : base(list) { }
    }
}
