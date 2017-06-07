using System;
using System.Security.Cryptography;

using NUnit.Framework;

using LearnByPractice.BLL.Managers.Security;

namespace LearnByPractice.Tests.BLL.Managers.Security
{
    [TestFixture]
    public class HashingTest
    {
        [Test]
        public void TestZaSporedbaNaLozinki()
        {
            byte[] saltBytes = new byte[Hashing.SaltLength];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetNonZeroBytes(saltBytes);
            }

            string lozinka = "L0z1Nk4";
            byte[] hash = Hashing.ComputeHash(lozinka, saltBytes);
            Console.WriteLine("Хаширана лозинка: {0}", BitConverter.ToString(hash).Replace("-", ""));
            Assert.IsTrue(Hashing.HashesEqual(lozinka, hash));
            Assert.IsFalse(Hashing.HashesEqual("lozinka", hash));
        }

        [Test]
        public void GenereirajLozinkiZaTestKorisnici()
        {
            byte[] saltBytes = new byte[Hashing.SaltLength];
            string[] korisnici = new string[]
            {
                "jasmina",
                "marija",
                "simona",
                "evgenija",
                "frosina",
                "sara",
                "zoran",
                "goce",
                "admin",
                "mentor",
                "student"
            };

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                foreach(string korisnik in korisnici)
                {
                    // Нова сол за секој корисник
                    rng.GetNonZeroBytes(saltBytes);
                    string lozinka = korisnik; // Лозинката е иста со корисничкото име
                    byte[] hash = Hashing.ComputeHash(lozinka, saltBytes);
                    Console.WriteLine("{0} => {1}", korisnik, BitConverter.ToString(hash).Replace("-", ""));
                }
            }
        }
    }
}
