using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 目录类
    /// 作者：吴中阳
    /// </summary>
    public  class CatalogInfo
    {
        private string _CatalogID;
        /// <summary>
        /// 目录ID
        /// </summary>
        public string CatalogID
        {
            get { return _CatalogID; }
            set { _CatalogID = value; }
        }

        private string _Layer2;
        /// <summary>
        /// 第二层目录名称
        /// </summary>
        public string Layer2
        {
            get { return _Layer2; }
            set { _Layer2 = value; }
        }

        private string _Layer2ID;
        /// <summary>
        /// 第二层目录ID
        /// </summary>
        public string Layer2ID
        {
            get { return _Layer2ID; }
            set { _Layer2ID = value; }
        }

        private string _Subject;
        /// <summary>
        /// 课程名称
        /// </summary>
        public string Subject
        {
            get { return _Subject; }
            set { _Subject = value; }
        }

        private string _SubjectID;
        /// <summary>
        /// 课程ID
        /// </summary>
        public string SubjectID
        {
            get { return _SubjectID; }
            set { _SubjectID = value; }
        }

        private bool _IsExtra;
        /// <summary>
        /// 是否课外
        /// </summary>
        public bool IsExtra
        {
            get {
                if (_Layer1 == Layer1Type.课外)
                    _IsExtra = true;
                else
                    _IsExtra = false;
                return _IsExtra;
            }
        }

        public enum Layer1Type
        { 小学,初中,高中,课外}

        private Layer1Type _Layer1;

        public Layer1Type Layer1
        {
            get { return _Layer1; }
        }

          public bool setLayer1(string layer1)
        {
            if (layer1.Equals(Layer1Type.小学.ToString()))
                this._Layer1 = Layer1Type.小学;
            else if (layer1.Equals(Layer1Type.初中.ToString()))
                this._Layer1 = Layer1Type.初中;
            else if (layer1.Equals(Layer1Type.高中.ToString()))
                this._Layer1 = Layer1Type.高中;
            else if (layer1.Equals(Layer1Type.课外.ToString()))
                this._Layer1 = Layer1Type.课外;
            else
                return false;

                return true;
        }
    }
}
