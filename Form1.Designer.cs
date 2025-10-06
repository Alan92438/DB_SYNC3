namespace DB_SYNC3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_Source_Status = new System.Windows.Forms.Label();
            this.lbl_TargetStatus = new System.Windows.Forms.Label();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.btn_ConnectTest = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lst_Target = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbx_msg = new System.Windows.Forms.ListBox();
            this.lbl_Val_Source_Status = new System.Windows.Forms.Label();
            this.lbl_Val_TargetStatus = new System.Windows.Forms.Label();
            this.tbx_APIJSON = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbx_APIJSON);
            this.groupBox6.Controls.Add(this.lbl_Val_TargetStatus);
            this.groupBox6.Controls.Add(this.lbl_Val_Source_Status);
            this.groupBox6.Controls.Add(this.lbl_Source_Status);
            this.groupBox6.Controls.Add(this.lbl_TargetStatus);
            this.groupBox6.Controls.Add(this.btn_Sync);
            this.groupBox6.Controls.Add(this.btn_ConnectTest);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(252, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(229, 224);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "動作";
            // 
            // lbl_Source_Status
            // 
            this.lbl_Source_Status.AutoSize = true;
            this.lbl_Source_Status.Location = new System.Drawing.Point(6, 40);
            this.lbl_Source_Status.Name = "lbl_Source_Status";
            this.lbl_Source_Status.Size = new System.Drawing.Size(77, 12);
            this.lbl_Source_Status.TabIndex = 4;
            this.lbl_Source_Status.Text = "來源資料庫：";
            // 
            // lbl_TargetStatus
            // 
            this.lbl_TargetStatus.AutoSize = true;
            this.lbl_TargetStatus.Location = new System.Drawing.Point(6, 64);
            this.lbl_TargetStatus.Name = "lbl_TargetStatus";
            this.lbl_TargetStatus.Size = new System.Drawing.Size(77, 12);
            this.lbl_TargetStatus.TabIndex = 3;
            this.lbl_TargetStatus.Text = "目的資料庫：";
            // 
            // btn_Sync
            // 
            this.btn_Sync.Location = new System.Drawing.Point(82, 136);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(75, 38);
            this.btn_Sync.TabIndex = 1;
            this.btn_Sync.Text = ">>同步>>";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // btn_ConnectTest
            // 
            this.btn_ConnectTest.Location = new System.Drawing.Point(82, 93);
            this.btn_ConnectTest.Name = "btn_ConnectTest";
            this.btn_ConnectTest.Size = new System.Drawing.Size(75, 37);
            this.btn_ConnectTest.TabIndex = 2;
            this.btn_ConnectTest.Text = "測試連線";
            this.btn_ConnectTest.Click += new System.EventHandler(this.btn_ConnectTest_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lst_Target);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(481, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 224);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "目的地";
            // 
            // lst_Target
            // 
            this.lst_Target.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Target.FormattingEnabled = true;
            this.lst_Target.ItemHeight = 12;
            this.lst_Target.Location = new System.Drawing.Point(3, 18);
            this.lst_Target.Name = "lst_Target";
            this.lst_Target.Size = new System.Drawing.Size(310, 203);
            this.lst_Target.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstTables);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 224);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "來源地";
            // 
            // lstTables
            // 
            this.lstTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTables.FormattingEnabled = true;
            this.lstTables.ItemHeight = 12;
            this.lstTables.Location = new System.Drawing.Point(3, 18);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(243, 203);
            this.lstTables.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbx_msg);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "訊息";
            // 
            // lbx_msg
            // 
            this.lbx_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_msg.FormattingEnabled = true;
            this.lbx_msg.ItemHeight = 12;
            this.lbx_msg.Location = new System.Drawing.Point(3, 18);
            this.lbx_msg.Name = "lbx_msg";
            this.lbx_msg.Size = new System.Drawing.Size(794, 184);
            this.lbx_msg.TabIndex = 0;
            // 
            // lbl_Val_Source_Status
            // 
            this.lbl_Val_Source_Status.AutoSize = true;
            this.lbl_Val_Source_Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_Val_Source_Status.Location = new System.Drawing.Point(90, 40);
            this.lbl_Val_Source_Status.Name = "lbl_Val_Source_Status";
            this.lbl_Val_Source_Status.Size = new System.Drawing.Size(41, 12);
            this.lbl_Val_Source_Status.TabIndex = 5;
            this.lbl_Val_Source_Status.Text = "未連線";
            // 
            // lbl_Val_TargetStatus
            // 
            this.lbl_Val_TargetStatus.AutoSize = true;
            this.lbl_Val_TargetStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_Val_TargetStatus.Location = new System.Drawing.Point(90, 63);
            this.lbl_Val_TargetStatus.Name = "lbl_Val_TargetStatus";
            this.lbl_Val_TargetStatus.Size = new System.Drawing.Size(41, 12);
            this.lbl_Val_TargetStatus.TabIndex = 6;
            this.lbl_Val_TargetStatus.Text = "未連線";
            // 
            // tbx_APIJSON
            // 
            this.tbx_APIJSON.Location = new System.Drawing.Point(3, 196);
            this.tbx_APIJSON.Name = "tbx_APIJSON";
            this.tbx_APIJSON.Size = new System.Drawing.Size(225, 22);
            this.tbx_APIJSON.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "資料界接軟體";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbx_msg;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.Button btn_ConnectTest;
        private System.Windows.Forms.ListBox lst_Target;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.Label lbl_TargetStatus;
        private System.Windows.Forms.Label lbl_Source_Status;
        private System.Windows.Forms.Label lbl_Val_Source_Status;
        private System.Windows.Forms.Label lbl_Val_TargetStatus;
        private System.Windows.Forms.TextBox tbx_APIJSON;
    }
}

