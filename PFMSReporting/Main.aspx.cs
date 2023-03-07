using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PFMSReporting
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
        }




        protected void createreport_Click(object sender, EventArgs e)
        {
            DateTime a = Convert.ToDateTime(d1.Value);
            System.Diagnostics.Debug.WriteLine(a.ToString("dd/MM/yyyy"));
            DateTime b = Convert.ToDateTime(d2.Value);
            System.Diagnostics.Debug.WriteLine(b.ToString("dd/MM/yyyy"));
            Report.date1 = a;
            Report.date2 = b;
            Response.Redirect("Report.aspx");

        }
    }
}