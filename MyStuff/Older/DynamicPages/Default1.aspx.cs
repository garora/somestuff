using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default1 : System.Web.UI.Page
{
    
    private const string BASE_PATH = "/myPages/";

    private String DynamicPage
    {
        get
        {
            if((ViewState["DynamicPage"] != null) )
                return Convert.ToString(ViewState["DynamicPage"]);
            else
                return BASE_PATH + "myDefaultPage.ascx";  //Default page
        }
        set
        {
            ViewState["DynamicPage"] = value;
        }
    }
    private void LoadUserControl()
    {
        string controlPath = DynamicPage;

        if (!string.IsNullOrEmpty(DynamicPage))
        {
            myPage.Controls.Clear();
            UserControl muUserControl = (UserControl)LoadControl(controlPath);
            myPage.Controls.Add(muUserControl);
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        this.DynamicPage = Request.QueryString["DyPage"];
        //Load newly created page
        LoadUserControl();  //Load your control
    }
}
