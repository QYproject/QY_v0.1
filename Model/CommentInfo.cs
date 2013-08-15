using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class CommentInfo
    {
        private string _ID;
        /// <summary>
        /// 该评论ID
        /// </summary>
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }


        private string _ResourceID;
        /// <summary>
        /// 被评论的资源ID
        /// </summary>
        public string ResourceID
        {
            get { return _ResourceID; }
            set { _ResourceID = value; }
        }


        private string _UserID;
        /// <summary>
        /// 评论者ID
        /// </summary>
        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }


        private UserType _UType;
        /// <summary>
        /// 评论者类型
        /// </summary>
        public UserType UType
        {
            get { return _UType; }
            set { _UType = value; }
        }
    }
}
