using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myTemplates_PageHeader : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String strPath = ".\\images\\title.gif";
        plhImage.Controls.Add(new LiteralControl("<img src = " + strPath + " alt=MsDotNetHeaven width=970 height=87 /><br /> "));
    }
}
