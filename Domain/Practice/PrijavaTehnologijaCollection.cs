using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Practice
{
    /// <summary> Класа за колекција на објекти од класата <c>PrijavaTehnologija</c>.</summary>
    public class PrijavaTehnologijaCollection : Collection<PrijavaTehnologija>
    {
        /// <summary>Конструктор на класата <c>PrijavaTehnologijaCollection</c>, без параметри.</summary>
        public PrijavaTehnologijaCollection() : base() { }

        /// <summary> Конструктор на класата <c>PrijavaTehnologija</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>PrijavaTehnologija</c>.</param>
        public PrijavaTehnologijaCollection(IList<PrijavaTehnologija> list) : base(list) { }
    }
}
