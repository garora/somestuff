using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

public partial class myTemplates_createPage : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    String Title = String.Empty;
    protected void btnGenerate_Click(object sender, EventArgs e)
    {
        String root = Server.MapPath("~");

        String pgTemplate = root + "\\myPageTemplate.tmp";

        StringBuilder line = new StringBuilder();
        
        using (StreamReader rwOpenTemplate = new StreamReader(pgTemplate))
        {
            while (!rwOpenTemplate.EndOfStream)
            {
                line.Append(rwOpenTemplate.ReadToEnd());
            }
        }

        int ID = 0;
        string SaveFilePath = "";
        string SaveFileName = "";
        Random ran = new Random();
        ID = ran.Next();

        //Page Name Creator
        Title = ID.ToString() + "-" + txtTitle.Text.Replace(' ', '-').Replace('.', '-').Replace('#', '-').Replace('%', '-').Replace('&', '-').Replace('*', '-').Replace('@', '-').Replace('!', '-').Replace('|', '-').Replace(':', '-').Replace(';', '-').Replace(',', '-').Replace('/', '-').Replace('\\', '-').Replace('?', '-').Replace('<', '-').Replace('>', '-').Replace('"', '-').Replace('“', '-').Replace('”', '-');
        SaveFileName = "\\" + Title + ".aspx";
        SaveFilePath = root + "\\myPages\\" + SaveFileName;
        FileStream fsSave = File.Create(SaveFilePath);
        if (line != null)
        {
            line.Replace("[MetaTitle]", txtTitle.Text.Replace("<", "&lt;").Replace(">", "&gt;").Replace('"', ' ').Replace('"', ' '));
            line.Replace("[PageContent]", txtContent.Text);
            line.Replace("[MetaKeywords]", txtTags.Text.Replace('"', ' ').Replace('"', ' ').Replace('<', '-').Replace('>', '-'));
            //line.Replace("[Content]", txtContent.Text.Replace('"', ' ').Replace('"', ' ').Replace('<', '-').Replace('>', '-'));
            line.Replace("[ID]", ID.ToString());
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fsSave);
                sw.Write(line);
               // lnkNewPage.Text = SaveFilePath;
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            finally
            {
                sw.Close();                
            }
        }

    }
    protected void lnkNewPage_Click(object sender, EventArgs e)
    {
        //Response.Redirect("\\DynamicPages\\myPages\\" + Title );
        Response.Redirect(Title);
    }
}
