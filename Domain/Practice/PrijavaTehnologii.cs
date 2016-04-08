using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.Domain.Practice
{
    class PrijavaTehnologii
    {
        public PrijavaTehnologii()
        { }
        public PrijavaTehnologii(int idPrijava, int idTehnologii)
        {
            IdPrijava = idPrijava;
            IdTehnologii = idTehnologii;
        }
        public int IdPrijava
        { get; set; }
        public int IdTehnologii
        { get; set; }
    }
}
