using CrystalDecisions.Web;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.NetworkInformation;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace PFMSReporting
{
    public partial class Report : System.Web.UI.Page
    {
        public static DateTime date1 { get;set;}
        public static DateTime date2 { get; set; }


 

        protected void Page_Init(object sender, EventArgs e)
        {

            if (Session["report"] != null)
            {
                CrystalReportViewer1.ReportSource = (FullReport)Session["report"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SQL8002.site4now.net;Initial Catalog=db_a94059_pfms;User Id=db_a94059_pfms_admin;Password=pfms1234");
            SqlDataAdapter adapter;
            DataSet1 ds = new DataSet1();

            try
            {
                con.Open();
                String query1 = "SELECT v.v_id,v.v_l1,v.v_l2,v.v_l3,v.v_number,s.Tload,vi.Tvios  FROM Vehicles AS v LEFT JOIN (SELECT vehicle , sum( load )/2 AS Tload FROM Scans Group by vehicle ) s ON s.vehicle = v.v_id LEFT JOIN  (SELECT vehicle , COUNT( vi_id ) AS Tvios FROM Violations Group by vehicle ) vi ON vi.vehicle = v.v_id group by v.v_id, v.v_l1,v.v_l2,v.v_l3,v.v_number,s.Tload,vi.Tvios";
                String query2 = "select s_id,s_name,sum( s.load ) As Eload FROM Scans AS s LEFT JOIN Sites AS st on s.site = st.s_id group by st.s_id,st.s_name";
                String query3 = "SELECT pump , sum( load ) As Load FROM Scans WHERE pump IS NOT NULL  Group by pump";
                String query4 = "SELECT s.sc_id,s.sc_date,s.sc_shift,(v.v_l1+' '+v.v_l2+' '+v.v_l3+'-'+CAST(v.v_number AS NVARCHAR(100))) as vehicle,st.s_name as site,s.ship,s.pump,s.time,s.trip_time,s.loading_time,s.delay,s.state as s1, state = CASE WHEN s.state = 'start' THEN  N'بدايه' WHEN s.state = 'LOADING' THEN  N'تحميل'    WHEN s.state = 'POINT SKIP' THEN N'تخطي نقطه' WHEN s.state = 'LATE' THEN N'تاخر' WHEN s.state = 'ON TIME' THEN N'علي الوقت' END ,s.type as t1,type = CASE WHEN s.type = 'A' THEN  N'وصول' WHEN s.state = 'L' THEN  N'مغادره' END ,s.load from Scans as s LEFT JOIN Vehicles as v on s.vehicle = v.v_id LEFT JOIN Sites as st on s.site = st.s_id";
                String query5 = "SELECT vi.vi_id,(v.v_l1+' '+v.v_l2+' '+v.v_l3+'-'+CAST(v.v_number AS NVARCHAR(100))) as vehicle,st.s_name AS site,vi.cause as c1,vi.shift,vi.date,vi.time,vi.resolved as r1, cause = CASE WHEN vi.cause = '1' THEN  N'تاخر' WHEN vi.cause = '2' THEN  N'تخطي نقطه' END ,resolved = CASE WHEN vi.resolved = '0' THEN  N'لم تحل' WHEN vi.resolved = '1' THEN  N'تم الحل' END from Violations as vi LEFT JOIN Vehicles as v on vi.vehicle = v.v_id LEFT JOIN Sites as st on vi.site = st.s_id";
                adapter = new SqlDataAdapter(query1, con);
                adapter.Fill(ds, "vehiclesmeta");
                adapter = new SqlDataAdapter(query2, con);
                adapter.Fill(ds, "sitesmeta");
                adapter = new SqlDataAdapter(query3, con);
                adapter.Fill(ds, "pumpsmeta");
                adapter = new SqlDataAdapter(query4, con);
                adapter.Fill(ds, "Scans");
                adapter = new SqlDataAdapter(query5, con);
                adapter.Fill(ds, "Violations");
                FullReport rpt = new FullReport();
                rpt.SetDataSource(ds);
                TextObject d1 = (TextObject)rpt.ReportDefinition.Sections["Section1"].ReportObjects["Text10"];
                d1.Text = date1.ToString("dd/MM/yyyy");
                TextObject d2 = (TextObject)rpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11"];
                d2.Text = date2.ToString("dd/MM/yyyy");
                CrystalReportViewer1.ReportSource = rpt;
                Session.Add("report", rpt);
                con.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}