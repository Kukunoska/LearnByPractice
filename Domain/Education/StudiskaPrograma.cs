using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.Domain.Education
{
    class StudiskaPrograma
    {
        public StudiskaPrograma()
        {  }
        public StudiskaPrograma(int idSP, String imeSP)
        {
            Id = idSP;
            Ime = imeSP;
        }
        public int Id
        { get; set; }
        public String Ime
        { get; set; }
    }
}
