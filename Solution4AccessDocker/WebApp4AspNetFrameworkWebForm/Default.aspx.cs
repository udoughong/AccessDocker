using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp4AspNetFrameworkWebForm
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(string));
                for (int i = 0; i < 15; i++)
                {
                    dt.Rows.Add(i.ToString());
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}