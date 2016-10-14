using System;
using System.IO;
using System.Web;
using System.Web.Configuration;

public partial class UpFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //ip判断
            if (WebConfigurationManager.AppSettings["AllowIP"] != null)
            {
                if (WebConfigurationManager.AppSettings["AllowIP"].ToString() != "") {

                    string requestip = this.Request.UserHostName;
                    string allowip = WebConfigurationManager.AppSettings["AllowIP"].ToString();

                    if (allowip.Contains(requestip))
                    {
                        FileSave(this.Request);
                    }
                }
            }
            Response.Write("");
        }
    }

    /// <summary>
    /// 保存图片
    /// </summary>
    /// <param name="Request"></param>
    public void FileSave(HttpRequest Request)
    {
        string path = "";

        if (Request.InputStream.Length > 0) {
            FileHelp fileHelp = new FileHelp();
            path = fileHelp.Save(Request.InputStream);
        }
        Response.Write(path);
    }
}