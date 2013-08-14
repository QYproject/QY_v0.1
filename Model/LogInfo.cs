using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 日志类
    /// 作者：吴中阳
    /// </summary>
    class LogInfo
    {
        private int _LogID;
        /// <summary>
        /// 日志ID
        /// </summary>
        public int LogID
        {
            get { return _LogID; }
            set { _LogID = value; }
        }

        private string _SqlSentence;
        /// <summary>
        /// sql语句
        /// </summary>
        public string SqlSentence
        {
            get { return _SqlSentence; }
            set { _SqlSentence = value; }
        }


        private int _ExecutorID;
        /// <summary>
        /// 操作者
        /// </summary>
        public int ExecutorID
        {
            get { return _ExecutorID; }
            set { _ExecutorID = value; }
        }


        private DateTime _ExecuteTime;
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime ExecuteTime
        {
            get { return _ExecuteTime; }
            set { _ExecuteTime = value; }
        }


        private string _Explain;
        /// <summary>
        /// 注释
        /// </summary>
        public string Explain
        {
            get { return _Explain; }
            set { _Explain = value; }
        }
    }
}
