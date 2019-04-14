namespace voting
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.accounttextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accounttextBox
            // 
            this.accounttextBox.Location = new System.Drawing.Point(387, 179);
            this.accounttextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accounttextBox.Multiline = true;
            this.accounttextBox.Name = "accounttextBox";
            this.accounttextBox.Size = new System.Drawing.Size(116, 17);
            this.accounttextBox.TabIndex = 0;
            this.accounttextBox.Text = "账户";
            this.accounttextBox.TextChanged += new System.EventHandler(this.accounttextBox_TextChanged);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(387, 215);
            this.passwordtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordtextBox.Multiline = true;
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(116, 17);
            this.passwordtextBox.TabIndex = 1;
            this.passwordtextBox.Text = "密码";
            this.passwordtextBox.Click += new System.EventHandler(this.passwordtextBox_Click);
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(416, 254);
            this.Loginbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(61, 24);
            this.Loginbutton.TabIndex = 2;
            this.Loginbutton.Text = "登录";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(895, 394);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.accounttextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accounttextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Button Loginbutton;
    }
}