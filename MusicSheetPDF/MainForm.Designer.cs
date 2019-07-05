namespace MusicSheetPDF
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.dgvMusicSheet = new System.Windows.Forms.DataGridView();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.col_MeargeCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Instrument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Part = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_Convert);
            this.splitContainer1.Panel1.Controls.Add(this.dgvMusicSheet);
            this.splitContainer1.Panel1.Controls.Add(this.txtFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axAcroPDF);
            this.splitContainer1.Size = new System.Drawing.Size(949, 554);
            this.splitContainer1.SplitterDistance = 440;
            this.splitContainer1.TabIndex = 4;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Convert.Location = new System.Drawing.Point(3, 521);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 3;
            this.btn_Convert.Text = "変換";
            this.btn_Convert.UseVisualStyleBackColor = true;
            // 
            // dgvMusicSheet
            // 
            this.dgvMusicSheet.AllowUserToAddRows = false;
            this.dgvMusicSheet.AllowUserToResizeRows = false;
            this.dgvMusicSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusicSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusicSheet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MeargeCheck,
            this.col_FileName,
            this.col_Instrument,
            this.col_Part});
            this.dgvMusicSheet.Location = new System.Drawing.Point(3, 28);
            this.dgvMusicSheet.MultiSelect = false;
            this.dgvMusicSheet.Name = "dgvMusicSheet";
            this.dgvMusicSheet.RowHeadersVisible = false;
            this.dgvMusicSheet.RowTemplate.Height = 21;
            this.dgvMusicSheet.Size = new System.Drawing.Size(434, 487);
            this.dgvMusicSheet.TabIndex = 2;
            this.dgvMusicSheet.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusicSheet_CellEnter);
            this.dgvMusicSheet.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMusicSheet_EditingControlShowing);
            // 
            // txtFolder
            // 
            this.txtFolder.AllowDrop = true;
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(3, 3);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(434, 19);
            this.txtFolder.TabIndex = 1;
            this.txtFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFolder_DragDrop);
            this.txtFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFolder_DragEnter);
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(3, 3);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(499, 548);
            this.axAcroPDF.TabIndex = 0;
            // 
            // col_MeargeCheck
            // 
            this.col_MeargeCheck.HeaderText = "結合";
            this.col_MeargeCheck.Name = "col_MeargeCheck";
            this.col_MeargeCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_MeargeCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_MeargeCheck.Width = 30;
            // 
            // col_FileName
            // 
            this.col_FileName.HeaderText = "ファイル名";
            this.col_FileName.Name = "col_FileName";
            this.col_FileName.ReadOnly = true;
            this.col_FileName.Width = 150;
            // 
            // col_Instrument
            // 
            this.col_Instrument.HeaderText = "楽器";
            this.col_Instrument.Name = "col_Instrument";
            this.col_Instrument.Width = 130;
            // 
            // col_Part
            // 
            this.col_Part.HeaderText = "パート";
            this.col_Part.Items.AddRange(new object[] {
            "",
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "solo"});
            this.col_Part.MaxDropDownItems = 6;
            this.col_Part.Name = "col_Part";
            this.col_Part.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Part.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_Part.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 578);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.DataGridView dgvMusicSheet;
        private System.Windows.Forms.TextBox txtFolder;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_MeargeCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Instrument;
        private System.Windows.Forms.DataGridViewComboBoxColumn col_Part;
    }
}

