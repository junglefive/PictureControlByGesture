using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureControlByGesture
{


    /// <summary>
    /// 此类实现对图片路径的管理
    /// </summary>
    class GetPicturePaths
    {
        private List<string> paths;
        private int picCount;

        private int pIndex;
        private int index;
        public int PicCount
        {
            get { return picCount; }
        }

        /// <summary>
        /// 当前索引
        /// </summary>
        public int Index
        {
            get { return index; }
            set { index = value; }

        }
    
        /// <summary>
        /// 获取图片索引
        /// 构造函数
        /// </summary>
        /// <param name="path"></param>
        public GetPicturePaths(string path) {

            index = 0;
            paths = getImgPaths(path);
            picCount = paths.Count;
        }
        /// <summary>
        /// 私有方法，获得图片路径阵列
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private  List<string> getImgPaths(string path)

        {
            string[] imgArray = Directory.GetFiles(path);

            var result = from   imgstring in imgArray
                         where  imgstring.EndsWith("jpg", StringComparison.OrdinalIgnoreCase)||
                                imgstring.EndsWith("png", StringComparison.OrdinalIgnoreCase)||
                                imgstring.EndsWith("bmp", StringComparison.OrdinalIgnoreCase) 
                         select imgstring;
            return result.ToList();
        }

        /// <summary>
        /// 获得下一张图片索引地址
        /// </summary>
        /// <param name="pIndex"></param>
        /// <returns></returns>
        public string getNextPic() {
            if (Index>= picCount-1 || Index < 0)
            {
                Index = 0;
            }
            else
            {
                Index++;
            }
            return paths[Index];
        }

        /// <summary>
        /// 获得上一张图片索引地址
        /// 并更新索引值
        /// </summary>
        /// <param name="pIndex"></param>
        /// <returns></returns>
        public string getPreviousPic()
        {
            if (Index <= 0)
                {                 
                    Index = picCount - 1;            
                }
            else
                {
                     Index--;   
                 }
            return paths[Index];
        }
    

    }
}