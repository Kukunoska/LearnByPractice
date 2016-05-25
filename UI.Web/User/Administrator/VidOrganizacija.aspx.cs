using System;
using LearnByPractice.BLL.Managers.Organizational;
using System.Web.UI.WebControls;

namespace LearnByPractice.UI.Web.User.Administrator
{
    public partial class VidOrganizacija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VidOrganizacijaManager v = new VidOrganizacijaManager();
            dgVidOrg.DataSource = v.GetAll();
            dgVidOrg.DataBind();
        }
    }
}