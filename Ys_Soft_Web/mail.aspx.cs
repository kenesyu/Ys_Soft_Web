using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Ys_Soft_Web
{
    public partial class mail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                string name = this.Request.Form[0].ToString();
                string mail = this.Request.Form[1].ToString();
                string message = this.Request.Form[2].ToString();

                using (StreamWriter sw = new StreamWriter(Server.MapPath("/mail.txt"), true))
                {
                    sw.WriteLine("------------- "+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")+" ----------------");
                    sw.WriteLine(name);
                    sw.WriteLine(mail);
                    sw.WriteLine(message);
                }
                Response.Write("Your message has been received, we will contact you as soon as possible");
            }
        }
    }
}