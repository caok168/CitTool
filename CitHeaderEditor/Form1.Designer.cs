namespace CitHeaderEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.datatype = new System.Windows.Forms.Label();
            this.dataversion = new System.Windows.Forms.Label();
            this.trackcode = new System.Windows.Forms.Label();
            this.trackname = new System.Windows.Forms.Label();
            this.dir = new System.Windows.Forms.Label();
            this.traincode = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.rundir = new System.Windows.Forms.Label();
            this.kminc = new System.Windows.Forms.Label();
            this.kmfrom = new System.Windows.Forms.Label();
            this.kmto = new System.Windows.Forms.Label();
            this.smalerate = new System.Windows.Forms.Label();
            this.channelnum = new System.Windows.Forms.Label();
            this.currentcitfile = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datatypevalue = new System.Windows.Forms.Label();
            this.dataversionvalue = new System.Windows.Forms.Label();
            this.trackcodevalue = new System.Windows.Forms.Label();
            this.tracknamevalue = new System.Windows.Forms.Label();
            this.dirvalue = new System.Windows.Forms.Label();
            this.traincodevalue = new System.Windows.Forms.Label();
            this.datevalue = new System.Windows.Forms.Label();
            this.timevalue = new System.Windows.Forms.Label();
            this.rundirvalue = new System.Windows.Forms.Label();
            this.kmincvalue = new System.Windows.Forms.Label();
            this.kmfromvalue = new System.Windows.Forms.Label();
            this.kmtovalue = new System.Windows.Forms.Label();
            this.smaleratevalue = new System.Windows.Forms.Label();
            this.channelnumbervalue = new System.Windows.Forms.Label();
            this.datatypenewvalue = new System.Windows.Forms.TextBox();
            this.dataversionnewvalue = new System.Windows.Forms.TextBox();
            this.trackcodenewvalue = new System.Windows.Forms.TextBox();
            this.tracknamenewvalue = new System.Windows.Forms.TextBox();
            this.dirnewvalue = new System.Windows.Forms.TextBox();
            this.traincodenewvalue = new System.Windows.Forms.TextBox();
            this.datenewvalue = new System.Windows.Forms.TextBox();
            this.timenewvalue = new System.Windows.Forms.TextBox();
            this.rundirnewvalue = new System.Windows.Forms.TextBox();
            this.kmincnewvalue = new System.Windows.Forms.TextBox();
            this.kmfromnewvalue = new System.Windows.Forms.TextBox();
            this.kmtonewvalue = new System.Windows.Forms.TextBox();
            this.smaleratenewvalue = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timedlabel = new System.Windows.Forms.Label();
            this.btn_ExportData = new System.Windows.Forms.Button();
            this.btn_ExportDataBatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datatype
            // 
            this.datatype.AutoSize = true;
            this.datatype.Location = new System.Drawing.Point(12, 67);
            this.datatype.Name = "datatype";
            this.datatype.Size = new System.Drawing.Size(215, 12);
            this.datatype.TabIndex = 0;
            this.datatype.Text = "文件类型(1 轨检, 2 动力学, 3 弓网):";
            // 
            // dataversion
            // 
            this.dataversion.AutoSize = true;
            this.dataversion.Location = new System.Drawing.Point(12, 103);
            this.dataversion.Name = "dataversion";
            this.dataversion.Size = new System.Drawing.Size(227, 12);
            this.dataversion.TabIndex = 1;
            this.dataversion.Text = "文件版本号(20个字符以内，例如 x.x.x):";
            // 
            // trackcode
            // 
            this.trackcode.AutoSize = true;
            this.trackcode.Location = new System.Drawing.Point(12, 141);
            this.trackcode.Name = "trackcode";
            this.trackcode.Size = new System.Drawing.Size(137, 12);
            this.trackcode.TabIndex = 2;
            this.trackcode.Text = "线路代码(4个字符以内):";
            // 
            // trackname
            // 
            this.trackname.AutoSize = true;
            this.trackname.Location = new System.Drawing.Point(12, 179);
            this.trackname.Name = "trackname";
            this.trackname.Size = new System.Drawing.Size(131, 12);
            this.trackname.TabIndex = 3;
            this.trackname.Text = "线路名(20个字符以内):";
            // 
            // dir
            // 
            this.dir.AutoSize = true;
            this.dir.Location = new System.Drawing.Point(12, 218);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(179, 12);
            this.dir.TabIndex = 4;
            this.dir.Text = "行别(1 上行, 2 下行, 3 单线):";
            // 
            // traincode
            // 
            this.traincode.AutoSize = true;
            this.traincode.Location = new System.Drawing.Point(12, 259);
            this.traincode.Name = "traincode";
            this.traincode.Size = new System.Drawing.Size(143, 12);
            this.traincode.TabIndex = 5;
            this.traincode.Text = "检测车号(20个字符以内):";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(12, 304);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(131, 12);
            this.date.TabIndex = 6;
            this.date.Text = "检测日期(yyyy-mm-dd):";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(12, 353);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(143, 12);
            this.time.TabIndex = 7;
            this.time.Text = "检测起始时间(hh:mm:ss):";
            // 
            // rundir
            // 
            this.rundir.AutoSize = true;
            this.rundir.Location = new System.Drawing.Point(12, 400);
            this.rundir.Name = "rundir";
            this.rundir.Size = new System.Drawing.Size(131, 12);
            this.rundir.TabIndex = 8;
            this.rundir.Text = "检测方向(正 0, 反 1):";
            // 
            // kminc
            // 
            this.kminc.AutoSize = true;
            this.kminc.Location = new System.Drawing.Point(12, 449);
            this.kminc.Name = "kminc";
            this.kminc.Size = new System.Drawing.Size(179, 12);
            this.kminc.TabIndex = 9;
            this.kminc.Text = "增减里程(0 增里程, 1 减里程):";
            // 
            // kmfrom
            // 
            this.kmfrom.AutoSize = true;
            this.kmfrom.Location = new System.Drawing.Point(12, 497);
            this.kmfrom.Name = "kmfrom";
            this.kmfrom.Size = new System.Drawing.Size(59, 12);
            this.kmfrom.TabIndex = 10;
            this.kmfrom.Text = "起始里程:";
            // 
            // kmto
            // 
            this.kmto.AutoSize = true;
            this.kmto.Location = new System.Drawing.Point(12, 539);
            this.kmto.Name = "kmto";
            this.kmto.Size = new System.Drawing.Size(59, 12);
            this.kmto.TabIndex = 11;
            this.kmto.Text = "结束里程:";
            // 
            // smalerate
            // 
            this.smalerate.AutoSize = true;
            this.smalerate.Location = new System.Drawing.Point(12, 586);
            this.smalerate.Name = "smalerate";
            this.smalerate.Size = new System.Drawing.Size(191, 12);
            this.smalerate.TabIndex = 12;
            this.smalerate.Text = "采样数(距离采样>0, 时间采样<0):";
            // 
            // channelnum
            // 
            this.channelnum.AutoSize = true;
            this.channelnum.Location = new System.Drawing.Point(12, 634);
            this.channelnum.Name = "channelnum";
            this.channelnum.Size = new System.Drawing.Size(107, 12);
            this.channelnum.TabIndex = 13;
            this.channelnum.Text = "数据块中通道总数:";
            // 
            // currentcitfile
            // 
            this.currentcitfile.AutoSize = true;
            this.currentcitfile.Location = new System.Drawing.Point(12, 713);
            this.currentcitfile.Name = "currentcitfile";
            this.currentcitfile.Size = new System.Drawing.Size(41, 12);
            this.currentcitfile.TabIndex = 14;
            this.currentcitfile.Text = "label1";
            this.currentcitfile.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "打开cit文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datatypevalue
            // 
            this.datatypevalue.AutoSize = true;
            this.datatypevalue.Location = new System.Drawing.Point(321, 67);
            this.datatypevalue.Name = "datatypevalue";
            this.datatypevalue.Size = new System.Drawing.Size(41, 12);
            this.datatypevalue.TabIndex = 16;
            this.datatypevalue.Text = "label1";
            this.datatypevalue.Visible = false;
            // 
            // dataversionvalue
            // 
            this.dataversionvalue.AutoSize = true;
            this.dataversionvalue.Location = new System.Drawing.Point(321, 103);
            this.dataversionvalue.Name = "dataversionvalue";
            this.dataversionvalue.Size = new System.Drawing.Size(41, 12);
            this.dataversionvalue.TabIndex = 17;
            this.dataversionvalue.Text = "label1";
            this.dataversionvalue.Visible = false;
            // 
            // trackcodevalue
            // 
            this.trackcodevalue.AutoSize = true;
            this.trackcodevalue.Location = new System.Drawing.Point(321, 141);
            this.trackcodevalue.Name = "trackcodevalue";
            this.trackcodevalue.Size = new System.Drawing.Size(41, 12);
            this.trackcodevalue.TabIndex = 18;
            this.trackcodevalue.Text = "label1";
            this.trackcodevalue.Visible = false;
            // 
            // tracknamevalue
            // 
            this.tracknamevalue.AutoSize = true;
            this.tracknamevalue.Location = new System.Drawing.Point(321, 179);
            this.tracknamevalue.Name = "tracknamevalue";
            this.tracknamevalue.Size = new System.Drawing.Size(41, 12);
            this.tracknamevalue.TabIndex = 19;
            this.tracknamevalue.Text = "label1";
            this.tracknamevalue.Visible = false;
            // 
            // dirvalue
            // 
            this.dirvalue.AutoSize = true;
            this.dirvalue.Location = new System.Drawing.Point(321, 218);
            this.dirvalue.Name = "dirvalue";
            this.dirvalue.Size = new System.Drawing.Size(41, 12);
            this.dirvalue.TabIndex = 20;
            this.dirvalue.Text = "label1";
            this.dirvalue.Visible = false;
            // 
            // traincodevalue
            // 
            this.traincodevalue.AutoSize = true;
            this.traincodevalue.Location = new System.Drawing.Point(321, 259);
            this.traincodevalue.Name = "traincodevalue";
            this.traincodevalue.Size = new System.Drawing.Size(41, 12);
            this.traincodevalue.TabIndex = 21;
            this.traincodevalue.Text = "label1";
            this.traincodevalue.Visible = false;
            // 
            // datevalue
            // 
            this.datevalue.AutoSize = true;
            this.datevalue.Location = new System.Drawing.Point(321, 304);
            this.datevalue.Name = "datevalue";
            this.datevalue.Size = new System.Drawing.Size(41, 12);
            this.datevalue.TabIndex = 22;
            this.datevalue.Text = "label1";
            this.datevalue.Visible = false;
            // 
            // timevalue
            // 
            this.timevalue.AutoSize = true;
            this.timevalue.Location = new System.Drawing.Point(321, 353);
            this.timevalue.Name = "timevalue";
            this.timevalue.Size = new System.Drawing.Size(41, 12);
            this.timevalue.TabIndex = 23;
            this.timevalue.Text = "label1";
            this.timevalue.Visible = false;
            // 
            // rundirvalue
            // 
            this.rundirvalue.AutoSize = true;
            this.rundirvalue.Location = new System.Drawing.Point(321, 400);
            this.rundirvalue.Name = "rundirvalue";
            this.rundirvalue.Size = new System.Drawing.Size(41, 12);
            this.rundirvalue.TabIndex = 24;
            this.rundirvalue.Text = "label1";
            this.rundirvalue.Visible = false;
            // 
            // kmincvalue
            // 
            this.kmincvalue.AutoSize = true;
            this.kmincvalue.Location = new System.Drawing.Point(321, 449);
            this.kmincvalue.Name = "kmincvalue";
            this.kmincvalue.Size = new System.Drawing.Size(41, 12);
            this.kmincvalue.TabIndex = 25;
            this.kmincvalue.Text = "label1";
            this.kmincvalue.Visible = false;
            // 
            // kmfromvalue
            // 
            this.kmfromvalue.AutoSize = true;
            this.kmfromvalue.Location = new System.Drawing.Point(321, 497);
            this.kmfromvalue.Name = "kmfromvalue";
            this.kmfromvalue.Size = new System.Drawing.Size(41, 12);
            this.kmfromvalue.TabIndex = 26;
            this.kmfromvalue.Text = "label1";
            this.kmfromvalue.Visible = false;
            // 
            // kmtovalue
            // 
            this.kmtovalue.AutoSize = true;
            this.kmtovalue.Location = new System.Drawing.Point(321, 539);
            this.kmtovalue.Name = "kmtovalue";
            this.kmtovalue.Size = new System.Drawing.Size(41, 12);
            this.kmtovalue.TabIndex = 27;
            this.kmtovalue.Text = "label1";
            this.kmtovalue.Visible = false;
            // 
            // smaleratevalue
            // 
            this.smaleratevalue.AutoSize = true;
            this.smaleratevalue.Location = new System.Drawing.Point(321, 586);
            this.smaleratevalue.Name = "smaleratevalue";
            this.smaleratevalue.Size = new System.Drawing.Size(41, 12);
            this.smaleratevalue.TabIndex = 28;
            this.smaleratevalue.Text = "label1";
            this.smaleratevalue.Visible = false;
            // 
            // channelnumbervalue
            // 
            this.channelnumbervalue.AutoSize = true;
            this.channelnumbervalue.Location = new System.Drawing.Point(321, 634);
            this.channelnumbervalue.Name = "channelnumbervalue";
            this.channelnumbervalue.Size = new System.Drawing.Size(41, 12);
            this.channelnumbervalue.TabIndex = 29;
            this.channelnumbervalue.Text = "label1";
            this.channelnumbervalue.Visible = false;
            // 
            // datatypenewvalue
            // 
            this.datatypenewvalue.Location = new System.Drawing.Point(569, 58);
            this.datatypenewvalue.Name = "datatypenewvalue";
            this.datatypenewvalue.Size = new System.Drawing.Size(202, 21);
            this.datatypenewvalue.TabIndex = 30;
            this.datatypenewvalue.Visible = false;
            // 
            // dataversionnewvalue
            // 
            this.dataversionnewvalue.Location = new System.Drawing.Point(569, 94);
            this.dataversionnewvalue.Name = "dataversionnewvalue";
            this.dataversionnewvalue.Size = new System.Drawing.Size(202, 21);
            this.dataversionnewvalue.TabIndex = 31;
            this.dataversionnewvalue.Visible = false;
            // 
            // trackcodenewvalue
            // 
            this.trackcodenewvalue.Location = new System.Drawing.Point(569, 132);
            this.trackcodenewvalue.MaxLength = 4;
            this.trackcodenewvalue.Name = "trackcodenewvalue";
            this.trackcodenewvalue.Size = new System.Drawing.Size(202, 21);
            this.trackcodenewvalue.TabIndex = 32;
            this.trackcodenewvalue.Visible = false;
            // 
            // tracknamenewvalue
            // 
            this.tracknamenewvalue.Location = new System.Drawing.Point(569, 170);
            this.tracknamenewvalue.MaxLength = 20;
            this.tracknamenewvalue.Name = "tracknamenewvalue";
            this.tracknamenewvalue.Size = new System.Drawing.Size(202, 21);
            this.tracknamenewvalue.TabIndex = 33;
            this.tracknamenewvalue.Visible = false;
            // 
            // dirnewvalue
            // 
            this.dirnewvalue.Location = new System.Drawing.Point(569, 209);
            this.dirnewvalue.Name = "dirnewvalue";
            this.dirnewvalue.Size = new System.Drawing.Size(202, 21);
            this.dirnewvalue.TabIndex = 34;
            this.dirnewvalue.Visible = false;
            // 
            // traincodenewvalue
            // 
            this.traincodenewvalue.Location = new System.Drawing.Point(569, 250);
            this.traincodenewvalue.MaxLength = 20;
            this.traincodenewvalue.Name = "traincodenewvalue";
            this.traincodenewvalue.Size = new System.Drawing.Size(202, 21);
            this.traincodenewvalue.TabIndex = 35;
            this.traincodenewvalue.Visible = false;
            // 
            // datenewvalue
            // 
            this.datenewvalue.Location = new System.Drawing.Point(569, 295);
            this.datenewvalue.Name = "datenewvalue";
            this.datenewvalue.Size = new System.Drawing.Size(202, 21);
            this.datenewvalue.TabIndex = 36;
            this.datenewvalue.Visible = false;
            // 
            // timenewvalue
            // 
            this.timenewvalue.Location = new System.Drawing.Point(569, 344);
            this.timenewvalue.Name = "timenewvalue";
            this.timenewvalue.Size = new System.Drawing.Size(202, 21);
            this.timenewvalue.TabIndex = 37;
            this.timenewvalue.Visible = false;
            // 
            // rundirnewvalue
            // 
            this.rundirnewvalue.Location = new System.Drawing.Point(569, 391);
            this.rundirnewvalue.Name = "rundirnewvalue";
            this.rundirnewvalue.Size = new System.Drawing.Size(202, 21);
            this.rundirnewvalue.TabIndex = 38;
            this.rundirnewvalue.Visible = false;
            // 
            // kmincnewvalue
            // 
            this.kmincnewvalue.Location = new System.Drawing.Point(569, 440);
            this.kmincnewvalue.Name = "kmincnewvalue";
            this.kmincnewvalue.Size = new System.Drawing.Size(202, 21);
            this.kmincnewvalue.TabIndex = 39;
            this.kmincnewvalue.Visible = false;
            // 
            // kmfromnewvalue
            // 
            this.kmfromnewvalue.Location = new System.Drawing.Point(569, 488);
            this.kmfromnewvalue.Name = "kmfromnewvalue";
            this.kmfromnewvalue.Size = new System.Drawing.Size(202, 21);
            this.kmfromnewvalue.TabIndex = 40;
            this.kmfromnewvalue.Visible = false;
            // 
            // kmtonewvalue
            // 
            this.kmtonewvalue.Location = new System.Drawing.Point(569, 530);
            this.kmtonewvalue.Name = "kmtonewvalue";
            this.kmtonewvalue.Size = new System.Drawing.Size(202, 21);
            this.kmtonewvalue.TabIndex = 41;
            this.kmtonewvalue.Visible = false;
            // 
            // smaleratenewvalue
            // 
            this.smaleratenewvalue.Location = new System.Drawing.Point(569, 577);
            this.smaleratenewvalue.Name = "smaleratenewvalue";
            this.smaleratenewvalue.Size = new System.Drawing.Size(202, 21);
            this.smaleratenewvalue.TabIndex = 42;
            this.smaleratenewvalue.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "更新cit文件头";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 45;
            this.label1.Text = "各通道定义信息:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(821, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(310, 541);
            this.richTextBox1.TabIndex = 46;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // timedlabel
            // 
            this.timedlabel.AutoSize = true;
            this.timedlabel.Location = new System.Drawing.Point(684, 17);
            this.timedlabel.Name = "timedlabel";
            this.timedlabel.Size = new System.Drawing.Size(53, 12);
            this.timedlabel.TabIndex = 47;
            this.timedlabel.Text = "更新成功";
            this.timedlabel.Visible = false;
            // 
            // btn_ExportData
            // 
            this.btn_ExportData.Location = new System.Drawing.Point(1041, 708);
            this.btn_ExportData.Name = "btn_ExportData";
            this.btn_ExportData.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportData.TabIndex = 48;
            this.btn_ExportData.Text = "导  出";
            this.btn_ExportData.UseVisualStyleBackColor = true;
            this.btn_ExportData.Click += new System.EventHandler(this.btn_ExportData_Click);
            // 
            // btn_ExportDataBatch
            // 
            this.btn_ExportDataBatch.Location = new System.Drawing.Point(918, 708);
            this.btn_ExportDataBatch.Name = "btn_ExportDataBatch";
            this.btn_ExportDataBatch.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportDataBatch.TabIndex = 49;
            this.btn_ExportDataBatch.Text = "批量导出";
            this.btn_ExportDataBatch.UseVisualStyleBackColor = true;
            this.btn_ExportDataBatch.Click += new System.EventHandler(this.btn_ExportDataBatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1143, 743);
            this.Controls.Add(this.btn_ExportDataBatch);
            this.Controls.Add(this.btn_ExportData);
            this.Controls.Add(this.timedlabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.smaleratenewvalue);
            this.Controls.Add(this.kmtonewvalue);
            this.Controls.Add(this.kmfromnewvalue);
            this.Controls.Add(this.kmincnewvalue);
            this.Controls.Add(this.rundirnewvalue);
            this.Controls.Add(this.timenewvalue);
            this.Controls.Add(this.datenewvalue);
            this.Controls.Add(this.traincodenewvalue);
            this.Controls.Add(this.dirnewvalue);
            this.Controls.Add(this.tracknamenewvalue);
            this.Controls.Add(this.trackcodenewvalue);
            this.Controls.Add(this.dataversionnewvalue);
            this.Controls.Add(this.datatypenewvalue);
            this.Controls.Add(this.channelnumbervalue);
            this.Controls.Add(this.smaleratevalue);
            this.Controls.Add(this.kmtovalue);
            this.Controls.Add(this.kmfromvalue);
            this.Controls.Add(this.kmincvalue);
            this.Controls.Add(this.rundirvalue);
            this.Controls.Add(this.timevalue);
            this.Controls.Add(this.datevalue);
            this.Controls.Add(this.traincodevalue);
            this.Controls.Add(this.dirvalue);
            this.Controls.Add(this.tracknamevalue);
            this.Controls.Add(this.trackcodevalue);
            this.Controls.Add(this.dataversionvalue);
            this.Controls.Add(this.datatypevalue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentcitfile);
            this.Controls.Add(this.channelnum);
            this.Controls.Add(this.smalerate);
            this.Controls.Add(this.kmto);
            this.Controls.Add(this.kmfrom);
            this.Controls.Add(this.kminc);
            this.Controls.Add(this.rundir);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.traincode);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.trackname);
            this.Controls.Add(this.trackcode);
            this.Controls.Add(this.dataversion);
            this.Controls.Add(this.datatype);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cit文件头编辑器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datatype;
        private System.Windows.Forms.Label dataversion;
        private System.Windows.Forms.Label trackcode;
        private System.Windows.Forms.Label trackname;
        private System.Windows.Forms.Label dir;
        private System.Windows.Forms.Label traincode;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label rundir;
        private System.Windows.Forms.Label kminc;
        private System.Windows.Forms.Label kmfrom;
        private System.Windows.Forms.Label kmto;
        private System.Windows.Forms.Label smalerate;
        private System.Windows.Forms.Label channelnum;
        private System.Windows.Forms.Label currentcitfile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label datatypevalue;
        private System.Windows.Forms.Label dataversionvalue;
        private System.Windows.Forms.Label trackcodevalue;
        private System.Windows.Forms.Label tracknamevalue;
        private System.Windows.Forms.Label dirvalue;
        private System.Windows.Forms.Label traincodevalue;
        private System.Windows.Forms.Label datevalue;
        private System.Windows.Forms.Label timevalue;
        private System.Windows.Forms.Label rundirvalue;
        private System.Windows.Forms.Label kmincvalue;
        private System.Windows.Forms.Label kmfromvalue;
        private System.Windows.Forms.Label kmtovalue;
        private System.Windows.Forms.Label smaleratevalue;
        private System.Windows.Forms.Label channelnumbervalue;
        private System.Windows.Forms.TextBox datatypenewvalue;
        private System.Windows.Forms.TextBox dataversionnewvalue;
        private System.Windows.Forms.TextBox trackcodenewvalue;
        private System.Windows.Forms.TextBox tracknamenewvalue;
        private System.Windows.Forms.TextBox dirnewvalue;
        private System.Windows.Forms.TextBox traincodenewvalue;
        private System.Windows.Forms.TextBox datenewvalue;
        private System.Windows.Forms.TextBox timenewvalue;
        private System.Windows.Forms.TextBox rundirnewvalue;
        private System.Windows.Forms.TextBox kmincnewvalue;
        private System.Windows.Forms.TextBox kmfromnewvalue;
        private System.Windows.Forms.TextBox kmtonewvalue;
        private System.Windows.Forms.TextBox smaleratenewvalue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label timedlabel;
        private System.Windows.Forms.Button btn_ExportData;
        private System.Windows.Forms.Button btn_ExportDataBatch;
    }
}

