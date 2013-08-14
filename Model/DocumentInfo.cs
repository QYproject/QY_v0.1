using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Model
{
    public  class DocumentInfo:ResourceInfo
    {
        /// <summary>
        /// 枚举文档资料类型
        /// </summary>
        public enum DocType
        { doc,ppt,pdf,txt}


        private DocType _Type;
        /// <summary>
        /// 设置文档资料的类型
        /// </summary>
        public DocType Type
        {
            get {    return _Type;   }
            set { 
                _Type = value;
            }
        }

        private int _Size;
        /// <summary>
        /// 文档资料大小
        /// 说明：不能超过最大值
        /// </summary>
        new  public int Size
        {
            get { return _Size; }
            set {
                if (value <= Convert.ToInt32(ConfigurationManager.AppSettings["DocMAX"])&&value>0)
                    _Size = value; 
            }
        }

        
    }
}
