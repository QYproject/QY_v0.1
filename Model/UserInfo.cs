using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 枚举用户类型
    /// </summary>
    public enum UserType
    { Student, Teacher, Admin }

    /// <summary>
    /// 作者：杨宇
    /// 用户类
    /// 说明：作为学生，老师，管理员的父类。登录时可直接使用
    /// </summary>
    public  class UserInfo
    {
        private int _UserID;
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }


        private UserType _UType;
        /// <summary>
        /// 用户类型
        /// 作者：谢明华    8/14日修改
        /// </summary>
        public UserType UType
        {
            get { return _UType; }
            set { _UType = value; }
        }

        private int _Password;
        /// <summary>
        /// 密码编号
        /// </summary>
        public int Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private string _UserName;
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        private Boolean _Sex;
        /// <summary>
        /// 用户性别
        /// </summary>
        public Boolean Sex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }

        private DateTime _Birthday;
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime Birthday
        {
            get { return _Birthday; }
            set { _Birthday = value; }
        }

        private string _Email;
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _Phone;
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }



        private string _PhotoUrl;
        /// <summary>
        /// 用户头像
        /// </summary>
        public string PhotoUrl
        {
            get { return _PhotoUrl; }
            set { _PhotoUrl = value; }
        }

    }
}
