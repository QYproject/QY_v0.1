using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ResourceInfo
    {
        private int _ID;
        /// <summary>
        /// 资源ID
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Title;
        /// <summary>
        /// 资源名称
        /// </summary>
        public string Titile
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private int _Size;
        /// <summary>
        /// 资源大小
        /// </summary>
        public int Size
        {
            get { return _Size; }
            set { _Size = value; }
        }

        private bool _IsShow;
        /// <summary>
        /// 是否可见
        /// </summary>
        public bool IsShow
        {
            get { return _IsShow; }
            set { _IsShow = value; }
        }

        private string _Catalog;
        /// <summary>
        /// 资源目录
        /// 备注：这个的数据类型应该会改成catalog对象
        /// </summary>
        public string Catalog
        {
            get { return _Catalog; }
            set { _Catalog = value; }
        }


        private int _CreatorID;
        /// <summary>
        /// 创建者/上传者 ID
        /// </summary>
        public int CreatorID
        {
            get { return _CreatorID; }
            set { _CreatorID = value; }
        }


        private DateTime _UploadDate;
        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime UploadDate
        {
            get { return _UploadDate; }
            set { _UploadDate = value; }
        }

        private string _ResorceUrl;
        /// <summary>
        /// 存放路径
        /// </summary>
        public string ResorceUrl
        {
            get { return _ResorceUrl; }
            set { _ResorceUrl = value; }
        }

        private int _VisitCount;
        /// <summary>
        /// 访问人数
        /// </summary>
        public int VisitCount
        {
            get { return _VisitCount; }
            set { _VisitCount = value; }
        }

        private List<string> _CommentList;
        /// <summary>
        /// 评论列表
        /// </summary>
        public List<string> CommentList
        {
            get { return _CommentList; }
            set { _CommentList = value; }
        }

        private int _TotalScore;
        /// <summary>
        /// 资源总分：所有打分总和
        /// </summary>
        public int TotalScore
        {
            get { return _TotalScore; }
            set { _TotalScore = value; }
        }

        private int _ScoringCount;
        /// <summary>
        /// 评分人数：就是有多少人给它打过分
        /// </summary>
        public int ScoringCount
        {
            get { return _ScoringCount; }
            set { _ScoringCount = value; }
        }

        private double _AvgScore;
        /// <summary>
        /// 平均分
        /// 说明：不可set，由ScoringCount和TotalScore决定
        /// </summary>
        public double AvgScore
        {
            get {
                _AvgScore=(double)TotalScore/ScoringCount;
                return _AvgScore;
            }       
        }

        private string _Remark;
        /// <summary>
        /// 资源备注
        /// </summary>
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }
    }
}
