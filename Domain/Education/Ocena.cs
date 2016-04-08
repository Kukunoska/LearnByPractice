using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnByPractice.Domain.Education
{
    class Ocena
    {
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public int Ocena { get; set; }
        public Ocena(int studentID,int predmetID,int ocenaP)
        {
            StudentId = studentID;
            PredmetId = predmetID;
            Ocena = ocenaP;
        }
        public Ocena()
        { }
    }
}
