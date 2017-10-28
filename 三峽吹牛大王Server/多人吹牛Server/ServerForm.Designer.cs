namespace 多人吹牛Server
{
    partial class ServerForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MaxPlayerLbl = new System.Windows.Forms.Label();
            this.MaxPlayerCmbBox = new System.Windows.Forms.ComboBox();
            this.MaxPlayerBtn = new System.Windows.Forms.Button();
            this.AcptRcvBckWrkr = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RcvDecBckWrkr = new System.ComponentModel.BackgroundWorker();
            this.PlayerIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhotoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecInfoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaxPlayerLbl
            // 
            this.MaxPlayerLbl.AutoSize = true;
            this.MaxPlayerLbl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MaxPlayerLbl.Location = new System.Drawing.Point(12, 24);
            this.MaxPlayerLbl.Name = "MaxPlayerLbl";
            this.MaxPlayerLbl.Size = new System.Drawing.Size(74, 21);
            this.MaxPlayerLbl.TabIndex = 1;
            this.MaxPlayerLbl.Text = "玩家人數";
            // 
            // MaxPlayerCmbBox
            // 
            this.MaxPlayerCmbBox.FormattingEnabled = true;
            this.MaxPlayerCmbBox.Items.AddRange(new object[] {
            "2人",
            "3人",
            "4人"});
            this.MaxPlayerCmbBox.Location = new System.Drawing.Point(105, 25);
            this.MaxPlayerCmbBox.Name = "MaxPlayerCmbBox";
            this.MaxPlayerCmbBox.Size = new System.Drawing.Size(40, 20);
            this.MaxPlayerCmbBox.TabIndex = 2;
            this.MaxPlayerCmbBox.Text = "2人";
            // 
            // MaxPlayerBtn
            // 
            this.MaxPlayerBtn.BackColor = System.Drawing.Color.SlateGray;
            this.MaxPlayerBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MaxPlayerBtn.Location = new System.Drawing.Point(177, 15);
            this.MaxPlayerBtn.Name = "MaxPlayerBtn";
            this.MaxPlayerBtn.Size = new System.Drawing.Size(95, 38);
            this.MaxPlayerBtn.TabIndex = 3;
            this.MaxPlayerBtn.Text = "確認人數";
            this.MaxPlayerBtn.UseVisualStyleBackColor = false;
            this.MaxPlayerBtn.Click += new System.EventHandler(this.MaxPlayerBtn_Click);
            // 
            // AcptRcvBckWrkr
            // 
            this.AcptRcvBckWrkr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AcptRcvBckWrkr_DoWork);
            this.AcptRcvBckWrkr.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AcptRcvBckWrkr_RunWorkerCompleted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerIDColumn,
            this.PlayerNameColumn,
            this.PhotoColumn,
            this.DecInfoColumn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(637, 143);
            this.dataGridView1.TabIndex = 4;
            // 
            // RcvDecBckWrkr
            // 
            this.RcvDecBckWrkr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RcvDecBckWrkr_DoWork);
            this.RcvDecBckWrkr.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RcvDecBckWrkr_RunWorkerCompleted);
            // 
            // PlayerIDColumn
            // 
            this.PlayerIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PlayerIDColumn.HeaderText = "ID";
            this.PlayerIDColumn.Name = "PlayerIDColumn";
            this.PlayerIDColumn.ReadOnly = true;
            this.PlayerIDColumn.Width = 40;
            // 
            // PlayerNameColumn
            // 
            this.PlayerNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlayerNameColumn.HeaderText = "名稱";
            this.PlayerNameColumn.Name = "PlayerNameColumn";
            this.PlayerNameColumn.ReadOnly = true;
            this.PlayerNameColumn.Width = 52;
            // 
            // PhotoColumn
            // 
            this.PhotoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PhotoColumn.HeaderText = "角色";
            this.PhotoColumn.Name = "PhotoColumn";
            this.PhotoColumn.ReadOnly = true;
            this.PhotoColumn.Width = 52;
            // 
            // DecInfoColumn
            // 
            this.DecInfoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DecInfoColumn.HeaderText = "喊過資訊";
            this.DecInfoColumn.Name = "DecInfoColumn";
            this.DecInfoColumn.ReadOnly = true;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MaxPlayerBtn);
            this.Controls.Add(this.MaxPlayerCmbBox);
            this.Controls.Add(this.MaxPlayerLbl);
            this.Name = "ServerForm";
            this.Text = "多人吹牛Server";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaxPlayerLbl;
        private System.Windows.Forms.ComboBox MaxPlayerCmbBox;
        private System.Windows.Forms.Button MaxPlayerBtn;
        private System.ComponentModel.BackgroundWorker AcptRcvBckWrkr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker RcvDecBckWrkr;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhotoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecInfoColumn;
    }
}

