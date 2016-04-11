using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Practice
{
    /// <summary> Класа за колекција на објекти од класата <c>Oblast</c>.</summary>
    public class OblastCollection : Collection<Oblast>
    {
        /// <summary>Конструктор на класата <c>OblastCollection</c>, без параметри.</summary>
        public OblastCollection():base() { }

        /// <summary> Конструктор на класата <c>OblastCollection</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>Oblast</c>.</param>
        public OblastCollection(IList<Oblast> list):base(list) { }
    }
}
