using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CitFileProcess;
using System.IO;

namespace CitHeaderEditor
{
    public partial class ExportData : Form
    {
        public string filePathStr = "";
        List<DataChannelInfo> channelList = new List<DataChannelInfo>();

        List<DataChannelInfo> channelNameList = new List<DataChannelInfo>();

        List<double[]> dataList = new List<double[]>();

        public ExportData()
        {
            InitializeComponent();
        }

        public ExportData(List<DataChannelInfo> mChannelInfos, string mCitFileName)
        {
            InitializeComponent();
            channelList = mChannelInfos;
            filePathStr = mCitFileName;
        }


        private void ExportData_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// 导出通道数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                this.btn_Export.Enabled = false;

                GetChannelNames();
                if (channelNameList.Count == 0)
                {
                    MessageBox.Show("请选择至少一个通道");
                    return;
                }

                dataList.Clear();

                for (int i = 0; i < channelNameList.Count; i++)
                {
                    CitFileHelper citHelper = new CitFileHelper();
                    double[] d = citHelper.GetSingleChannelData(filePathStr, citHelper.GetChannelId(channelNameList[i].sNameEn, filePathStr));
                    dataList.Add(d);
                }

                //使用中文名称
                if (ckb_Chinese.Checked)
                {
                    ExportDataTxt(true);
                }
                else
                {
                    ExportDataTxt(false);
                }

                MessageBox.Show("数据导出完成");

                this.btn_Export.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 点击全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_all.Checked)
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
        /// 获取选中的通道信息
        /// </summary>
        private void GetChannelNames()
        {
            channelNameList.Clear();

            for (int i = 0; i < listView1.CheckedItems.Count; i++)
            {
                channelNameList.Add(new DataChannelInfo { sNameEn = listView1.CheckedItems[i].SubItems[0].Text, sNameCh = listView1.CheckedItems[i].SubItems[1].Text, sUnit = listView1.CheckedItems[i].SubItems[4].Text });
            }
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        private void LoadData()
        {

            listView1.BeginUpdate();
            foreach (DataChannelInfo item in channelList)
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


        private void ExportDataTxt(bool isChinese)
        {

            string fileName = filePathStr.Substring(filePathStr.LastIndexOf("\\"));
            string path = Application.StartupPath + fileName.Substring(0, fileName.Length - 4) + ".txt";

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
            }
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }

    }
}
