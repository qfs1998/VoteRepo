namespace voting
{
    partial class ConnectForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeLable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.databaseIptextBox = new System.Windows.Forms.TextBox();
            this.adminButton = new System.Windows.Forms.Button();
            this.votebutton = new System.Windows.Forms.Button();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.accounttextBox = new System.Windows.Forms.TextBox();
            this.porttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connectbutton
            // 
            this.Connectbutton.Location = new System.Drawing.Point(469, 332);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(157, 83);
            this.Connectbutton.TabIndex = 5;
            this.Connectbutton.Text = "连接数据库";
            this.Connectbutton.UseVisualStyleBackColor = true;
            this.Connectbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "数据库连接状态";
            // 
            // TimeLable
            // 
            this.TimeLable.AutoSize = true;
            this.TimeLable.Location = new System.Drawing.Point(12, 22);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(39, 15);
            this.TimeLable.TabIndex = 7;
            this.TimeLable.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // databaseIptextBox
            // 
            this.databaseIptextBox.Location = new System.Drawing.Point(307, 134);
            this.databaseIptextBox.Name = "databaseIptextBox";
            this.databaseIptextBox.Size = new System.Drawing.Size(189, 25);
            this.databaseIptextBox.TabIndex = 0;
            this.databaseIptextBox.Text = "输入数据库ip";
            this.databaseIptextBox.Click += new System.EventHandler(this.databaseIptextBox_Click);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(307, 332);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(147, 83);
            this.adminButton.TabIndex = 4;
            this.adminButton.Text = "管理员";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // votebutton
            // 
            this.votebutton.Location = new System.Drawing.Point(641, 332);
            this.votebutton.Name = "votebutton";
            this.votebutton.Size = new System.Drawing.Size(147, 83);
            this.votebutton.TabIndex = 6;
            this.votebutton.Text = "投票";
            this.votebutton.UseVisualStyleBackColor = true;
            this.votebutton.Click += new System.EventHandler(this.votebutton_Click);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(306, 213);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(189, 25);
            this.passwordtextBox.TabIndex = 2;
            this.passwordtextBox.Text = "密码";
            this.passwordtextBox.Click += new System.EventHandler(this.passwordtextBox_Click);
            // 
            // accounttextBox
            // 
            this.accounttextBox.Location = new System.Drawing.Point(307, 165);
            this.accounttextBox.Name = "accounttextBox";
            this.accounttextBox.Size = new System.Drawing.Size(189, 25);
            this.accounttextBox.TabIndex = 1;
            this.accounttextBox.Text = "账号";
            this.accounttextBox.Click += new System.EventHandler(this.accounttextBox_Click);
            // 
            // porttextBox
            // 
            this.porttextBox.Location = new System.Drawing.Point(307, 253);
            this.porttextBox.Name = "porttextBox";
            this.porttextBox.Size = new System.Drawing.Size(189, 25);
            this.porttextBox.TabIndex = 3;
            this.porttextBox.Text = "端口号";
            this.porttextBox.Click += new System.EventHandler(this.porttextBox_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.porttextBox);
            this.Controls.Add(this.accounttextBox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.votebutton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.databaseIptextBox);
            this.Controls.Add(this.TimeLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connectbutton);
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "连接数据库";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox databaseIptextBox;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button votebutton;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox accounttextBox;
        private System.Windows.Forms.TextBox porttextBox;
    }
}

