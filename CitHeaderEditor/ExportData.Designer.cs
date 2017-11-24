namespace CitHeaderEditor
{
    partial class ExportData
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ckb_all = new System.Windows.Forms.CheckBox();
            this.ckb_Chinese = new System.Windows.Forms.CheckBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 13);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(419, 444);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "英文名";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "中文名";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "通道比例";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "通道基准线";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "通道单位";
            // 
            // ckb_all
            // 
            this.ckb_all.AutoSize = true;
            this.ckb_all.Location = new System.Drawing.Point(13, 472);
            this.ckb_all.Name = "ckb_all";
            this.ckb_all.Size = new System.Drawing.Size(60, 16);
            this.ckb_all.TabIndex = 1;
            this.ckb_all.Text = "全  选";
            this.ckb_all.UseVisualStyleBackColor = true;
            this.ckb_all.CheckedChanged += new System.EventHandler(this.ckb_all_CheckedChanged);
            // 
            // ckb_Chinese
            // 
            this.ckb_Chinese.AutoSize = true;
            this.ckb_Chinese.Location = new System.Drawing.Point(102, 473);
            this.ckb_Chinese.Name = "ckb_Chinese";
            this.ckb_Chinese.Size = new System.Drawing.Size(144, 16);
            this.ckb_Chinese.TabIndex = 2;
            this.ckb_Chinese.Text = "通道名称导出为中文名";
            this.ckb_Chinese.UseVisualStyleBackColor = true;
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(273, 470);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 3;
            this.btn_Export.Text = "导  出";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // ExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 507);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.ckb_Chinese);
            this.Controls.Add(this.ckb_all);
            this.Controls.Add(this.listView1);
            this.Name = "ExportData";
            this.Text = "ExportData";
            this.Load += new System.EventHandler(this.ExportData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.CheckBox ckb_all;
        private System.Windows.Forms.CheckBox ckb_Chinese;
        private System.Windows.Forms.Button btn_Export;
    }
}