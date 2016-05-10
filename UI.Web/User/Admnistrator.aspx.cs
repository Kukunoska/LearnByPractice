using System;
using LearnByPractice.DAL.Repositories.Organizational;
using LearnByPractice.Domain.Organizational;
using LearnByPractice.DAL.Repositories.Education;

namespace LearnByPractice.UI.Web.User
{
    public partial class Admnistrator : System.Web.UI.Page
    {
        private int i = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Prkaz na vidovi organizacii
            VidOrganizacijaRespository v = new VidOrganizacijaRespository();
            VidO.Text = "";
            foreach (var a in v.GetAll())
            {
                VidO.Text += a.Id + " " + a.Ime + "    <br/>";
                i++;
            }

            //prikaz na studiski programi
            StudiskaProgramaRepository studP = new StudiskaProgramaRepository();
            SP.Text = "";
            foreach (var a in studP.GetAll())
            {
                SP.Text += a.Id + " " + a.Ime + "    <br/> ";
                i++;
            }

            //KompanijaRepository k = new KompanijaRepository();
            //Organiz.Text = "";
            //VidOrganizacijaRespository vOr = new VidOrganizacijaRespository();
            //foreach (var a in k.GetAll())
            //{
            //    VidO.Text += a.Id + " " + a.Ime + " " + a.Adresa + " " + a.KontaktTelefon + " " + a.VebStrana + " " + vOr.Get(a.vidOrganizacija.Id).Ime + "<br/>";
            //   i++;
            //}
        }
    }
}