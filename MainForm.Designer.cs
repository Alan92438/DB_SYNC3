namespace DB_SYNC3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_Val_TargetStatus = new System.Windows.Forms.Label();
            this.lbl_Val_Source_Status = new System.Windows.Forms.Label();
            this.lbl_Source_Status = new System.Windows.Forms.Label();
            this.lbl_TargetStatus = new System.Windows.Forms.Label();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.btn_ConnectTest = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lst_Target = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clb_communies = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbx_msg = new System.Windows.Forms.ListBox();
            this.dgv_APIJSON = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.lbl_Target = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_APIJSON)).BeginInit();
            this.groupBox7.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(800, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_Val_TargetStatus);
            this.groupBox6.Controls.Add(this.lbl_Val_Source_Status);
            this.groupBox6.Controls.Add(this.lbl_Source_Status);
            this.groupBox6.Controls.Add(this.lbl_TargetStatus);
            this.groupBox6.Controls.Add(this.btn_Sync);
            this.groupBox6.Controls.Add(this.btn_ConnectTest);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(252, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(284, 216);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Action";
            // 
            // lbl_Val_TargetStatus
            // 
            this.lbl_Val_TargetStatus.AutoSize = true;
            this.lbl_Val_TargetStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_Val_TargetStatus.Location = new System.Drawing.Point(110, 44);
            this.lbl_Val_TargetStatus.Name = "lbl_Val_TargetStatus";
            this.lbl_Val_TargetStatus.Size = new System.Drawing.Size(71, 12);
            this.lbl_Val_TargetStatus.TabIndex = 6;
            this.lbl_Val_TargetStatus.Text = "Disconnection";
            // 
            // lbl_Val_Source_Status
            // 
            this.lbl_Val_Source_Status.AutoSize = true;
            this.lbl_Val_Source_Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_Val_Source_Status.Location = new System.Drawing.Point(110, 21);
            this.lbl_Val_Source_Status.Name = "lbl_Val_Source_Status";
            this.lbl_Val_Source_Status.Size = new System.Drawing.Size(71, 12);
            this.lbl_Val_Source_Status.TabIndex = 5;
            this.lbl_Val_Source_Status.Text = "Disconnection";
            // 
            // lbl_Source_Status
            // 
            this.lbl_Source_Status.AutoSize = true;
            this.lbl_Source_Status.Location = new System.Drawing.Point(26, 21);
            this.lbl_Source_Status.Name = "lbl_Source_Status";
            this.lbl_Source_Status.Size = new System.Drawing.Size(56, 12);
            this.lbl_Source_Status.TabIndex = 4;
            this.lbl_Source_Status.Text = "Source DB";
            // 
            // lbl_TargetStatus
            // 
            this.lbl_TargetStatus.AutoSize = true;
            this.lbl_TargetStatus.Location = new System.Drawing.Point(26, 45);
            this.lbl_TargetStatus.Name = "lbl_TargetStatus";
            this.lbl_TargetStatus.Size = new System.Drawing.Size(54, 12);
            this.lbl_TargetStatus.TabIndex = 3;
            this.lbl_TargetStatus.Text = "Target DB";
            // 
            // btn_Sync
            // 
            this.btn_Sync.Location = new System.Drawing.Point(64, 103);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(168, 55);
            this.btn_Sync.TabIndex = 1;
            this.btn_Sync.Text = "Sync";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // btn_ConnectTest
            // 
            this.btn_ConnectTest.Location = new System.Drawing.Point(187, 21);
            this.btn_ConnectTest.Name = "btn_ConnectTest";
            this.btn_ConnectTest.Size = new System.Drawing.Size(86, 37);
            this.btn_ConnectTest.TabIndex = 2;
            this.btn_ConnectTest.Text = "Test Connection";
            this.btn_ConnectTest.Click += new System.EventHandler(this.btn_ConnectTest_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_Target);
            this.groupBox5.Controls.Add(this.lst_Target);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(536, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 216);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Target";
            // 
            // lst_Target
            // 
            this.lst_Target.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lst_Target.FormattingEnabled = true;
            this.lst_Target.ItemHeight = 12;
            this.lst_Target.Location = new System.Drawing.Point(3, 53);
            this.lst_Target.Name = "lst_Target";
            this.lst_Target.Size = new System.Drawing.Size(255, 160);
            this.lst_Target.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbb_Status);
            this.groupBox4.Controls.Add(this.clb_communies);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(249, 216);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Source";
            // 
            // clb_communies
            // 
            this.clb_communies.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clb_communies.FormattingEnabled = true;
            this.clb_communies.Location = new System.Drawing.Point(3, 56);
            this.clb_communies.Name = "clb_communies";
            this.clb_communies.Size = new System.Drawing.Size(243, 157);
            this.clb_communies.TabIndex = 9;
            this.clb_communies.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_communies_ItemCheck);
            this.clb_communies.SelectedIndexChanged += new System.EventHandler(this.clb_communies_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbx_msg);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 483);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // lbx_msg
            // 
            this.lbx_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_msg.FormattingEnabled = true;
            this.lbx_msg.ItemHeight = 12;
            this.lbx_msg.Location = new System.Drawing.Point(3, 18);
            this.lbx_msg.Name = "lbx_msg";
            this.lbx_msg.Size = new System.Drawing.Size(794, 77);
            this.lbx_msg.TabIndex = 0;
            // 
            // dgv_APIJSON
            // 
            this.dgv_APIJSON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_APIJSON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_APIJSON.Location = new System.Drawing.Point(3, 18);
            this.dgv_APIJSON.Name = "dgv_APIJSON";
            this.dgv_APIJSON.RowHeadersVisible = false;
            this.dgv_APIJSON.RowTemplate.Height = 24;
            this.dgv_APIJSON.Size = new System.Drawing.Size(794, 225);
            this.dgv_APIJSON.TabIndex = 9;
            this.dgv_APIJSON.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_APIJSON_ColumnHeaderMouseClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgv_APIJSON);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 237);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(800, 246);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lan Ip List";
            // 
            // cbb_Status
            // 
            this.cbb_Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Location = new System.Drawing.Point(3, 18);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(243, 20);
            this.cbb_Status.TabIndex = 10;
            this.cbb_Status.SelectedIndexChanged += new System.EventHandler(this.cbb_Status_SelectedIndexChanged);
            // 
            // lbl_Target
            // 
            this.lbl_Target.AutoSize = true;
            this.lbl_Target.Location = new System.Drawing.Point(7, 21);
            this.lbl_Target.Name = "lbl_Target";
            this.lbl_Target.Size = new System.Drawing.Size(68, 12);
            this.lbl_Target.TabIndex = 1;
            this.lbl_Target.Text = "last Update：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main | Axon — Delivering Intelligence from Bintafy to Communities";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_APIJSON)).EndInit();
            this.groupBox7.ResumeLayout(false);
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
        private System.Windows.Forms.Label lbl_TargetStatus;
        private System.Windows.Forms.Label lbl_Source_Status;
        private System.Windows.Forms.Label lbl_Val_Source_Status;
        private System.Windows.Forms.Label lbl_Val_TargetStatus;
        private System.Windows.Forms.CheckedListBox clb_communies;
        private System.Windows.Forms.DataGridView dgv_APIJSON;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbb_Status;
        private System.Windows.Forms.Label lbl_Target;
    }
}

