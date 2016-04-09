using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LearnByPractice.Domain.Education
{
    public class StudiskaProgramaCollection : Collection<StudiskaPrograma>
    {
        public StudiskaProgramaCollection() { }
        public StudiskaProgramaCollection(IList<StudiskaPrograma> list) { }
    }
}
