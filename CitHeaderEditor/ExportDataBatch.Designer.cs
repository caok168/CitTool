namespace CitHeaderEditor
{
    partial class ExportDataBatch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFileDirectory = new System.Windows.Forms.TextBox();
            this.buttonFolderBrowser = new System.Windows.Forms.Button();
            this.listViewFile = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxMaxin50M = new System.Windows.Forms.PictureBox();
            this.pictureBoxCalcRMS = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Export = new System.Windows.Forms.Button();
            this.ckb_Chinese = new System.Windows.Forms.CheckBox();
            this.ckb_all_channel = new System.Windows.Forms.CheckBox();
            this.ckb_All_CitFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartMile = new System.Windows.Forms.TextBox();
            this.txtEndMile = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxin50M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalcRMS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFileDirectory);
            this.groupBox1.Controls.Add(this.buttonFolderBrowser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 45);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "路径选择";
            // 
            // textBoxFileDirectory
            // 
            this.textBoxFileDirectory.Location = new System.Drawing.Point(6, 17);
            this.textBoxFileDirectory.Name = "textBoxFileDirectory";
            this.textBoxFileDirectory.Size = new System.Drawing.Size(732, 21);
            this.textBoxFileDirectory.TabIndex = 2;
            // 
            // buttonFolderBrowser
            // 
            this.buttonFolderBrowser.Location = new System.Drawing.Point(765, 15);
            this.buttonFolderBrowser.Name = "buttonFolderBrowser";
            this.buttonFolderBrowser.Size = new System.Drawing.Size(75, 23);
            this.buttonFolderBrowser.TabIndex = 0;
            this.buttonFolderBrowser.Text = "浏览";
            this.buttonFolderBrowser.UseVisualStyleBackColor = true;
            this.buttonFolderBrowser.Click += new System.EventHandler(this.buttonFolderBrowser_Click);
            // 
            // listViewFile
            // 
            this.listViewFile.CheckBoxes = true;
            this.listViewFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewFile.FullRowSelect = true;
            this.listViewFile.GridLines = true;
            this.listViewFile.Location = new System.Drawing.Point(6, 9);
            this.listViewFile.MultiSelect = false;
            this.listViewFile.Name = "listViewFile";
            this.listViewFile.Size = new System.Drawing.Size(848, 264);
            this.listViewFile.TabIndex = 0;
            this.listViewFile.UseCompatibleStateImageBehavior = false;
            this.listViewFile.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "线路名";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "线路代码";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "行别";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "增减里程";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "检测日期";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "检测时间";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "检测车号";
            this.columnHeader7.Width = 78;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "原始文件名";
            this.columnHeader8.Width = 236;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "大小(B)";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "原始路径";
            this.columnHeader10.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckb_All_CitFiles);
            this.groupBox2.Controls.Add(this.pictureBoxMaxin50M);
            this.groupBox2.Controls.Add(this.pictureBoxCalcRMS);
            this.groupBox2.Controls.Add(this.listViewFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 305);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件列表";
            // 
            // pictureBoxMaxin50M
            // 
            this.pictureBoxMaxin50M.Location = new System.Drawing.Point(282, 198);
            this.pictureBoxMaxin50M.Name = "pictureBoxMaxin50M";
            this.pictureBoxMaxin50M.Size = new System.Drawing.Size(309, 69);
            this.pictureBoxMaxin50M.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMaxin50M.TabIndex = 2;
            this.pictureBoxMaxin50M.TabStop = false;
            this.pictureBoxMaxin50M.Visible = false;
            // 
            // pictureBoxCalcRMS
            // 
            this.pictureBoxCalcRMS.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxCalcRMS.Location = new System.Drawing.Point(218, 231);
            this.pictureBoxCalcRMS.Name = "pictureBoxCalcRMS";
            this.pictureBoxCalcRMS.Size = new System.Drawing.Size(411, 36);
            this.pictureBoxCalcRMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCalcRMS.TabIndex = 1;
            this.pictureBoxCalcRMS.TabStop = false;
            this.pictureBoxCalcRMS.Visible = false;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(18, 401);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(419, 337);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "英文名";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "中文名";
            this.columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "通道比例";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "通道基准线";
            this.columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "通道单位";
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(469, 640);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = "导  出";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // ckb_Chinese
            // 
            this.ckb_Chinese.AutoSize = true;
            this.ckb_Chinese.Location = new System.Drawing.Point(469, 591);
            this.ckb_Chinese.Name = "ckb_Chinese";
            this.ckb_Chinese.Size = new System.Drawing.Size(144, 16);
            this.ckb_Chinese.TabIndex = 6;
            this.ckb_Chinese.Text = "通道名称导出为中文名";
            this.ckb_Chinese.UseVisualStyleBackColor = true;
            // 
            // ckb_all_channel
            // 
            this.ckb_all_channel.AutoSize = true;
            this.ckb_all_channel.Location = new System.Drawing.Point(469, 552);
            this.ckb_all_channel.Name = "ckb_all_channel";
            this.ckb_all_channel.Size = new System.Drawing.Size(60, 16);
            this.ckb_all_channel.TabIndex = 5;
            this.ckb_all_channel.Text = "全  选";
            this.ckb_all_channel.UseVisualStyleBackColor = true;
            this.ckb_all_channel.CheckedChanged += new System.EventHandler(this.ckb_all_channel_CheckedChanged);
            // 
            // ckb_All_CitFiles
            // 
            this.ckb_All_CitFiles.AutoSize = true;
            this.ckb_All_CitFiles.Location = new System.Drawing.Point(16, 283);
            this.ckb_All_CitFiles.Name = "ckb_All_CitFiles";
            this.ckb_All_CitFiles.Size = new System.Drawing.Size(54, 16);
            this.ckb_All_CitFiles.TabIndex = 6;
            this.ckb_All_CitFiles.Text = "全 选";
            this.ckb_All_CitFiles.UseVisualStyleBackColor = true;
            this.ckb_All_CitFiles.CheckedChanged += new System.EventHandler(this.ckb_All_CitFiles_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "起始里程：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "结束里程：";
            // 
            // txtStartMile
            // 
            this.txtStartMile.Location = new System.Drawing.Point(540, 473);
            this.txtStartMile.Name = "txtStartMile";
            this.txtStartMile.Size = new System.Drawing.Size(100, 21);
            this.txtStartMile.TabIndex = 10;
            // 
            // txtEndMile
            // 
            this.txtEndMile.Location = new System.Drawing.Point(540, 509);
            this.txtEndMile.Name = "txtEndMile";
            this.txtEndMile.Size = new System.Drawing.Size(100, 21);
            this.txtEndMile.TabIndex = 11;
            // 
            // ExportDataBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 758);
            this.Controls.Add(this.txtEndMile);
            this.Controls.Add(this.txtStartMile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.ckb_Chinese);
            this.Controls.Add(this.ckb_all_channel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExportDataBatch";
            this.Text = "批量导出";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaxin50M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalcRMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxFileDirectory;
        private System.Windows.Forms.Button buttonFolderBrowser;
        private System.Windows.Forms.ListView listViewFile;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxMaxin50M;
        private System.Windows.Forms.PictureBox pictureBoxCalcRMS;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.CheckBox ckb_All_CitFiles;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.CheckBox ckb_Chinese;
        private System.Windows.Forms.CheckBox ckb_all_channel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartMile;
        private System.Windows.Forms.TextBox txtEndMile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}