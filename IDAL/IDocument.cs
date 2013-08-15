using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
     public interface IDocument
    {
         List<DocumentInfo> GetDocumentByCatalog(CatalogInfo catalog);
         List<DocumentInfo> GetDocumentByName(string name);
         DocumentInfo GetDocumentByID(string ID);
    }
}
