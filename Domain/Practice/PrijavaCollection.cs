using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Practice
{
    /// <summary> Класа за колекција на објекти од класата <c>Prijava</c>.</summary>
    public class PrijavaCollection : Collection<Prijava>
    {
        /// <summary>Конструктор на класата <c>PrijavaCollection</c>, без параметри.</summary>
        public PrijavaCollection():base() { }

        /// <summary> Конструктор на класата <c>PrijavaCollection</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>Prijava</c>.</param>
        public PrijavaCollection(IList<Prijava> list):base(list) { }
    }
}
