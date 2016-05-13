using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Web;
using Tools;

namespace LearnByPractice
{
    public partial class frmHashing : Form
    {
        public frmHashing()
        {
            InitializeComponent();
        }
        public frmHashing(frmMain parent) 
        {
            InitializeComponent(); 
            MdiParent = parent; 
        }

        //Метод за генерирање на случајна salt вредност
        string CreateSalt(int size)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        //Метод за хаширање
        string SHA1(string password) 
        {
            byte[] hashedPassword;
            using (var sha1 = new SHA1CryptoServiceProvider()) 
            {
                hashedPassword = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            var sb = new StringBuilder();
            foreach (byte b in hashedPassword) sb.AppendFormat("{0:x2}", b);
            return sb.ToString();
        }

        private void GenSaltAndHash_Click(object sender, EventArgs e)
        {
            string salt = CreateSalt(16);
            string hashedPassword = SHA1(SHA1(textBox1.Text + salt));
            textBox2.Text = salt;
            textBox3.Text = hashedPassword;
        }
    }
}
