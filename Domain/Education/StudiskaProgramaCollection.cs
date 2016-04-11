using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Education
{
    /// <summary> Класа за колекција на објекти од класата <c>StudiskaPrograma</c></summary>
    public class StudiskaProgramaCollection : Collection<StudiskaPrograma>
    {
        /// <summary>Конструктор на класата <c>StudiskaProgramaCollection</c>, без параметри.</summary>
        public StudiskaProgramaCollection() : base() { }

        /// <summary> Конструктор на класата <c>StudiskaProgramaCollection</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>StudiskaPrograma</c></param>
        public StudiskaProgramaCollection(IList<StudiskaPrograma> list) : base(list) { }
    }
}
