using System;

namespace LearnByPractice.Domain.Education
{
    public class Ocena
    {
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public int Ocenka { get; set; }

        public Ocena() { }
    }
}
