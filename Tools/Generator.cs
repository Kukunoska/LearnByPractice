using System;
using System.Windows.Forms;
using System.IO;
using LearnByPractice.Domain.Security;
using System.Collections.Generic;

namespace Tools
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();
        }
        public Generator(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }
        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            int vkupnoKorisnici = Convert.ToInt32(numVkupno.Value);
            int maskiKorisnici = Convert.ToInt32(numMashki.Value);
            int zenskiKorisnici = Convert.ToInt32(numZenski.Value);
            string path = Directory.GetCurrentDirectory();
            try
            {
                //Za Zhenski Iminja
                string[] zenski_iminja = File.ReadAllLines(path + "\\ZenskiIminja.txt");
                List<string> zenskiIminjaList = new List<string>();
                foreach (string s in zenski_iminja)
                {
                    zenskiIminjaList.Add(s);
                }

                //Za Zhenski Preziminja
                string[] zenski_preziminja = File.ReadAllLines(path + "\\ZenskiPreziminja.txt");
                List<string> zenskiPreziminjaList = new List<string>();
                foreach (string s in zenski_preziminja)
                {
                    zenskiPreziminjaList.Add(s);
                }

                //Za Mashki Iminja
                string[] mashki_iminja = File.ReadAllLines(path + "\\MashkiIminja.txt");
                List<string> mashkiIminjaList = new List<string>();
                foreach (string s in mashki_iminja)
                {
                    mashkiIminjaList.Add(s);
                }

                //Za Mashki Preziminja
                string[] mashki_preziminja = File.ReadAllLines(path + "\\MashkiPreziminja.txt");
                List<string> mashkiPreziminjaList = new List<string>();
                foreach (string s in mashki_preziminja)
                {
                    mashkiPreziminjaList.Add(s);
                }


                Random random = new Random();
                List<Korisnik> korisnici = new List<Korisnik>();
                for (int j = 0; j < vkupnoKorisnici - zenskiKorisnici; j++)
                {
                    Korisnik korisnikM = new Korisnik();
                    korisnikM.Ime = mashkiIminjaList[random.Next(0, mashkiIminjaList.Count)];
                    korisnikM.Prezime = mashkiPreziminjaList[random.Next(0, mashkiPreziminjaList.Count)];
                    korisnici.Add(korisnikM);

                }
                for (int k = 0; k < zenskiKorisnici; k++)
                {
                    Korisnik korisnikZ = new Korisnik();
                    korisnikZ.Ime = zenskiIminjaList[random.Next(0, zenskiIminjaList.Count)];
                    korisnikZ.Prezime = zenskiPreziminjaList[random.Next(0, zenskiPreziminjaList.Count)];
                    korisnici.Add(korisnikZ);
                }
                foreach (var korisnik in korisnici)
                {
                    txtRezultati.AppendText(korisnik.Ime + korisnik.Prezime + " ");
                }
            }
            catch (IOException ex)
            {
                ex.ToString();
            }
            finally
            {
                MessageBox.Show("Успешно е направено генерирањето", "Браво", MessageBoxButtons.OK);
            }
        }
    }
}
