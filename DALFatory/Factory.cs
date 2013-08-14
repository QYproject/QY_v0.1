using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using DAL;
using System.Reflection;
using System.Configuration;

namespace DALFatory
{
    public class Factory
    {
        private static string DAL = ConfigurationManager.AppSettings["DAL"];

        public static IDocument  CreateDocument()
        {
            try
            {
                IDocument DS = (DAL_Document)Assembly.Load(DAL).CreateInstance(DAL + ".DAL_Document");
                IDocument DALDocument = (IDocument)DS;
                return DALDocument;
            }
            catch (Exception e)
            {
                string s = e.Message.ToString();
                return null;
            }
        }
    }
}
