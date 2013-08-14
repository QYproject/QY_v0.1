using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentInfo : UserInfo
    {

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
