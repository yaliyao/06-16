using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Trace.Warn("Master's Page_Load");
        //lblTest.Text = Session["lbl"].ToString();
        lblTest.Text = this.Session["lbl"].ToString();
    }
    // PreRender
    protected void Page_PreRender(object sender, EventArgs e) {
        Trace.Warn("Master's PreRender");
        lblTest.Text = Session["lbl"].ToString();
    }

    //public string MasterLabel {
    //    set {
    //        Session["lbl"] = value;
    //        this.lblTest.Text = value;
    //    }
    //    get {
    //        return Session["lbl"].ToString();
    //    }
    //}

}

