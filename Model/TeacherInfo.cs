using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 老师类（继承于用户类）
    /// 作者：杨宇
    /// 说明：你只写了方法注释，忘了写类的注释
    /// </summary>
    public class TeacherInfo : UserInfo
    {
        private string _TrueName;
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string TrueName
        {
            get { return _TrueName; }
            set { _TrueName = value; }
        }

        private string _School;
        /// <summary>
        /// 所在的学校
        /// </summary>
        public string School
        {
            get { return _School; }
            set { _School = value; }
        }


        private string _GoodAt;
        /// <summary>
        /// 擅长领域
        /// </summary>
        public string GoodAt
        {
            get { return _GoodAt; }
            set { _GoodAt = value; }
        }

        private string _JobSpecials;
        /// <summary>
        /// 工作特长
        /// </summary>
        public string JobSpecials
        {
            get { return _JobSpecials; }
            set { _JobSpecials = value; }
        }

        private int _Level;
        /// <summary>
        /// 等级
        /// </summary>
        public int Level
        {
            get { return _Level; }
            set { _Level = value; }
        }

        private int _QQ;
        /// <summary>
        /// QQ
        /// </summary>
        public int QQ
        {
            get { return _QQ; }
            set { _QQ = value; }
        }

        private string _Experience;
        /// <summary>
        /// 工作经历
        /// </summary>
        public string Experience
        {
            get { return _Experience; }
            set { _Experience = value; }
        }

        private string _Address;
        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        private string _Intro;
        /// <summary>
        /// 简介
        /// </summary>
        public string Intro
        {
            get { return _Intro; }
            set { _Intro = value; }
        }

        private UserType _UType;
        /// <summary>
        /// 用户类型
        /// teacher子类规定了usertype，可get不可set，谢明华于8/15更新
        /// </summary>
        new public UserType UType
        {
            get
            {
                _UType = UserType.Teacher;
                return _UType;
            }
        }
    }
}
