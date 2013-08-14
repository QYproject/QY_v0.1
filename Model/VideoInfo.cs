using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class VideoInfo:ResourceInfo
    {
        private string _CoverUrl;
        /// <summary>
        /// 视频封面的URL
        /// </summary>
        public string CoverUrl
        {
            get { return _CoverUrl; }
            set { _CoverUrl = value; }
        }

        private int _Size;
        /// <summary>
        /// 文档资料大小
        /// 说明：不能超过最大值
        /// </summary>
        new public int Size
        {
            get { return _Size; }
            set
            {     _Size = value;  }
        }

        private bool _IsVideo;
        /// <summary>
        /// 是否视频
        /// </summary>
        new  public bool IsVideo
        {
            get { return true; }
        }
    }
}
