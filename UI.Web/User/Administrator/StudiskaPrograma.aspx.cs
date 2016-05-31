using System;
using LearnByPractice.BLL.Managers.Education;

namespace LearnByPractice.UI.Web.User.Administrator
{
    public partial class StudiskaPrograma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudiskaProgramaManager sp = new StudiskaProgramaManager();
            dgStudProg.DataSource=sp.GetAll();
            dgStudProg.DataBind();
        }
    }
}