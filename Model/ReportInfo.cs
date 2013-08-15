using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 作者：李嘉贤
    /// 报告消息
    /// </summary>
    public class ReportInfo
    {
        private string _ReportInfoID;
        /// <summary>
        /// 报告信息ID
        /// </summary>

        public string ReportInfoID
        {
            get { return _ReportInfoID; }
            set { _ReportInfoID = value; }
        }

        private string _ResourceID;
        /// <summary>
        /// 资源ID
        /// </summary>
        public string ResourceID
        {
            get { return _ResourceID; }
            set { _ResourceID = value; }
        }

        private string _ResourceType;
        /// <summary>
        /// 资源类型
        /// </summary>
        public string ResourceType
        {
            get { return _ResourceType; }
            set { _ResourceType = value; }
        }

        private string _ReportDetail;
        /// <summary>
        /// 报告详细
        /// </summary>
        public string ReportDetail
        {
            get { return _ReportDetail; }
            set { _ReportDetail = value; }
        }
    }
}
