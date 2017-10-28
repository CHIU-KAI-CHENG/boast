namespace project3
{
    partial class BlowerSelectForm
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.P1ReadyButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.playerImg1 = new System.Windows.Forms.PictureBox();
            this.teacher6 = new System.Windows.Forms.PictureBox();
            this.teacher5 = new System.Windows.Forms.PictureBox();
            this.teacher4 = new System.Windows.Forms.PictureBox();
            this.teacher3 = new System.Windows.Forms.PictureBox();
            this.teacher2 = new System.Windows.Forms.PictureBox();
            this.teacher1 = new System.Windows.Forms.PictureBox();
            this.gameStartButton = new System.Windows.Forms.Button();
            this.ResetTeacherButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.P1_name = new System.Windows.Forms.Label();
            this.P1NameLabel = new System.Windows.Forms.Label();
            this.NameTexstBox = new System.Windows.Forms.TextBox();
            this.serverIpTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IPlabel = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher1)).BeginInit();
            this.SuspendLayout();
            // 
            // P1ReadyButton
            // 
            this.P1ReadyButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.P1ReadyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P1ReadyButton.Enabled = false;
            this.P1ReadyButton.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1ReadyButton.Location = new System.Drawing.Point(401, 517);
            this.P1ReadyButton.Name = "P1ReadyButton";
            this.P1ReadyButton.Size = new System.Drawing.Size(179, 54);
            this.P1ReadyButton.TabIndex = 1;
            this.P1ReadyButton.Text = "Ready";
            this.P1ReadyButton.UseVisualStyleBackColor = false;
            this.P1ReadyButton.Click += new System.EventHandler(this.P1ReadyButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // playerImg1
            // 
            this.playerImg1.Location = new System.Drawing.Point(118, 12);
            this.playerImg1.Name = "playerImg1";
            this.playerImg1.Size = new System.Drawing.Size(296, 299);
            this.playerImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerImg1.TabIndex = 7;
            this.playerImg1.TabStop = false;
            // 
            // teacher6
            // 
            this.teacher6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher6.Image = global::project3.Properties.Resources.裕賢;
            this.teacher6.Location = new System.Drawing.Point(863, 174);
            this.teacher6.Name = "teacher6";
            this.teacher6.Size = new System.Drawing.Size(135, 137);
            this.teacher6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teacher6.TabIndex = 6;
            this.teacher6.TabStop = false;
            this.teacher6.Click += new System.EventHandler(this.teacher6_Click);
            // 
            // teacher5
            // 
            this.teacher5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher5.Image = global::project3.Properties.Resources.致芳;
            this.teacher5.Location = new System.Drawing.Point(706, 174);
            this.teacher5.Name = "teacher5";
            this.teacher5.Size = new System.Drawing.Size(135, 137);
            this.teacher5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teacher5.TabIndex = 5;
            this.teacher5.TabStop = false;
            this.teacher5.Click += new System.EventHandler(this.teacher5_Click);
            // 
            // teacher4
            // 
            this.teacher4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher4.Image = global::project3.Properties.Resources.俊元;
            this.teacher4.Location = new System.Drawing.Point(546, 174);
            this.teacher4.Name = "teacher4";
            this.teacher4.Size = new System.Drawing.Size(135, 137);
            this.teacher4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teacher4.TabIndex = 4;
            this.teacher4.TabStop = false;
            this.teacher4.Click += new System.EventHandler(this.teacher4_Click);
            // 
            // teacher3
            // 
            this.teacher3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher3.Image = global::project3.Properties.Resources.東穎;
            this.teacher3.Location = new System.Drawing.Point(863, 12);
            this.teacher3.Name = "teacher3";
            this.teacher3.Size = new System.Drawing.Size(135, 137);
            this.teacher3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teacher3.TabIndex = 3;
            this.teacher3.TabStop = false;
            this.teacher3.Click += new System.EventHandler(this.teacher3_Click);
            // 
            // teacher2
            // 
            this.teacher2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher2.Image = global::project3.Properties.Resources.伯星;
            this.teacher2.Location = new System.Drawing.Point(706, 12);
            this.teacher2.Name = "teacher2";
            this.teacher2.Size = new System.Drawing.Size(135, 137);
            this.teacher2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teacher2.TabIndex = 2;
            this.teacher2.TabStop = false;
            this.teacher2.Click += new System.EventHandler(this.teacher2_Click);
            // 
            // teacher1
            // 
            this.teacher1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacher1.Image = global::project3.Properties.Resources.玉山;
            this.teacher1.Location = new System.Drawing.Point(546, 12);
            this.teacher1.Name = "teacher1";
            this.teacher1.Size = new System.Drawing.Size(135, 137);
            this.teacher1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.teacher1.TabIndex = 0;
            this.teacher1.TabStop = false;
            this.teacher1.Click += new System.EventHandler(this.teacher1_Click);
            // 
            // gameStartButton
            // 
            this.gameStartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gameStartButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gameStartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameStartButton.Enabled = false;
            this.gameStartButton.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.gameStartButton.Location = new System.Drawing.Point(819, 527);
            this.gameStartButton.Name = "gameStartButton";
            this.gameStartButton.Size = new System.Drawing.Size(179, 54);
            this.gameStartButton.TabIndex = 12;
            this.gameStartButton.Text = "連線server";
            this.gameStartButton.UseVisualStyleBackColor = false;
            this.gameStartButton.Click += new System.EventHandler(this.gameStartButton_Click);
            // 
            // ResetTeacherButton
            // 
            this.ResetTeacherButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ResetTeacherButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetTeacherButton.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.ResetTeacherButton.Location = new System.Drawing.Point(401, 606);
            this.ResetTeacherButton.Name = "ResetTeacherButton";
            this.ResetTeacherButton.Size = new System.Drawing.Size(179, 54);
            this.ResetTeacherButton.TabIndex = 13;
            this.ResetTeacherButton.Text = "重設";
            this.ResetTeacherButton.UseVisualStyleBackColor = false;
            this.ResetTeacherButton.Click += new System.EventHandler(this.ResetTeacherButton_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(819, 606);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 54);
            this.button5.TabIndex = 14;
            this.button5.Text = "取消";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // P1_name
            // 
            this.P1_name.AutoSize = true;
            this.P1_name.BackColor = System.Drawing.Color.White;
            this.P1_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P1_name.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1_name.Location = new System.Drawing.Point(256, 325);
            this.P1_name.Name = "P1_name";
            this.P1_name.Size = new System.Drawing.Size(30, 21);
            this.P1_name.TabIndex = 21;
            this.P1_name.Text = "無";
            // 
            // P1NameLabel
            // 
            this.P1NameLabel.AutoSize = true;
            this.P1NameLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1NameLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.P1NameLabel.Location = new System.Drawing.Point(701, 362);
            this.P1NameLabel.Name = "P1NameLabel";
            this.P1NameLabel.Size = new System.Drawing.Size(89, 25);
            this.P1NameLabel.TabIndex = 22;
            this.P1NameLabel.Text = "吹牛者:";
            this.P1NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P1NameLabel.Visible = false;
            // 
            // NameTexstBox
            // 
            this.NameTexstBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameTexstBox.Location = new System.Drawing.Point(189, 527);
            this.NameTexstBox.Name = "NameTexstBox";
            this.NameTexstBox.Size = new System.Drawing.Size(186, 40);
            this.NameTexstBox.TabIndex = 23;
            // 
            // serverIpTextBox
            // 
            this.serverIpTextBox.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverIpTextBox.Location = new System.Drawing.Point(189, 606);
            this.serverIpTextBox.Name = "serverIpTextBox";
            this.serverIpTextBox.Size = new System.Drawing.Size(186, 40);
            this.serverIpTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "吹牛者名稱:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(44, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "serverIP";
            // 
            // IPlabel
            // 
            this.IPlabel.AutoSize = true;
            this.IPlabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPlabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.IPlabel.Location = new System.Drawing.Point(701, 406);
            this.IPlabel.Name = "IPlabel";
            this.IPlabel.Size = new System.Drawing.Size(46, 25);
            this.IPlabel.TabIndex = 27;
            this.IPlabel.Text = "IP:";
            this.IPlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IPlabel.Visible = false;
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.headLabel.Location = new System.Drawing.Point(701, 449);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(66, 25);
            this.headLabel.TabIndex = 28;
            this.headLabel.Text = "頭像:";
            this.headLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headLabel.Visible = false;
            // 
            // BlowerSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::project3.Properties.Resources.妙蛙種子;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 705);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.IPlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverIpTextBox);
            this.Controls.Add(this.NameTexstBox);
            this.Controls.Add(this.P1NameLabel);
            this.Controls.Add(this.P1_name);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ResetTeacherButton);
            this.Controls.Add(this.gameStartButton);
            this.Controls.Add(this.playerImg1);
            this.Controls.Add(this.teacher6);
            this.Controls.Add(this.teacher5);
            this.Controls.Add(this.teacher4);
            this.Controls.Add(this.teacher3);
            this.Controls.Add(this.teacher2);
            this.Controls.Add(this.P1ReadyButton);
            this.Controls.Add(this.teacher1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BlowerSelectForm";
            this.Text = "三峽吹牛大王";
            ((System.ComponentModel.ISupportInitialize)(this.playerImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox teacher1;
        private System.Windows.Forms.Button P1ReadyButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox teacher2;
        private System.Windows.Forms.PictureBox teacher3;
        private System.Windows.Forms.PictureBox teacher4;
        private System.Windows.Forms.PictureBox teacher5;
        private System.Windows.Forms.PictureBox teacher6;
        private System.Windows.Forms.PictureBox playerImg1;
        private System.Windows.Forms.Button gameStartButton;
        private System.Windows.Forms.Button ResetTeacherButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label P1_name;
        private System.Windows.Forms.Label P1NameLabel;
        private System.Windows.Forms.TextBox NameTexstBox;
        private System.Windows.Forms.TextBox serverIpTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IPlabel;
        private System.Windows.Forms.Label headLabel;
    }
}

