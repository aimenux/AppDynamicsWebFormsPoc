using System;
using System.Linq;
using WebApp1.DataAccess;

namespace WebApp1.Pages
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