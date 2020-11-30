using System;
using System.Linq;
using System.Web.UI.WebControls;
using WebApp3.DataAccess;

namespace WebApp3.Pages
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var ctx = new SchoolDbContext())
                {
                    var students = ctx.Students.ToList();
                    StudentsGridview.DataSource = students;
                    StudentsGridview.DataBind();
                }
            }
        }
    }
}