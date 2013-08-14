using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 作者：李嘉贤
    /// 信息实体类
    /// </summary>
    public class MessageInfo
    {
        private int _MessageID;
        /// <summary>
        /// 信息ID
        /// </summary>
        public int MessageID
        {
            get { return _MessageID; }
            set { _MessageID = value; }
        }

        private int _TeacherID;
        /// <summary>
        /// 老师ID
        /// </summary>
        public int TeacherID
        {
            get { return _TeacherID; }
            set { _TeacherID = value; }
        }

        private int _StudentID;
        /// <summary>
        /// 学生
        /// </summary>
        public int StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }

        private DateTime _Time;
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }

        private string _MessageDetail;
        /// <summary>
        /// 消息详细
        /// </summary>
        public string MessageDetail
        {
            get { return _MessageDetail; }
            set { _MessageDetail = value; }
        }
    }
}