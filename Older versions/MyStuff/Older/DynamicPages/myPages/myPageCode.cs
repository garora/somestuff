using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class myPageCode : PageBase
{
    public String newPageID
    {
        get
        {
            if (ViewState["newPageID"] != null)
                return Convert.ToString(ViewState["newPageID"]);
            else
                return "0";
        }
        set
        {
            ViewState["newPageID"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        base.PageID = this.newPageID;
    }

}
