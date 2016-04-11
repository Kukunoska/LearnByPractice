using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Education
{
    /// <summary> Класа за колекција на објекти од класата <c>Predmet</c>.</summary>
    public class PredmetCollection : Collection<Predmet>
    {
        /// <summary>Конструктор на класата <c>PredmetCollection</c>, без параметри.</summary>
        public PredmetCollection() : base() { }

        /// <summary> Конструктор на класата <c>PredmetCollection</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>Predmet</c>.</param>
        public PredmetCollection(IList<Predmet> list) : base(list) { }
    }
}
