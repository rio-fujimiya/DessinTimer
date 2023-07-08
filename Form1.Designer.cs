namespace IntervalTimer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.txbDo = new System.Windows.Forms.TextBox();
            this.txbCount = new System.Windows.Forms.TextBox();
            this.txbInterval = new System.Windows.Forms.TextBox();
            this.prgbarMain = new System.Windows.Forms.ProgressBar();
            this.btnRun = new System.Windows.Forms.Button();
            this.btn60 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Checked = true;
            this.chkAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuto.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.chkAuto.Location = new System.Drawing.Point(458, 11);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(81, 16);
            this.chkAuto.TabIndex = 0;
            this.chkAuto.TabStop = false;
            this.chkAuto.Text = "Continuous";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // txbDo
            // 
            this.txbDo.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbDo.Location = new System.Drawing.Point(84, 9);
            this.txbDo.Name = "txbDo";
            this.txbDo.Size = new System.Drawing.Size(56, 19);
            this.txbDo.TabIndex = 1;
            this.txbDo.Text = "60";
            this.txbDo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbDo.TextChanged += new System.EventHandler(this.txbDo_TextChanged);
            // 
            // txbCount
            // 
            this.txbCount.Font = new System.Drawing.Font("MS UI Gothic", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbCount.Location = new System.Drawing.Point(11, 9);
            this.txbCount.Name = "txbCount";
            this.txbCount.ReadOnly = true;
            this.txbCount.Size = new System.Drawing.Size(66, 43);
            this.txbCount.TabIndex = 2;
            this.txbCount.TabStop = false;
            this.txbCount.Text = "0";
            this.txbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbInterval
            // 
            this.txbInterval.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbInterval.Location = new System.Drawing.Point(536, 9);
            this.txbInterval.Name = "txbInterval";
            this.txbInterval.Size = new System.Drawing.Size(34, 19);
            this.txbInterval.TabIndex = 3;
            this.txbInterval.Text = "5";
            this.txbInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbInterval.TextChanged += new System.EventHandler(this.txbInterval_TextChanged);
            // 
            // prgbarMain
            // 
            this.prgbarMain.Location = new System.Drawing.Point(84, 32);
            this.prgbarMain.Name = "prgbarMain";
            this.prgbarMain.Size = new System.Drawing.Size(486, 20);
            this.prgbarMain.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("MS UI Gothic", 27F);
            this.btnRun.Location = new System.Drawing.Point(577, 9);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(140, 43);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "START";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btn60
            // 
            this.btn60.Location = new System.Drawing.Point(146, 9);
            this.btn60.Name = "btn60";
            this.btn60.Size = new System.Drawing.Size(41, 19);
            this.btn60.TabIndex = 5;
            this.btn60.TabStop = false;
            this.btn60.Text = "60";
            this.btn60.UseVisualStyleBackColor = true;
            this.btn60.Click += new System.EventHandler(this.btn60_Click);
            // 
            // btn30
            // 
            this.btn30.Location = new System.Drawing.Point(193, 9);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(41, 19);
            this.btn30.TabIndex = 6;
            this.btn30.TabStop = false;
            this.btn30.Text = "30";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(240, 8);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(212, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TabStop = false;
            this.trackBar1.Value = 10;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 61);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn60);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.prgbarMain);
            this.Controls.Add(this.txbInterval);
            this.Controls.Add(this.txbCount);
            this.Controls.Add(this.txbDo);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Interval Timer for Quick Dessin | ©i2forme2021/Rio Fujimiya [v1.0.2/20210508]";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.TextBox txbDo;
        private System.Windows.Forms.TextBox txbCount;
        private System.Windows.Forms.TextBox txbInterval;
        private System.Windows.Forms.ProgressBar prgbarMain;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btn60;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

