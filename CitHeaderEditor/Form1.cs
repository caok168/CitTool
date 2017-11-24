using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CitHeaderEditor
{
    public partial class Form1 : Form
    {

        DataHeadInfo mDhi = new DataHeadInfo();
        List<DataChannelInfo> mChannelInfos = new List<DataChannelInfo>();
        string mCitFileName;
        Timer mTimer = new Timer();

        public Form1()
        {
            InitializeComponent();

            mTimer.Interval = 2000;
            mTimer.Tick += TimerTimeOut;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择一个cit文件";
            fileDialog.Filter = "所有文件(*.*)|*.cit";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                mCitFileName = fileDialog.FileName;

                // 设置label currentcitfile的值：
                currentcitfile.Text = "当前cit文件是: " + mCitFileName;
                currentcitfile.Visible = true;

                // 解析cit文件的头部信息
                ReadCit(mCitFileName);
            }
        }

        public void ReadCit(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (BinaryReader br = new BinaryReader(fs, Encoding.Default))
                {
                    br.BaseStream.Position = 0;
                    GetDataInfoHead(br.ReadBytes(120));
                    GetChannelInfo(br.ReadBytes(mDhi.iChannelNumber * 65));

                    ShowCitDataToForm();

                    br.Close();
                }

                
                fs.Close();
            }
        }

        #region 按照文件头结构体的读取各个数据
        /// <summary>
        /// 读取cit文件头中的文件信息信息，并返回文件头信息结构体
        /// </summary>
        /// <param name="bDataInfo">文件头中包含文件信息的120个字节 </param>
        /// <returns>文件信息结构体</returns>
        public void GetDataInfoHead(byte[] bDataInfo)
        { 
            StringBuilder sbDataVersion = new StringBuilder();
            StringBuilder sbTrackCode = new StringBuilder();
            StringBuilder sbTrackName = new StringBuilder();
            StringBuilder sbTrain = new StringBuilder();
            StringBuilder sbDate = new StringBuilder();
            StringBuilder sbTime = new StringBuilder();

            //数据类型
            mDhi.iDataType = BitConverter.ToInt32(bDataInfo, 0); //iDataType：1轨检、2动力学、3弓网，

            //1+20个字节，数据版本
            for (int i = 1; i <= (int)bDataInfo[4]; i++)
            {
                sbDataVersion.Append(UnicodeEncoding.Default.GetString(bDataInfo, 4 + i, 1));
            }
            //1+4个字节，线路代码
            for (int i = 1; i <= (int)bDataInfo[25]; i++)
            {
                sbTrackCode.Append(UnicodeEncoding.Default.GetString(bDataInfo, 25 + i, 1));
            }
            //1+20个字节，线路名
            for (int i = 1; i <= (int)bDataInfo[30]; i++)
            {
                sbTrackName.Append(UnicodeEncoding.Default.GetString(bDataInfo, 30 + i, 1));
            }

            //检测方向
            mDhi.iDir = BitConverter.ToInt32(bDataInfo, 51);

            //1+20个字节，检测车号
            for (int i = 1; i <= (int)bDataInfo[55]; i++)
            {
                sbTrain.Append(UnicodeEncoding.Default.GetString(bDataInfo, 55 + i, 1));
            }
            //1+10个字节，检测日期
            for (int i = 1; i <= (int)bDataInfo[76]; i++)
            {
                sbDate.Append(UnicodeEncoding.Default.GetString(bDataInfo, 76 + i, 1));
            }
            //1+8个字节，检测时间
            for (int i = 1; i <= (int)bDataInfo[87]; i++)
            {
                sbTime.Append(UnicodeEncoding.Default.GetString(bDataInfo, 87 + i, 1));
            }

            mDhi.iRunDir = BitConverter.ToInt32(bDataInfo, 96);
            mDhi.iKmInc = BitConverter.ToInt32(bDataInfo, 100);
            mDhi.fkmFrom = BitConverter.ToSingle(bDataInfo, 104);
            mDhi.fkmTo = BitConverter.ToSingle(bDataInfo, 108);
            mDhi.iSmaleRate = BitConverter.ToInt32(bDataInfo, 112);
            mDhi.iChannelNumber = BitConverter.ToInt32(bDataInfo, 116);
            mDhi.sDataVersion = sbDataVersion.ToString();
            mDhi.sDate = DateTime.Parse(sbDate.ToString()).ToString("yyyy-MM-dd");
            mDhi.sTime = DateTime.Parse(sbTime.ToString()).ToString("HH:mm:ss");
            mDhi.sTrackCode = sbTrackCode.ToString();
            mDhi.sTrackName = sbTrackName.ToString();
            mDhi.sTrain = sbTrain.ToString();

            
        }
        #endregion

        private void GetChannelInfo(byte[] bDataInfo)
        {
            mChannelInfos.Clear();

            for (int i = 0; i < bDataInfo.Length; i += 65)
            {
                DataChannelInfo dci = new DataChannelInfo();
                StringBuilder sUnit = new StringBuilder();


                dci.sID = BitConverter.ToInt32(bDataInfo, i);//通道起点为0，导致通道id取的都是第一个通道的id，把0改为start，
                //1+20   通道英文名
                dci.sNameEn = UnicodeEncoding.Default.GetString(bDataInfo, 4 + 1 + i, (int)bDataInfo[4 + i]);
                //1+20    通道中文名
                dci.sNameCh = UnicodeEncoding.Default.GetString(bDataInfo, 25 + 1 + i, (int)bDataInfo[25 + i]);
                //通道单位 1+10
                for (int j = 1; j <= (int)bDataInfo[54 + i]; j++)
                {
                    sUnit.Append(UnicodeEncoding.Default.GetString(bDataInfo, 54 + j + i, 1));
                }
                dci.sUnit = sUnit.ToString();

                //4  通道比例
                dci.fScale = BitConverter.ToSingle(bDataInfo, 46 + i);
                //4   通道基线值
                dci.fOffset = BitConverter.ToSingle(bDataInfo, 50 + i);

                mChannelInfos.Add(dci);
            }
        }

        private void ShowCitDataToForm()
        {
            datatypevalue.Text = mDhi.iDataType.ToString();
            datatypevalue.Visible = true;

            dataversionvalue.Text = mDhi.sDataVersion;
            dataversionvalue.Visible = true;

            trackcodevalue.Text = mDhi.sTrackCode;
            trackcodevalue.Visible = true;

            tracknamevalue.Text = mDhi.sTrackName;
            tracknamevalue.Visible = true;

            dirvalue.Text = mDhi.iDir.ToString();
            dirvalue.Visible = true;

            traincodevalue.Text = mDhi.sTrain;
            traincodevalue.Visible = true;

            datevalue.Text = mDhi.sDate;
            datevalue.Visible = true;

            timevalue.Text = mDhi.sTime;
            timevalue.Visible = true;

            rundirvalue.Text = mDhi.iRunDir.ToString();
            rundirvalue.Visible = true;

            kmincvalue.Text = mDhi.iKmInc.ToString() ;
            kmincvalue.Visible = true;

            kmfromvalue.Text = mDhi.fkmFrom.ToString();
            kmfromvalue.Visible = true;

            kmtovalue.Text = mDhi.fkmTo.ToString();
            kmtovalue.Visible = true;

            smaleratevalue.Text = mDhi.iSmaleRate.ToString();
            smaleratevalue.Visible = true;

            channelnumbervalue.Text = mDhi.iChannelNumber.ToString();
            channelnumbervalue.Visible = true;

            //显示更新有关的按钮和input box
            button2.Visible = true;
            datatypenewvalue.Visible = true;
            dataversionnewvalue.Visible = true;
            trackcodenewvalue.Visible = true;
            tracknamenewvalue.Visible = true;
            dirnewvalue.Visible = true;
            traincodenewvalue.Visible = true;
            datenewvalue.Visible = true;
            timenewvalue.Visible = true;
            rundirnewvalue.Visible = true;
            kmincnewvalue.Visible = true;
            kmfromnewvalue.Visible = true;
            kmtonewvalue.Visible = true;
            smaleratenewvalue.Visible = true;
            

            string channelinfosstr = "当前cit文件一共有" + mChannelInfos.Count.ToString()+"个通道:\n\n";

            for(int i=0;i<mChannelInfos.Count;++i)
            {
                channelinfosstr += "[" + mChannelInfos[i].sID.ToString() + "]\n";
                channelinfosstr += "英文名: " + mChannelInfos[i].sNameEn  + "\n";
                channelinfosstr += "中文名: " + mChannelInfos[i].sNameCh + "\n";
                channelinfosstr += "通道比例(fScale): " + mChannelInfos[i].fScale.ToString() + "\n";
                channelinfosstr += "通道基线值(fOffset): " + mChannelInfos[i].fOffset.ToString() + "\n";
                channelinfosstr += "通道单位(sUnit): " + mChannelInfos[i].sUnit + "\n\n";
            }

            richTextBox1.Text = channelinfosstr;
            richTextBox1.Visible = true;
        }

        private void WriteStringEnding(BinaryWriter bw, int num)
        {
            for (int i = 0; i < num; ++i)
            {
                bw.Write("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = "";
            bool updated = false;
            using (FileStream fsFile = new FileStream(mCitFileName, FileMode.Open, FileAccess.Write, FileShare.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fsFile, Encoding.Default))
                {
                    bw.BaseStream.Position = 0;

                    // data type
                    tmp = datatypenewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        //byte[] b = BitConverter.GetBytes(int.Parse(tmp));
                        bw.Write(int.Parse(tmp));
                        updated = true;
                    }
                    // data version
                    bw.BaseStream.Position = 4;
                    tmp = dataversionnewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write((byte)tmp.Length);  
                        bw.Write(tmp.ToCharArray());
                        updated = true;
                    }
                    // track code
                    bw.BaseStream.Position = 25;
                    tmp = trackcodenewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write((byte)tmp.Length);
                        bw.Write(tmp.ToCharArray());
                        WriteStringEnding(bw, trackcodenewvalue.MaxLength - tmp.Length);
                        updated = true;
                    }
                    // track name
                    bw.BaseStream.Position = 30;
                    tmp = tracknamenewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write((byte)tmp.Length);
                        bw.Write(tmp.ToCharArray());
                        WriteStringEnding(bw, tracknamenewvalue.MaxLength - tmp.Length);
                        updated = true;
                    }
                    //dir
                    bw.BaseStream.Position = 51;
                    tmp = dirnewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write(int.Parse(tmp));
                        updated = true;
                    }
                    //train code
                    bw.BaseStream.Position = 55;
                    tmp = traincodenewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write((byte)tmp.Length);
                        bw.Write(tmp.ToCharArray());
                        updated = true;
                    }
                    //date
                    bw.BaseStream.Position = 76;
                    tmp = datenewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write((byte)tmp.Length);
                        bw.Write(tmp.ToCharArray());
                        updated = true;
                    }
                    //time
                    bw.BaseStream.Position = 87;
                    tmp = timenewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write((byte)tmp.Length);
                        bw.Write(tmp.ToCharArray());
                        updated = true;
                    }
                    // run dir
                    bw.BaseStream.Position = 96;
                    tmp = rundirnewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write(int.Parse(tmp));
                        updated = true;
                    }
                    //km inc
                    bw.BaseStream.Position = 100;
                    tmp = kmincnewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write(int.Parse(tmp));
                        updated = true;
                    }
                    //km from
                    bw.BaseStream.Position = 104;
                    tmp = kmfromnewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write(float.Parse(tmp));
                        updated = true;
                    }
                    //km to
                    bw.BaseStream.Position = 108;
                    tmp = kmtonewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write(float.Parse(tmp));
                        updated = true;
                    }
                    //smale rate
                    bw.BaseStream.Position = 112;
                    tmp = smaleratenewvalue.Text.Trim();
                    if (!tmp.Equals(""))
                    {
                        bw.Write(int.Parse(tmp));
                        updated = true;
                    }
                    

                    bw.Close();
                }

                fsFile.Close();  
            }

            if (updated)
            {
                mTimer.Stop();
                mTimer.Start();
                timedlabel.Visible = true;

                //更新完了重新把文件加载一下
                ReadCit(mCitFileName);
            }
        }

        private void TimerTimeOut(object sender, EventArgs e)
        {
            timedlabel.Visible = false;
        }

        /// <summary>
        /// 弹出导出数据对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ExportData_Click(object sender, EventArgs e)
        {
            ExportData export = new ExportData(mChannelInfos, mCitFileName);
            export.Show();
        }

        /// <summary>
        /// 弹出批量导出数据对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ExportDataBatch_Click(object sender, EventArgs e)
        {
            ExportDataBatch export = new ExportDataBatch();
            export.ShowDialog();
        }
    }

    


    #region CIT文件头信息结构体
    /// <summary>
    /// CIT文件头信息结构体，120字节
    /// </summary>
    public struct DataHeadInfo
    {
        #region 数据类型
        /// <summary>
        /// iDataType：1轨检、2动力学、3弓网----4个字节
        /// </summary>
        public int iDataType;
        #endregion
        #region 文件版本号
        /// <summary>
        /// 文件版本号，用X.X.X表示 第一位大于等于3代表加密后,只加密数据块部分---1+20个字节，第一个字节表示实际长度，以下类同
        /// </summary>
        public string sDataVersion;
        #endregion
        #region 线路代码
        /// <summary>
        /// 线路代码，同PWMIS----1+4个字节
        /// </summary>
        public string sTrackCode;
        #endregion
        #region 线路名
        /// <summary>
        /// 线路名 中文线路名---1+20个字节
        /// </summary>
        public string sTrackName;
        #endregion
        #region 行别
        /// <summary>
        /// 行别：1上行、2下行、3单线----4个字节
        /// </summary>
        public int iDir;
        #endregion
        #region 检测车号
        /// <summary>
        /// 检测车号，不足补空格---1+20个字节
        /// </summary>
        public string sTrain;
        #endregion
        #region 检测日期
        /// <summary>
        /// 检测日期：yyyy-MM-dd---1+10个字节
        /// </summary>
        public string sDate;
        #endregion
        #region 检测起始时间
        /// <summary>
        /// 检测起始时间：HH:mm:ss---1+8个字节
        /// </summary>
        public string sTime;
        #endregion
        #region 检测方向
        /// <summary>
        /// 检测方向，正0，反1----4个字节
        /// </summary>
        public int iRunDir;
        #endregion
        #region 增里程0，减里程1
        /// <summary>
        /// 增里程0，减里程1----4个字节
        /// </summary>
        public int iKmInc;
        #endregion
        #region 开始里程
        /// <summary>
        /// 开始里程----4个字节
        /// </summary>
        public float fkmFrom;
        #endregion
        #region 结束里程
        /// <summary>
        /// 结束里程，检测结束后更新----4个字节
        /// </summary>
        public float fkmTo;
        #endregion
        #region 采样数，（距离采样>0, 时间采样<0
        /// <summary>
        /// 采样数，（距离采样>0, 时间采样<0）----4个字节
        /// </summary>
        public int iSmaleRate;
        #endregion
        #region 数据块中通道总数
        /// <summary>
        /// 数据块中通道总数----4个字节
        /// </summary>
        public int iChannelNumber;
        #endregion
    }
    #endregion

    public class DataChannelInfo
    {
        #region 通道Id
        /// <summary>
        /// 通道Id：轨检通道从1～1000定义；动力学从1001~2000；弓网从2001~3000-----4个字节
        /// </summary>
        public int sID;
        #endregion
        #region 通道名称英文
        /// <summary>
        /// 通道名称英文，不足补空格-----1+20个字节
        /// </summary>
        public string sNameEn;
        #endregion
        #region 通道名称中文
        /// <summary>
        /// 通道名称中文，不足补空格-----1+20个字节
        /// </summary>
        public string sNameCh;
        #endregion
        #region 通道比例
        /// <summary>
        /// 通道比例-----4个字节
        /// </summary>
        public float fScale;
        #endregion
        #region 通道基线值
        /// <summary>
        /// 通道基线值-----4个字节
        /// </summary>
        public float fOffset;
        #endregion
        #region 通道单位
        /// <summary>
        /// 通道单位，不足补空格-----1+10个字节
        /// </summary>
        public string sUnit;
        #endregion

    }

}
