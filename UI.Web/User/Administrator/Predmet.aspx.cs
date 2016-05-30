using System;
using LearnByPractice.BLL.Managers.Education;

namespace LearnByPractice.UI.Web.User.Administrator
{
    public partial class Predmet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PredmetManager p = new PredmetManager();
            dgPredmet.DataSource = p.GetAll();
            dgPredmet.DataBind();
        }
    }
}