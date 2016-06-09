using PictureControlByGesture;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureControlByGesture
{
    public partial class FormMain : Form
    {

 
        public FormMain()
        {
            InitializeComponent();

            btnClickFlag.Tag = false;
            this.serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM3";
           // this.serialData = new Queue<int>();
           // this.distancePoint = new Distance(-1, -1);
            this.serialPort.DataReceived += new SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            
        }

        /// <summary>
        /// 点击显示上一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreviouspic_Click(object sender, EventArgs e)
        {
            previousPictureShowing();
        }

        /// <summary>
        /// 点击暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPouse_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击显示下一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextPic_Click(object sender, EventArgs e)
        {
            nextPictureShowing();
        }

        /// <summary>
        /// 点击开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (getPicturePaths == null || getPicturePaths.PicCount <= 0)
            {
                MessageBox.Show("请先选择文件夹", "系统提示");
            }
            else
            {
                try
                {
                    serialPort.Open();
                   // MessageBox.Show("已打开串口", "系统提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("没有发现串口", "系统提示");
                }
               // timerGetDistance.Start();
               // serialPortDistance.Start();
                btnStart.Text = "运行中...";
            }
        }

        /// <summary>
        /// 点击结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            //  timerGetDistance.Stop();
            try { serialPort.Close();
               // MessageBox.Show("已关闭串口", "系统提示");
            }
            catch (Exception ex) {
            }
           
            //  serialPortDistance.Stop();
            btnStart.Text = "开始";
        }

        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseFile_Click(object sender, EventArgs e)
        { 
            if (folderBrowserDialogGetPath.ShowDialog() == DialogResult.OK)
            {
                getPicturePaths = new GetPicturePaths(folderBrowserDialogGetPath.SelectedPath);
                folderBrowserDialogGetPath.Description = "已选择文件夹 " + folderBrowserDialogGetPath.SelectedPath;
                btnChooseFile.Text = folderBrowserDialogGetPath.Description;
                if(getPicturePaths != null || getPicturePaths.PicCount > 0)
                {
                    picShow.Image = Image.FromFile(getPicturePaths.getNextPic());
                }
            }
        }


        /// <summary>
        /// 显示下一张图片
        /// </summary>
        private void nextPictureShowing()
        {
            if (getPicturePaths ==null ||getPicturePaths.PicCount <= 0)
            {
                MessageBox.Show("请先选择文件夹","系统提示");
            }
            else
            {
                if (picShow.Image != null) { picShow.Image.Dispose(); }
                picShow.Image = Image.FromFile(getPicturePaths.getNextPic());

            }
        }

        /// <summary>
        /// 显示上一张图片
        /// </summary>
        private void previousPictureShowing()
        {

            if (getPicturePaths == null || getPicturePaths.PicCount <= 0)
            {
                MessageBox.Show("请先选择文件夹","系统提示");
            }
            else
            {
                if (picShow.Image != null) { picShow.Image.Dispose(); }
                picShow.Image = Image.FromFile(getPicturePaths.getPreviousPic());   
            }
        }

        /// <summary>
        /// 事件响应--串口接收响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //  private Queue<int> serialData;



        private SerialPort serialPort;
        private Distance distancePoint = new Distance(-1,-1);
        private delegate void MyDelegate(Distance dis);
 //       private delegate void MyDelegate(Object sender, MyParameter para);
 //        private event MyDelegate myEvent;


        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //字符串解析为int类型
                int i = int.Parse(serialPort.ReadLine());

                if (10000 < i && i < 20000) {
                    i = i - 10000;
                    if (i > RADIUS) { i = RADIUS; }
                    distancePoint.X1 = i;
                }
                if (i > 20000 && distancePoint.X1 > 0)
                {
                    i = i - 20000;
                    if (i > RADIUS) { i = RADIUS; }
                    distancePoint.X2 = i;
                }
                if (distancePoint.X1 > 0 && distancePoint.X2 > 0) {

                    //                  MyParameter para = new MyParameter(distancePoint);
                    //                   myEvent += new MyDelegate(getGeture);
                    //                    if (myEvent != null) {
                    //
                    //                       myEvent.Invoke(this, para);
                    //
                    //                    }
                    //                    myEvent = null;
                    this.Invoke(new MyDelegate(getGeture), distancePoint);
                    distancePoint.X1 = -1;
                    distancePoint.X2 = -1;                  
                }



            }
            catch (Exception ex) {               };
        }
        //手势检测函数
        //       private void getGeture(Object sender, MyParameter para) 
        private void getGeture(Distance  distance)
        {
            //          Distance distance = para.Distance;

            if (distance != null)
            {

                //Right
                if (distance.X1 == RADIUS && distance.X2 < RADIUS)
                {
                    if (gestureFLAG == RIGHT) { RIGHT_COUNT++; }
                    else if (gestureFLAG == LEFT)
                    {
                        gestureFLAG = NONE;
                        GestureDetected = true;                   
                        //显示xia一张图片
                        //右滑
                        nextPictureShowing();
                        // textBoxTop.Text = "----右滑";

                        txtInfoLeft.AppendText("-[右滑]-\n\n");
                        if (PPTControlFlag == true)
                        {
                            SendKeys.Send("{DOWN}");
                            
                        }
                    }
                    else
                    {
                        gestureFLAG = RIGHT;
                    }
                }
                //Left
                if (distance.X1 < RADIUS && distance.X2 == RADIUS)
                {
                    if (gestureFLAG == LEFT) { LEFT_COUNT++; }
                    else if (gestureFLAG == RIGHT)
                    {
                        gestureFLAG = NONE;
                        GestureDetected = true;
                        //显示s一张图片
                        //左滑
                        previousPictureShowing();
                        txtInfoLeft.AppendText("-[左滑]-\n\n");
                        //                     textBoxTop.Text = "左滑----";
                        
                        if (PPTControlFlag == true)
                        {
                            SendKeys.Send("{UP}");
                        }

                    }
                    else
                    {
                        gestureFLAG = LEFT;

                    }
                }
                //CENTER
                if (distance.X1 < RADIUS && distance.X2 < RADIUS)
                {

                    LEFT_COUNT = 0;
                    RIGHT_COUNT = 0;

                }

                //标志位清空
                //OUT
                if (distance.X1 == RADIUS && distance.X2 == RADIUS)
                {

                    if (GestureDetected == false && ClikFlag == true)
                    {
                        if (LEFT_COUNT > 2)
                        {
                            SendKeys.Send("{TAB}");
                            txtInfoRight.AppendText("-[左击]-\n\n");
                            LEFT_COUNT = 0;
                            RIGHT_COUNT = 0;
                        }
                        if (RIGHT_COUNT > 2)
                        {
                            SendKeys.Send("{ENTER}");
                            txtInfoRight.AppendText("-[右击]-\n\n");
                            LEFT_COUNT = 0;
                            RIGHT_COUNT = 0;
                        }
                    }
                    
                    gestureFLAG = NONE;
                    GestureDetected = false;
                    LEFT_COUNT = 0;
                    RIGHT_COUNT = 0;

                }

                //显示距离
                //Console.WriteLine(distance.X1 + ":" + distance.X2);

                txtLeft.AppendText(distance.X1.ToString() + '\n');
                txtRight.AppendText(distance.X2.ToString() + '\n');
               
                distance = null;
            }
        }
        //------------------//
        private void setLeftText(String str) {

            txtLeft.AppendText(str + "\n");

        }
        private void setRightText(String str)
        {

            txtRight.AppendText(str + "\n");

        }

        /// <summary>
        /// 全局控制开关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnControlPPT_Click(object sender, EventArgs e)
        {
            if (btnControlPPT.Tag.Equals(false)){
                PPTControlFlag = true;
                btnControlPPT.Tag = true;
                btnControlPPT.Text = "已开启,点击关闭";
            }
            else if (btnControlPPT.Tag.Equals(true)) {
                PPTControlFlag = false;
                btnControlPPT.Tag = false;
                btnControlPPT.Text = "PPT控制 ←..→";
            }
            //
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            RADIUS = (int)numericRadius.Value;

        }
        private void btnClickFlag_Click(object sender, EventArgs e)
        {
            if (btnClickFlag.Tag.Equals(false))
            {
                ClikFlag = true;
                btnClickFlag.Tag = true;
                btnClickFlag.Text = "点击ing";
            }
            else {
                ClikFlag = false;
                btnClickFlag.Tag = false;
                btnClickFlag.Text = "开启点击";
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
