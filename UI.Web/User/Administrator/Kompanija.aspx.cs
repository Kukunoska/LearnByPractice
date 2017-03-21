using System;
using LearnByPractice.BLL.Managers.Organizational;
using LearnByPractice.DAL.Repositories.Organizational;

namespace LearnByPractice.UI.Web.User.Administrator
{
    public partial class Kompanija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OrganizacijaManager v = new OrganizacijaManager();
                dgKompanija.DataSource = v.GetAll();
                dgKompanija.DataBind();

                VidOrganizacijaManager k = new VidOrganizacijaManager();
                ddlKompanija.DataSource = k.GetAll();
                ddlKompanija.DataTextField = "Ime";
                ddlKompanija.DataValueField = "Id";
                ddlKompanija.DataBind();
            }
        }

        protected void ddlKompanija_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrganizacijaManager k = new OrganizacijaManager();
            OrganizacijaRepository kr = new OrganizacijaRepository();
            if (ddlKompanija.SelectedValue == 0.ToString())
            {
                dgKompanija.DataSource = k.GetAll();
                dgKompanija.DataBind();
            }

            else
            {
                dgKompanija.DataSource = kr.GetByVidOrganizacijaId(int.Parse(ddlKompanija.SelectedValue));
                dgKompanija.DataBind();
            }
        }
    }
}