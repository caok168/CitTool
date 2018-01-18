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
    public partial class ExportDataBatch : Form
    {
        CitFileProcess.CitFileHelper citHelper;

        //选中的cit文件列表
        private List<String> citSourceCheckFileList = new List<String>();
        //选中的cit文件名称用于保存成txt文件名称
        private List<String> citSourceCheckFileNameList = new List<String>();

        List<CitFileProcess.DataChannelInfo> channelList = new List<CitFileProcess.DataChannelInfo>();
        List<CitFileProcess.DataChannelInfo> channelNameList = new List<CitFileProcess.DataChannelInfo>();

        List<double[]> dataList = new List<double[]>();

        string citfilePath = "";

        public ExportDataBatch()
        {
            InitializeComponent();

            citHelper = new CitFileProcess.CitFileHelper();
        }

        #region Cit文件的功能

        /// <summary>
        /// 浏览选择文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFolderBrowser_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBoxFileDirectory.Text = folderBrowserDialog1.SelectedPath;
            }

            listViewFile.Items.Clear();

            try
            {
                string[] sFiles = Directory.GetFiles(textBoxFileDirectory.Text, "*.cit", SearchOption.TopDirectoryOnly);

                listViewFile.BeginUpdate();
                foreach (string v in sFiles)
                {
                    citfilePath = v;


                    string status = citHelper.QueryDataInfoHead(v);
                    string[] sDataInfoHead = status.Split(new char[] { ',' });
                    // iDataType; sDataVersion; sTrackCode; sTrackName; iDir; 
                    //sTrain; sDate; sTime; iRunDir;iKmInc; 
                    //fkmFrom; fkmTo; iSmaleRate; iChannelNumber;
                    if (sDataInfoHead[0].Contains("0"))
                    {
                        listViewFile.Items.Add(sDataInfoHead[4]);

                        listViewFile.Items[listViewFile.Items.Count - 1].SubItems.Add(sDataInfoHead[3]);
                        listViewFile.Items[listViewFile.Items.Count - 1].SubItems.Add(sDataInfoHead[5]);
                        listViewFile.Items[listViewFile.Items.Count - 1].SubItems.Add(sDataInfoHead[10]);
                        listViewFile.Items[listViewFile.Items.Count - 1].SubItems.Add(sDataInfoHead[7]);
                        listViewFile.Items[listViewFile.Items.Count - 1].SubItems.Add(sDataInfoHead[8]);
                        listViewFile.Items[listViewFile.Items.Count - 1].SubItems.Add(sDataInfoHead[6]);
                        listViewFile.Items[listViewFile.Items.Count - 1].SubItems.Add(Path.GetFileName(v));
                        listViewFile.Items[listViewFile.Items.Count - 1].SubItems.Add((new FileInfo(v)).Length.ToString());
                        listViewFile.Items[listViewFile.Items.Count - 1].SubItems.Add(Path.GetDirectoryName(v));
                    }
                    Application.DoEvents();

                }
                listViewFile.EndUpdate();

                if (citfilePath != "")
                {
                    LoadData(citfilePath);
                }

            }
            catch
            {
                //MessageBox.Show("获取所有文件出错，请检查子目录");
                return;
            }
        }

        /// <summary>
        /// cit文件 全选功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckb_All_CitFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_All_CitFiles.Checked)
            {
                listViewFile.Focus();
                foreach (ListViewItem item in listViewFile.Items)
                {
                    item.Checked = true;
                }
            }
            else
            {
                listViewFile.Focus();
                foreach (ListViewItem item in listViewFile.Items)
                {
                    item.Checked = false;
                }
            }
        }

        delegate void GetCitSourceCheckFileListCallback();
        /// <summary>
        /// 获取选中的cit文件名称列表
        /// </summary>
        private void GetCitSourceCheckFileList()
        {
            if (this.listViewFile.InvokeRequired)
            {
                GetCitSourceCheckFileListCallback d = new GetCitSourceCheckFileListCallback(GetCitSourceCheckFileList);
                this.Invoke(d, new object[] { });
            }
            else
            {
                citSourceCheckFileList.Clear();

                citSourceCheckFileNameList.Clear();

                for (int i = 0; i < listViewFile.CheckedItems.Count; i++)
                {
                    String citFilePath = null;
                    String citFileNameForTxt = null;
                    citFileNameForTxt = "TrackGeometry-" + listViewFile.CheckedItems[i].SubItems[6].Text + "-" + listViewFile.CheckedItems[i].SubItems[0].Text + "-";
                    if (listViewFile.CheckedItems[i].SubItems[2].Text == "上")
                    {
                        citFileNameForTxt += "SX";
                    }
                    else
                    {
                        citFileNameForTxt += "XX";
                    }

                    if (this.txtStartMile.Text.Trim() != "" && this.txtEndMile.Text.Trim() != "")
                    {
                        citFileNameForTxt += "-" + this.txtStartMile.Text.Trim() + "~" + this.txtEndMile.Text.Trim();
                    }

                    citFileNameForTxt += "-" + Convert.ToDateTime(listViewFile.CheckedItems[i].SubItems[4].Text).ToString("yyyyMMdd");
                    
                    if (listViewFile.CheckedItems[i].SubItems[9].Text.EndsWith("\\"))
                    {
                        citFilePath = listViewFile.CheckedItems[i].SubItems[9].Text + listViewFile.CheckedItems[i].SubItems[7].Text;
                    }
                    else
                    {
                        citFilePath = listViewFile.CheckedItems[i].SubItems[9].Text + "\\" + listViewFile.CheckedItems[i].SubItems[7].Text;
                    }
                    citSourceCheckFileList.Add(citFilePath);
                    citSourceCheckFileNameList.Add(citFileNameForTxt);
                }
            }

        }

        #endregion

        #region 通道方面的功能

        
        /// <summary>
        /// 通道全选功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckb_all_channel_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_all_channel.Checked)
            {
                listView1.Focus();
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Checked = true;
                }
            }
            else
            {
                listView1.Focus();
                foreach (ListViewItem item in listView1.Items)
                {
                    item.Checked = false;
                }
            }
        }

        /// <summary>
        /// 导出功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                this.btn_Export.Enabled = false;

                GetCitSourceCheckFileList();

                GetChannelNames();
                if (channelNameList.Count == 0)
                {
                    MessageBox.Show("请选择至少一个通道");
                    return;
                }

                string startMile = this.txtStartMile.Text.Trim();
                string endMile = this.txtEndMile.Text.Trim();

                for (int j = 0; j < citSourceCheckFileList.Count; j++)
                {
                    dataList.Clear();

                    for (int i = 0; i < channelNameList.Count; i++)
                    {
                        if (!String.IsNullOrEmpty(startMile) && !String.IsNullOrEmpty(endMile) && Convert.ToDouble(endMile) > Convert.ToDouble(startMile))
                        {
                            double[] d = citHelper.GetSingleChannelData(citSourceCheckFileList[j], channelNameList[i].sNameEn, Convert.ToDouble(startMile), Convert.ToDouble(endMile));
                            dataList.Add(d);
                        }
                        else
                        {
                            double[] d = citHelper.GetSingleChannelData(citSourceCheckFileList[j], citHelper.GetChannelId(channelNameList[i].sNameEn, citSourceCheckFileList[j]));
                            dataList.Add(d);
                        }
                        
                    }

                    //使用中文名称
                    if (ckb_Chinese.Checked)
                    {
                        if (ckb_sameNameWithCit.Checked)
                        {
                            ExportDataTxt(true, citSourceCheckFileList[j].Replace(".cit", ".txt"));
                        }
                        else
                        {
                            ExportDataTxt(true, citSourceCheckFileNameList[j], citSourceCheckFileList[j]);
                        }
                    }
                    else
                    {
                        if (ckb_sameNameWithCit.Checked)
                        {
                            ExportDataTxt(true, citSourceCheckFileList[j].Replace(".cit", ".txt"));
                        }
                        else
                        {
                            ExportDataTxt(false, citSourceCheckFileNameList[j], citSourceCheckFileList[j]);
                        }
                    }
                }



                MessageBox.Show("数据导出完成");

                this.btn_Export.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        #endregion


        #region 私有方法

        /// <summary>
        /// 加载通道信息
        /// </summary>
        /// <param name="citfilePath"></param>
        private void LoadData(string citfilePath)
        {
            channelList = citHelper.GetDataChannelInfoHead(citfilePath);

            listView1.BeginUpdate();
            foreach (CitFileProcess.DataChannelInfo item in channelList)
            {
                listView1.Items.Add(item.sNameEn);

                listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.sNameCh);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.fScale.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.fOffset.ToString());
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(item.sUnit);
                Application.DoEvents();
            }
            listView1.EndUpdate();
        }

        /// <summary>
        /// 获取选中的通道信息
        /// </summary>
        private void GetChannelNames()
        {
            channelNameList.Clear();

            for (int i = 0; i < listView1.CheckedItems.Count; i++)
            {
                channelNameList.Add(new CitFileProcess.DataChannelInfo { sNameEn = listView1.CheckedItems[i].SubItems[0].Text, sNameCh = listView1.CheckedItems[i].SubItems[1].Text, sUnit = listView1.CheckedItems[i].SubItems[4].Text });
            }
        }

        /// <summary>
        /// 导出数据到txt文件
        /// </summary>
        /// <param name="isChinese"></param>
        /// <param name="filePathStr"></param>
        private void ExportDataTxt(bool isChinese, string filePathStr,string folderPath)
        {

            //string fileName = filePathStr.Substring(filePathStr.LastIndexOf("\\"));
            //string path = Application.StartupPath + fileName.Substring(0, fileName.Length - 4) + ".txt";

            //改变路径放到cit文件的路径下面
            //string path = Application.StartupPath + "\\" + filePathStr + ".txt";
            string path = folderPath.Substring(0, folderPath.LastIndexOf("\\")) + "\\" + filePathStr + ".txt";
            //if (this.txtStartMile.Text.Trim() != "" && this.txtEndMile.Text.Trim() != "")
            //{
            //    path += "-" + this.txtStartMile.Text.Trim() + "~" + this.txtEndMile.Text.Trim();
            //}
            //path += "-" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < channelNameList.Count; i++)
            {
                if (isChinese)
                    sw.Write(channelNameList[i].sNameCh + "(" + channelNameList[i].sUnit + ")");
                else
                    sw.Write(channelNameList[i].sNameEn + "(" + channelNameList[i].sUnit + ")");
                if (i != channelNameList.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.WriteLine();

            int count = 0;
            if (dataList.Count > 0)
                count = dataList[0].Length;

            int kk = 0;
            try
            {
                for (int j = 0; j < count; j++)
                {
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        sw.Write(dataList[i][j]);
                        if (i != dataList.Count - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();

                    kk = j;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }



        private void ExportDataTxt(bool isChinese, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < channelNameList.Count; i++)
            {
                if (isChinese)
                    sw.Write(channelNameList[i].sNameCh + "(" + channelNameList[i].sUnit + ")");
                else
                    sw.Write(channelNameList[i].sNameEn + "(" + channelNameList[i].sUnit + ")");
                if (i != channelNameList.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.WriteLine();

            int count = 0;
            if (dataList.Count > 0)
                count = dataList[0].Length;

            int kk = 0;
            try
            {
                for (int j = 0; j < count; j++)
                {
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        sw.Write(dataList[i][j]);
                        if (i != dataList.Count - 1)
                        {
                            sw.Write(",");
                        }
                    }
                    sw.WriteLine();

                    kk = j;
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

        #endregion

    }
}
