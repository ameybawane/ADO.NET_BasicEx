using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ADODemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=<server name>; database=Sample; integrated security=SSPI");
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblDevice", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
            con.Close();
        }
    }
}
