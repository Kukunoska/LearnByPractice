using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.Domain.Practice
{
    class PrijavaStudent
    {
        public PrijavaStudent()
        { }
        public PrijavaStudent(int idStudent, int idPrijava)
        {
            IdPrijava = idPrijava;
            IdStudent = idStudent;

        }
        public int IdStudent
        { get; set; }
        public int IdPrijava
        { get; set; }
    }
}
