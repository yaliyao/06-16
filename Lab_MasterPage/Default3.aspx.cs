﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Trace.Warn("Default3's Page_Load");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Trace.Warn("Defalt'3 Click");
        Session["lbl"] = 300;
    }
}