using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using DALFatory;
using Model;

namespace BLL
{
    public class BLL_Document
    {
        private IDocument _documentDal;

        public IDocument documentDal
        {
            get {
                if (_documentDal == null)
                    _documentDal = Factory.CreateDocument();
                return _documentDal; 
            }
        }

        public List<DocumentInfo> GetDocumentByName(string name)
        {
            return documentDal.GetDocumentByName(name);
        }


    }
}
