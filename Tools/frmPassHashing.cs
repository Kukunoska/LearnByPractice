using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace LearnByPractice
{
    public partial class frmPassHashing : Form
    {
        public frmPassHashing()
        {
            InitializeComponent();
        }
        public frmPassHashing(frmMain parent) 
        {
            InitializeComponent(); 
            MdiParent = parent; 
        }

        private void btnHashing_Click(object sender, EventArgs e)
        {
            byte[] hashedPassword = Hashing.ComputeHash(txtPassword.Text, Supported_HASH.SHA256, null);
            string hashedPasswordString = BitConverter.ToString(hashedPassword).Replace("-", "");
            txtHash.Text = hashedPasswordString;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string hashValue = txtHash.Text;
            byte[] hashBytes = Enumerable.Range(0, hashValue.Length / 2).Select(x => Convert.ToByte(hashValue.Substring(x * 2, 2), 16)).ToArray();
            lblStatus.Text = (Hashing.Confirm(txtPassword.Text, hashBytes, Supported_HASH.SHA256)) ? "Статус: Точно" : "Статус: Неточно";
        }
    }
}
