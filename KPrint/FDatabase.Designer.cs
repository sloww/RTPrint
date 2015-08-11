namespace KPrint
{
    partial class FDatabase
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
            this.txbDBIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbDBName = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbDBIP
            // 
            this.txbDBIP.Font = new System.Drawing.Font("宋体", 12F);
            this.txbDBIP.Location = new System.Drawing.Point(125, 37);
            this.txbDBIP.Name = "txbDBIP";
            this.txbDBIP.Size = new System.Drawing.Size(248, 26);
            this.txbDBIP.TabIndex = 0;
            this.txbDBIP.TextChanged += new System.EventHandler(this.txbDBIP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "数据库地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(61, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(77, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "密码";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("宋体", 12F);
            this.btnTest.Location = new System.Drawing.Point(103, 232);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(105, 30);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSave.Location = new System.Drawing.Point(228, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbDBName
            // 
            this.txbDBName.Font = new System.Drawing.Font("宋体", 12F);
            this.txbDBName.Location = new System.Drawing.Point(125, 84);
            this.txbDBName.Name = "txbDBName";
            this.txbDBName.Size = new System.Drawing.Size(248, 26);
            this.txbDBName.TabIndex = 1;
            this.txbDBName.TextChanged += new System.EventHandler(this.txbDBIP_TextChanged);
            // 
            // txbUserName
            // 
            this.txbUserName.Font = new System.Drawing.Font("宋体", 12F);
            this.txbUserName.Location = new System.Drawing.Point(125, 131);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(248, 26);
            this.txbUserName.TabIndex = 2;
            this.txbUserName.TextChanged += new System.EventHandler(this.txbDBIP_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(29, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "数据库名称";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.txbPassword.Location = new System.Drawing.Point(125, 178);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(248, 26);
            this.txbPassword.TabIndex = 3;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbDBIP_TextChanged);
            // 
            // FDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 318);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.txbDBName);
            this.Controls.Add(this.txbDBIP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FDatabase";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "更新数据库配置";
            this.Load += new System.EventHandler(this.FDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDBIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbDBName;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbPassword;
    }
}