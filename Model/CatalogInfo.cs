using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 目录类
    /// 作者：吴中阳
    /// </summary>
    class CatalogInfo
    {
        private int _CatalogID;
        /// <summary>
        /// 目录ID
        /// </summary>
        public int CatalogID
        {
            get { return _CatalogID; }
            set { _CatalogID = value; }
        }

        private string _Layer1;
        /// <summary>
        /// 第一层目录
        /// </summary>
        public string Layer1
        {
            get { return _Layer1; }
            set { _Layer1 = value; }
        }

        private string _Layer2;
        /// <summary>
        /// 第二层目录
        /// </summary>
        public string Layer2
        {
            get { return _Layer2; }
            set { _Layer2 = value; }
        }


        private string _Layer3;
        /// <summary>
        /// 第三层目录
        /// </summary>
        public string Layer3
        {
            get { return _Layer3; }
            set { _Layer3 = value; }
        }
    }
}
