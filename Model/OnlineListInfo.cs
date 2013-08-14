using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 作者：李嘉贤
    /// 在线表单
    /// </summary>
    public class OnlineListInfo
    {
        private string _TeacherName;
        /// <summary>
        /// 老师姓名
        /// </summary>
        public string TeacherName
        {
            get { return _TeacherName; }
            set { _TeacherName = value; }
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

        private string _TeacherGoodAt;
        /// <summary>
        /// 老师擅长领域
        /// </summary>
        public string TeacherGoodAt
        {
            get { return _TeacherGoodAt; }
            set { _TeacherGoodAt = value; }
        }

    }
}