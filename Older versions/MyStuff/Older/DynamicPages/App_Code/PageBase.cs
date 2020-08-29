using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for PageBase
/// </summary>
public class PageBase : System.Web.UI.Page
{
    public PageBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    #region Properties
    public String PageID
    {
        get
        {
            if (ViewState["PageID"] != null)
                return Convert.ToString(ViewState["PageID"]);
            else
                return "0";
        }
        set
        {
            ViewState["PageID"] = value;
        }
    }
    public String MetaTitle
    {
        get 
        {
            if (ViewState["MetaTitle"] != null)
                return Convert.ToString(ViewState["MetaTitle"]);
            else
               return "No Title";
        }
        set
        {
            ViewState["MetaTitle"] = value;
        }
    }
    public String MetaKeywords
    {
        get
        {
            if (ViewState["MetaKeywords"] != null)
                return Convert.ToString(ViewState["MetaKeywords"]);
            else
                return "No Keywords";
        }
        set
        {
            ViewState["MetaKeywords"] = value;
        }
    }
    #endregion

    protected override void OnLoad(EventArgs e)
    {
        if (!String.IsNullOrEmpty(MetaTitle))
        {
            HtmlMeta Title = new HtmlMeta();
            Title.Name = "Title";
            Title.Content = this.MetaTitle;
            this.Header.Controls.Add(Title);
        }

        if (!String.IsNullOrEmpty(MetaKeywords))
        {
            HtmlMeta Keyword = new HtmlMeta();
            Keyword.Name = "Keywords";
            Keyword.Content = this.MetaKeywords;
            this.Header.Controls.Add(Keyword);
        }

        //overide base
        base.OnLoad(e);
    }

    void Page_Error(object sender, EventArgs e)
    {
        Server.Transfer("Error.aspx");
    }
}
