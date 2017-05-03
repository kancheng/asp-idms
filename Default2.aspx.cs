using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    string ird, srd, mrd, drd;
    protected void Page_Load(object sender, EventArgs e)
    {

        string si1, si2, sm1, sm2, ss, sd;
        

		ird = Server.UrlDecode(Request.Cookies["idms"]["insert"]);
        srd = Session["searchmrd"].ToString();
		mrd = Server.UrlDecode(Request.Cookies["idms"]["modify"]);
        drd = Session["deletemrd"].ToString();

        if (Session["insid"] != null && Session["insct"] != null)
        {
            si1 = Session["insid"].ToString();
            si2 = Session["insct"].ToString();
            Label1.Text += "Insert ID : " + si1 + "<br />";
            Label1.Text += "Insert Price : " + si2 + "<br />";
        }
        else
        {
            Label1.Text += "Insert ID : NULL <br />";
            Label1.Text += "Insert Price : NULL <br />";
        }

        if (Session["mfid"] != null && Session["mfct"] != null) {
            sm1 = Session["mfid"].ToString();
            sm2 = Session["mfct"].ToString();
            Label1.Text += "Modify ID : " + sm1 + "<br />";
            Label1.Text += "Modify Price : " + sm2 + "<br />";
        }
        else
        {
            Label1.Text += "Modify ID : NULL <br />";
            Label1.Text += "Modify Price : NULL <br />";
        }

        if (Session["seid"] != null) {
            ss = Session["seid"].ToString();
            Label1.Text += "Search ID : " + ss + "<br />";
        }
        else
        {
            Label1.Text += "Search ID : NULL <br />";
        }

        if (Session["deid"] != null) {
            sd = Session["deid"].ToString();
            Label1.Text += "Delete ID : " + sd + "<br />";
        }
        else
        {
            Label1.Text += "Delete ID : NULL <br />";
        }


        Label2.Text += Convert.ToString("Insert Times : " + ird + "<br />");
        Label2.Text += Convert.ToString("Modify Times : " + mrd + "<br />");
		Label2.Text += Convert.ToString("Search Times : " + srd + "<br />");
		Label2.Text += Convert.ToString("Delete Times : " + drd + "<br />");
    }

    protected void back_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}