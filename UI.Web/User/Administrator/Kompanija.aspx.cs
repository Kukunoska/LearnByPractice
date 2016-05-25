using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LearnByPractice.BLL.Managers.Organizational;

namespace LearnByPractice.UI.Web.User.Administrator
{
    public partial class Kompanija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VidOrganizacijaManager v = new VidOrganizacijaManager();
            dgKompanija.DataSource = v.GetAll();
            dgKompanija.DataBind();
        }
    }
}