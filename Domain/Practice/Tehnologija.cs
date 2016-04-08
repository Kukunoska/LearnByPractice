using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.Domain.Practice
{
    class Tehnologija
    {
        public int Id { get; set; }
        public String Ime { get; set;}
        public String Oblast { get; set; }
        public Tehnologija(int idT,String imeT,String oblastT)
        {
            Id = idT;
            Ime = imeT;
            Oblast = oblastT;
        }
        public Tehnologija()
        { }

    }
}
