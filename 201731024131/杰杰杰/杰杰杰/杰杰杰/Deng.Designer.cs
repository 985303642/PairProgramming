namespace WindowsFormsApp
{
    partial class Deng
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.denglu = new System.Windows.Forms.Button();
            this.quxiao = new System.Windows.Forms.Button();
            this.textZH = new System.Windows.Forms.TextBox();
            this.textMM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // denglu
            // 
            this.denglu.Location = new System.Drawing.Point(35, 126);
            this.denglu.Name = "denglu";
            this.denglu.Size = new System.Drawing.Size(73, 24);
            this.denglu.TabIndex = 2;
            this.denglu.Text = "登录";
            this.denglu.UseVisualStyleBackColor = true;
            this.denglu.Click += new System.EventHandler(this.button1_Click);
            // 
            // quxiao
            // 
            this.quxiao.Location = new System.Drawing.Point(137, 126);
            this.quxiao.Name = "quxiao";
            this.quxiao.Size = new System.Drawing.Size(70, 24);
            this.quxiao.TabIndex = 3;
            this.quxiao.Text = "取消";
            this.quxiao.UseVisualStyleBackColor = true;
            this.quxiao.Click += new System.EventHandler(this.button2_Click);
            // 
            // textZH
            // 
            this.textZH.Location = new System.Drawing.Point(80, 28);
            this.textZH.Name = "textZH";
            this.textZH.Size = new System.Drawing.Size(127, 21);
            this.textZH.TabIndex = 4;
            // 
            // textMM
            // 
            this.textMM.Location = new System.Drawing.Point(80, 65);
            this.textMM.Name = "textMM";
            this.textMM.Size = new System.Drawing.Size(126, 21);
            this.textMM.TabIndex = 5;
            // 
            // Deng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 187);
            this.Controls.Add(this.textMM);
            this.Controls.Add(this.textZH);
            this.Controls.Add(this.quxiao);
            this.Controls.Add(this.denglu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Deng";
            this.Text = "Deng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button denglu;
        private System.Windows.Forms.Button quxiao;
        private System.Windows.Forms.TextBox textZH;
        private System.Windows.Forms.TextBox textMM;
    }
}