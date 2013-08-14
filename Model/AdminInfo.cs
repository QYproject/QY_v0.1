using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 作者：李嘉贤
    /// 管理员
    /// </summary>
    public class AdminInfo : UserInfo
    {
        private bool _IsSuper;
        /// <summary>
        /// 用户等级，是否超级管理员
        /// </summary>
        public bool IsSuper
        {
            get { return _IsSuper; }
            set { _IsSuper = value; }
        }

        private UserType _UType;
        /// <summary>
        /// 用户类型
        /// admin子类规定了usertype，可get不可set，谢明华于8/15更新
        /// </summary>
        new public UserType UType
        {
            get
            {
                _UType = UserType.Admin;
                return _UType;
            }
        }
    }
}