using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.Domain.Practice
{
    class Oblast
    {
        public int Id { get; set; }
        public String Ime { get; set; }
        public Oblast(int iD, String imeO)
        {
            Id = iD;
            Ime = imeO;
        }
        public Oblast() 
        {  }
    }
}
