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
        public enum DocFormat
        { doc,ppt,pdf,txt}


        private DocFormat _Format;
        /// <summary>
        /// 设置文档资料的类型
        /// 添加了set方法，通过string赋值并返回是否成功
        /// </summary>
        public DocFormat Format
        {
            get {    return _Format;   }
            private  set { _Format = value; }
        }
        public bool setFormat(string format)
        {
            if (format.Equals(DocFormat.doc.ToString()))
                this._Format = DocFormat.doc;
            else if (format.Equals(DocFormat.ppt.ToString()))
                this._Format = DocFormat.ppt;
            else if (format.Equals(DocFormat.pdf.ToString()))
                this._Format = DocFormat.pdf;
            else if (format.Equals(DocFormat.txt.ToString()))
                this._Format = DocFormat.txt;
            else
                return false;

            return true;
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
               // if (value <= Convert.ToInt32(ConfigurationManager.AppSettings["DocMAX"])&&value>0)
                    _Size = value; 
            }
        }

        private bool _IsVideo;
        /// <summary>
        /// 是否视频
        /// </summary>
        new  public bool IsVideo
        {
            get { return false; }
        }
    }
}
