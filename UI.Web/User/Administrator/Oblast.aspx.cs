using System;
using LearnByPractice.BLL.Managers.Practice;

namespace LearnByPractice.UI.Web.User.Administrator
{
    public partial class Oblast : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OblastManager o = new OblastManager();
            dgOblast.DataSource = o.GetAll();
            dgOblast.DataBind();
        }
    }
}