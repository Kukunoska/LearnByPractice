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
            int a;
            bool aA = int.TryParse(txtVkupno.Text, out a);
            int b;
            bool bB = int.TryParse(txtZenski.Text, out b);
            int c;
            bool cC = int.TryParse(txtMashki.Text, out c);


            //Za Zhenski Iminja
            string[] zi = File.ReadAllLines("C:\\Users\\Andrea\\Desktop\\NBD_FIKT\\LearnByPractice\\Tools\\ZenskiIminja.txt");
            List<string> zenskiIminjaList = new List<string>();
            string s1 = zi[0];
            string[] zenskiIminja = s1.Split(',');
            foreach (var zI in zenskiIminja)
            {
                zenskiIminjaList.Add(zI);
            }

            //Za Zhenski Preziminja
            string[] zp = File.ReadAllLines("C:\\Users\\Andrea\\Desktop\\NBD_FIKT\\LearnByPractice\\Tools\\ZenskiPreziminja.txt");
            List<string> zenskiPreziminjaList = new List<string>();
            string s2 = zp[0];
            string[] zenskiPreziminja = s2.Split(',');
            foreach (var zP in zenskiPreziminja)
            {
                zenskiPreziminjaList.Add(zP);
            }

            //Za Mashki Iminja
            string[] mi = File.ReadAllLines("C:\\Users\\Andrea\\Desktop\\NBD_FIKT\\LearnByPractice\\Tools\\MashkiIminja.txt");
            List<string> mashkiIminjaList = new List<string>();
            string s3 = mi[0];
            string[] mashkiIminja = s3.Split(',');
            foreach (var mI in mashkiIminja)
            {
                mashkiIminjaList.Add(mI);
            }

            //Za Mashki Preziminja
            string[] mp = File.ReadAllLines("C:\\Users\\Andrea\\Desktop\\NBD_FIKT\\LearnByPractice\\Tools\\MashkiPreziminja.txt");
            List<string> mashkiPreziminjaList = new List<string>();
            string s4 = mp[0];
            string[] mashkiPreziminja = s4.Split(',');
            foreach (var mP in mashkiPreziminja)
            {
                mashkiPreziminjaList.Add(mP);
            }

            Random randoM = new Random();
            List<Korisnik> korisnici = new List<Korisnik>();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < c; j++)
                {

                    Korisnik korisnikM = new Korisnik();
                    korisnikM.Ime = mashkiIminjaList[randoM.Next(0, (mashkiIminjaList.Count - 1))];
                    korisnikM.Prezime = mashkiPreziminjaList[randoM.Next(0, (mashkiPreziminjaList.Count - 1))];
                    korisnici.Add(korisnikM);
                }
                for (int j = 0; j < b; j++)
                {
                    Korisnik korisnikZ = new Korisnik();
                    korisnikZ.Ime = zenskiIminjaList[randoM.Next(0, (zenskiIminjaList.Count - 1))];
                    korisnikZ.Prezime = zenskiPreziminjaList[randoM.Next(0, (zenskiPreziminjaList.Count - 1))];
                    korisnici.Add(korisnikZ);
                }
            }
        }
    }
}
