using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Practice
{
    /// <summary> Класа за колекција на објекти од класата <c>PrijavaStudent</c>.</summary>
    public class PrijavaStudentCollection : Collection<PrijavaStudent>
    {
        /// <summary>Конструктор на класата <c>PrijavaStudentCollection</c>, без параметри.</summary>
        public PrijavaStudentCollection() : base() { }

        /// <summary> Конструктор на класата <c>PrijavaStudent</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>PrijavaStudent</c>.</param>
        public PrijavaStudentCollection(IList<PrijavaStudent> list) : base(list) { }
    }
}
