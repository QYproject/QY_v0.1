using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using IDAL;
using Model;
using DBUtility;

namespace DAL
{
    public class DAL_Document:IDocument
    {
        public List<DocumentInfo> GetDocumentByName(string name)
        {
            SqlParameter paramName = new SqlParameter("@name", SqlDbType.NVarChar);

            paramName.Value = name;

            SqlParameter[] sqlParams = { paramName };
            List<DocumentInfo> Doclist = new List<DocumentInfo>();

            using (SqlDataReader reader = SQLHelper.ExecuteReader(SQLHelper.ConnectionString, CommandType.StoredProcedure, "pr_GetDocumentByName1", sqlParams))
            {
                while(reader.Read())
                {
                    DocumentInfo Doc  = new DocumentInfo();
                    Doc.ID = Convert.ToString(reader["ResourceID"]);
                    Doc.Title = Convert.ToString(reader["Name"]);
                    Doc.Size = Convert.ToInt32(reader["Size"]);
                   // Doc.Type = Convert.ToString(reader["Type"]);   
                    Doc.setFormat(Convert.ToString(reader["Type"]));
                    Doclist.Add(Doc);
                }
                return Doclist;
            }
        }

        public List<DocumentInfo> GetDocumentByCatalog(CatalogInfo catalog)
        {
            throw new NotImplementedException();
        }

        public DocumentInfo GetDocumentByID(string ID)
        {
            throw new NotImplementedException();
        }
    }
}
