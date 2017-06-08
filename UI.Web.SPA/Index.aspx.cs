using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

using managers = LearnByPractice.BLL.Managers;
using domain = LearnByPractice.Domain;

namespace LearnByPractice.UI.Web.wwwroot
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NajaviSeButton_Click(object sender, EventArgs e)
        {
            if (!IsValid)
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
                else if (BLL.Managers.Security.Hashing.HashesEqual(LozinkaTextBox.Text, najdenKorisnik.PasswordOdNiza))
                {
                    FormsAuthentication.RedirectFromLoginPage(najdenKorisnik.Username, ZapomniMeCheckBox.Checked);
                }
                else
                {
                    NajavaPorakaZaGreshkaLabel.Text = "Погрешна лозинка.";
                    NajavaPorakaZaGreshkaLabel.Visible = true;
                }
            }
            catch (Exception)
            {
                // Тука би требало грешката да се запиши во event log-от на серверот
                NajavaPorakaZaGreshkaLabel.Visible = true;
                NajavaPorakaZaGreshkaLabel.Text = "Неочекувана грешка.";
            }
        }

        protected void RegistrirajSeButton_Click(object sender, EventArgs e)
        {
            if (!IsValid)
            {
                return;
            }

            RegistracijaPorakaZaGreshkaLabel.Visible = false;
            try
            {
                var korisnikManager = new managers::Security.KorisnikManager();
                var novKorisnik = korisnikManager.TryGetByKorisnichkoIme(korisnichkoImeTxtBox.Text.Trim());
                if (novKorisnik == null)
                {
                    novKorisnik.Ime = imeTextBox.Text;
                    novKorisnik.Prezime = prezimeTextBox.Text;
                    novKorisnik.Username = korisnichkoImeTxtBox.Text;
                    novKorisnik.Password = lozinkaTxtBox.Text;
                    novKorisnik.Email = emailTextBox.Text;
                    novKorisnik.Mobilen = telefonTextBox.Text;
                    
                    korisnikManager.Insert(novKorisnik);

                    FormsAuthentication.RedirectFromLoginPage(novKorisnik.Username, createPersistentCookie: true);
                }
                else
                {
                    RegistracijaPorakaZaGreshkaLabel.Text = "Корисничкото име е зафатено.";
                    RegistracijaPorakaZaGreshkaLabel.Visible = true;
                }
            }
            catch
            {
                // Тука би требало грешката да се запиши во event log-от на серверот
                RegistracijaPorakaZaGreshkaLabel.Visible = true;
                RegistracijaPorakaZaGreshkaLabel.Text = "Неочекувана грешка.";
            }
        }
    }
}