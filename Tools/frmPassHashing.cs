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
            txtHash.Text = Hashing.ComputeHash(txtPassword.Text, Supported_HASH.SHA256, null);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lblStatus.Text = (Hashing.Confirm(txtPassword.Text, txtHash.Text, Supported_HASH.SHA256)) ? "Статус: Точно" : "Статус: Неточно";
        }
    }
}
