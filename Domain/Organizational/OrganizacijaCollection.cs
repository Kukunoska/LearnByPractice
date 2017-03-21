using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Organizational
{
    /// <summary> Класа за колекција на објекти од класата <c>Organizacija</c>.</summary>
    public class OrganizacijaCollection : Collection<Organizacija>
    {
        /// <summary>Конструктор на класата <c>OrganizacijaCollection</c>, без параметри.</summary>
        public OrganizacijaCollection():base() { }

        /// <summary> Конструктор на класата <c>OrganizacijaCollection</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>Organizacija</c>.</param>
        public OrganizacijaCollection(IList<Organizacija> list):base(list) { }
    }
}
