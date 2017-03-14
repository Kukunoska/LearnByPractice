using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

using managers = LearnByPractice.BLL.Managers;

namespace LearnByPractice.UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NajaviSeButton_Click(object sender, EventArgs e)
        {
            if (! IsValid)
            {
                return;
            }

            NajavaPorakaZaGreshkaLabel.Visible = false;
            try
            {
                var korisnikManager = new managers::Security.KorisnikManager();
                var najdenKorisnik = korisnikManager.TryGetByKorisnichkoIme(KorisnichkoImeTextBox.Text.Trim());
                if (najdenKorisnik == null)
                {
                    NajavaPorakaZaGreshkaLabel.Text = "Непостоечки корисник.";
                    NajavaPorakaZaGreshkaLabel.Visible = true;
                }
                else
                {
                    FormsAuthentication.RedirectFromLoginPage(najdenKorisnik.Username, ZapomniMeCheckBox.Checked);
                }
            }
            catch(Exception)
            {
                // Тука би требало грешката да се запиши во event log-от на серверот
                NajavaPorakaZaGreshkaLabel.Visible = true;
                NajavaPorakaZaGreshkaLabel.Text = "Неочекувана грешка.";
            }
        }
    }
}