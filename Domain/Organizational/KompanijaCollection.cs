using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Organizational
{
    /// <summary> Класа за колекција на објекти од класата <c>Kompanija</c>.</summary>
    public class KompanijaCollection : Collection<Kompanija>
    {
        /// <summary>Конструктор на класата <c>KompanijaCollection</c>, без параметри.</summary>
        public KompanijaCollection():base() { }

        /// <summary> Конструктор на класата <c>KompanijaCollection</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>Kompanija</c>.</param>
        public KompanijaCollection(IList<Kompanija> list):base(list) { }
    }
}
