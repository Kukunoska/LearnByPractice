using System;
using LearnByPractice.BLL.Managers.Practice;
using LearnByPractice.DAL.Repositories.Practice;


namespace LearnByPractice.UI.Web.User.Administrator
{
    public partial class Tehnologija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TehnologijaManager t = new TehnologijaManager();
                dgTehnologija.DataSource = t.GetAll();
                dgTehnologija.DataBind();

                OblastManager o = new OblastManager();
                ddlTehnologija.DataSource = o.GetAll();
                ddlTehnologija.DataTextField = "Ime";
                ddlTehnologija.DataValueField = "Id";
                ddlTehnologija.DataBind();
            }
        }

        protected void ddlTehnologija_SelectedIndexChanged(object sender, EventArgs e)
        {
            TehnologijaManager t = new TehnologijaManager();
            TehnologijaRepository tr = new TehnologijaRepository();
            if (ddlTehnologija.SelectedValue == 0.ToString())
            {
                dgTehnologija.DataSource = t.GetAll();
                dgTehnologija.DataBind();
            }
                
            else
            {
                dgTehnologija.DataSource = tr.GetByOblastId(int.Parse(ddlTehnologija.SelectedValue));
                dgTehnologija.DataBind();
            }

        }
    }
}