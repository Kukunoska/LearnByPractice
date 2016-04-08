using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.Domain.Organizational
{
    public class Kompanija
    {
        public Kompanija()
        {

        }
        public Kompanija(int idKompanija, String ime)
        {
            IdKompanija = idKompanija;
            ImeKompanija = ime;
        }
        public int IdKompanija
        { get; set; }
        public String ImeKompanija
        { get; set; }

    }
}
