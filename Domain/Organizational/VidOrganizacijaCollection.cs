using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Organizational
{
    /// <summary> Класа за колекција на објекти од класата <c>VidOrganizacija</c>.</summary>
    public class VidOrganizacijaCollection : Collection<VidOrganizacija>
    {
        /// <summary>Конструктор на класата <c>VidOrganizacijaCollection</c>, без параметри.</summary>
        public VidOrganizacijaCollection() : base() { }

        /// <summary> Конструктор на класата <c>VidOrganizacijaCollection</c>, со параметри.</summary>
        /// <param name="list">Листа со објекти од класа <c>VidOrganizacija</c>.</param>
        public VidOrganizacijaCollection(IList<VidOrganizacija> list) : base(list) { }
    }
}
