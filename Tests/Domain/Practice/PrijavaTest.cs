using NUnit.Framework;
using LearnByPractice.Domain.Practice;
using System;

namespace LearnByPractice.Tests.Domain.Practice
{
    /// <summary>Тестови за класата <c>Prijava</c></summary>
    [TestFixture]
    public class PrijavaTest
    {
        [Test]
        public void PrijavaConstructorTest()
        {
            Prijava p = new Prijava();
            Assert.AreEqual(0, p.Id);
            Assert.AreEqual(0,p.IdKompanija);
            Assert.AreEqual(DateTime.Today, p.Datum);
        }
    }
}
