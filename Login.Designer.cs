namespace DB_SYNC3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txb_AD = new System.Windows.Forms.TextBox();
            this.txb_PW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_error = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txb_AD
            // 
            this.txb_AD.Location = new System.Drawing.Point(151, 72);
            this.txb_AD.Name = "txb_AD";
            this.txb_AD.Size = new System.Drawing.Size(152, 22);
            this.txb_AD.TabIndex = 1;
            this.txb_AD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb_PW
            // 
            this.txb_PW.Location = new System.Drawing.Point(151, 111);
            this.txb_PW.Name = "txb_PW";
            this.txb_PW.Size = new System.Drawing.Size(152, 22);
            this.txb_PW.TabIndex = 2;
            this.txb_PW.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密碼：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(228, 149);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 38);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "登入";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_error);
            this.groupBox1.Controls.Add(this.btn_Login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_PW);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_AD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 365);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txb_error
            // 
            this.txb_error.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txb_error.Location = new System.Drawing.Point(3, 297);
            this.txb_error.Multiline = true;
            this.txb_error.Name = "txb_error";
            this.txb_error.Size = new System.Drawing.Size(391, 65);
            this.txb_error.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 365);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login | Axon — Delivering Intelligence from Bintafy to Communities";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_AD;
        private System.Windows.Forms.TextBox txb_PW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_error;
    }
}