using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.Domain.Practice
{
    class Prijavi
    {
        public Prijavi()
        { }
        public Prijavi(int idPrijava, int idKompanija)
        {
            IdPrijava = idPrijava;
            IdKompanija = idKompanija;
        }
        public int IdPrijava
        { get; set; }
        public int IdKompanija
        { get; set; }
    }
}
