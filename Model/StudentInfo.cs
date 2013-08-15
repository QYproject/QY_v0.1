using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 学生类（继承于用户类）
    /// 作者：杨宇
    /// 说明：你只写了方法注释，忘了写类的注释
    /// </summary>
    public class StudentInfo : UserInfo
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
        /// 学校
        /// </summary>
        public string School
        {
            get { return _School; }
            set { _School = value; }
        }

        private int _QQ;
        /// <summary>
        /// QQ号码
        /// </summary>
        public int QQ
        {
            get { return _QQ; }
            set { _QQ = value; }
        }

        private string _intro;
        /// <summary>
        /// 简介
        /// </summary>
        public string Intro
        {
            get { return _intro; }
            set { _intro = value; }
        }

        private UserType _UType;
        /// <summary>
        /// 用户类型
        /// student子类规定了usertype，可get不可set，谢明华于8/15更新
        /// </summary>
        new  public UserType UType
        {
            get { 
                _UType= UserType.Student;
                return _UType;
            }
        }
    }
}
