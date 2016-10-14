using System;
using System.IO;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// FileHelp 的摘要说明
/// </summary>
public class FileHelp
{
    public string Save(Stream stream)
    {
        System.Drawing.Bitmap image = new System.Drawing.Bitmap(stream);

        string imgname = System.Guid.NewGuid() + ".jpg";
        if (WebConfigurationManager.AppSettings["ImagePath"] != null)
        {
            string imgpath = WebConfigurationManager.AppSettings["ImagePath"].ToString();
            imgpath = imgpath + DateTime.Now.ToString("yyyyMMdd") + "/";

            if (!Directory.Exists(HttpContext.Current.Server.MapPath(imgpath)))
            {
                System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath(imgpath));
            }

            image.Save(HttpContext.Current.Server.MapPath(imgpath + "/" + imgname));

            return imgpath + "/" + imgname;
        }
        return "";
    }
}