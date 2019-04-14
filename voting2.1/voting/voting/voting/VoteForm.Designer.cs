namespace voting
{
    partial class VoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoteForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.votebutton = new System.Windows.Forms.Button();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.SelectiontextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.haveVotedbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(724, 435);
            this.dataGridView1.TabIndex = 0;
            // 
            // votebutton
            // 
            this.votebutton.Location = new System.Drawing.Point(791, 319);
            this.votebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.votebutton.Name = "votebutton";
            this.votebutton.Size = new System.Drawing.Size(94, 49);
            this.votebutton.TabIndex = 1;
            this.votebutton.Text = "投票";
            this.votebutton.UseVisualStyleBackColor = true;
            this.votebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(778, 273);
            this.IDtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(44, 21);
            this.IDtextBox.TabIndex = 2;
            // 
            // SelectiontextBox
            // 
            this.SelectiontextBox.Location = new System.Drawing.Point(852, 273);
            this.SelectiontextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectiontextBox.Name = "SelectiontextBox";
            this.SelectiontextBox.Size = new System.Drawing.Size(44, 21);
            this.SelectiontextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "选项";
            // 
            // haveVotedbutton
            // 
            this.haveVotedbutton.Location = new System.Drawing.Point(791, 99);
            this.haveVotedbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.haveVotedbutton.Name = "haveVotedbutton";
            this.haveVotedbutton.Size = new System.Drawing.Size(94, 49);
            this.haveVotedbutton.TabIndex = 6;
            this.haveVotedbutton.Text = "已投的项目";
            this.haveVotedbutton.UseVisualStyleBackColor = true;
            this.haveVotedbutton.Click += new System.EventHandler(this.haveVotedbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F);
            this.label3.Location = new System.Drawing.Point(737, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "只有投票过的选项才可以看见票数哦\r\n每人每项只能投票一次哦";
            // 
            // VoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(945, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.haveVotedbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectiontextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.votebutton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "投票页面";
            this.Load += new System.EventHandler(this.VoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button votebutton;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox SelectiontextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button haveVotedbutton;
        private System.Windows.Forms.Label label3;
    }
}