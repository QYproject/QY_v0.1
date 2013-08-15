using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace 青羊教育网络学习平台
{
    public partial class ShowDocument : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TXT1.Text = "";
            //int ID =Convert.ToInt32( TextBox1.Text);
            string name = TextBox1.Text;
            List<DocumentInfo> doclist=new List<DocumentInfo>();
            doclist = new BLL.BLL_Document().GetDocumentByName(name);

            //foreach(DocumentInfo doc in doclist)
            //{
            //    TXT1.Text += "名称:" + doc.Titile + "   \n";
            //    TXT1.Text += "大小:" + doc.Size + "M    \n";
            //    TXT1.Text += "类型:" + doc.Format + "   \n\n";
            //}
            
            TextBox1.Text = doclist.Count.ToString();

            GridView1.DataSource = doclist;
            GridView1.DataBind();
        }



        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}