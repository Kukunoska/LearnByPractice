using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.Domain.Education
{
    class Predmet
    {
        public int Id { get; set; }
        public String Ime { get; set; }
        public Predmet(int idP,String imeP)
        {
            Id = idP;
            Ime = imeP;
        }
        public Predmet() { }
    }
}
