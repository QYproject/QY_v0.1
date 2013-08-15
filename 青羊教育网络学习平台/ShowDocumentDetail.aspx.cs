using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 青羊教育网络学习平台
{
    public partial class ShowDocumentDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "";
            if (Request.QueryString["ID"] != null)
            {
                s += "ID:" + Request.QueryString["ID"];
            }
            Button1.Text = s;
        }
    }
}