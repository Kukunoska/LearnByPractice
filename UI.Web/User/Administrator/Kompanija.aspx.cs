using System;
using LearnByPractice.BLL.Managers.Organizational;
using LearnByPractice.DAL.Repositories.Organizational;

namespace LearnByPractice.UI.Web.User.Administrator
{
    public partial class Kompanija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VidOrganizacijaManager v = new VidOrganizacijaManager();
            dgKompanija.DataSource = v.GetAll();
            dgKompanija.DataBind();

            KompanijaManager k = new KompanijaManager();
            ddlKompanija.DataSource = k.GetAll();
            ddlKompanija.DataTextField = "Ime";
            ddlKompanija.DataValueField = "Id";
            ddlKompanija.DataBind();
        }

        protected void ddlKompanija_SelectedIndexChanged(object sender, EventArgs e)
        {
            KompanijaManager k = new KompanijaManager();
            KompanijaRepository kr = new KompanijaRepository();
            if (ddlKompanija.SelectedValue == 0.ToString())
            {
                ddlKompanija.DataSource = k.GetAll();
                ddlKompanija.DataBind();
            }

            else
            {
                ddlKompanija.DataSource = kr.GetByVidOrganizacijaId(int.Parse(ddlKompanija.SelectedValue));
                ddlKompanija.DataBind();
            }
        }
    }
}