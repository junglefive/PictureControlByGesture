using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureControlByGesture
{


    /// <summary>
    /// 储存数据对x1,x2
    /// </summary>
 public   class Distance
    {

        /// <summary>
        /// 字段
        /// </summary>
        private int x1;
        private int x2;
        private int deltaX;
      
        /// <summary>
        ///X1属性
        /// </summary>
        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        /// <summary>
        /// X2属性
        /// </summary>
        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int DeltaX {

            get { return deltaX; }
            set { deltaX = value; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="x1">参数1，代表到传感器1的距离</param>
        /// <param name="x2">参数2，代表到传感器2的距离<</param>
        public Distance(int x1, int x2) {
            this.x1 = x1;
            this.x2 = x2;
            this.deltaX = x1 - x2;
        }
    }
}
