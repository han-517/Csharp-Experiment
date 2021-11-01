
namespace Form1028
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.showtext = new System.Windows.Forms.TextBox();
            this.operationtext = new System.Windows.Forms.TextBox();
            this.remindTextBox = new System.Windows.Forms.TextBox();
            this.randombutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.SystemColors.Menu;
            this.OpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OpenFile.ForeColor = System.Drawing.SystemColors.InfoText;
            this.OpenFile.Location = new System.Drawing.Point(0, 0);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(1036, 56);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "打开文件";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // showtext
            // 
            this.showtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showtext.Location = new System.Drawing.Point(0, 62);
            this.showtext.Margin = new System.Windows.Forms.Padding(5);
            this.showtext.Multiline = true;
            this.showtext.Name = "showtext";
            this.showtext.ReadOnly = true;
            this.showtext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.showtext.Size = new System.Drawing.Size(1036, 479);
            this.showtext.TabIndex = 1;
            // 
            // operationtext
            // 
            this.operationtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationtext.Location = new System.Drawing.Point(0, 595);
            this.operationtext.Margin = new System.Windows.Forms.Padding(5);
            this.operationtext.Multiline = true;
            this.operationtext.Name = "operationtext";
            this.operationtext.Size = new System.Drawing.Size(1036, 86);
            this.operationtext.TabIndex = 2;
            this.operationtext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.operationtext_KeyPress);
            // 
            // remindTextBox
            // 
            this.remindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.remindTextBox.Location = new System.Drawing.Point(0, 544);
            this.remindTextBox.Multiline = true;
            this.remindTextBox.Name = "remindTextBox";
            this.remindTextBox.ReadOnly = true;
            this.remindTextBox.Size = new System.Drawing.Size(940, 52);
            this.remindTextBox.TabIndex = 3;
            // 
            // randombutton
            // 
            this.randombutton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.randombutton.Location = new System.Drawing.Point(940, 544);
            this.randombutton.Name = "randombutton";
            this.randombutton.Size = new System.Drawing.Size(96, 52);
            this.randombutton.TabIndex = 4;
            this.randombutton.Text = "随机选取";
            this.randombutton.UseVisualStyleBackColor = true;
            this.randombutton.Click += new System.EventHandler(this.randombutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1036, 684);
            this.Controls.Add(this.randombutton);
            this.Controls.Add(this.remindTextBox);
            this.Controls.Add(this.operationtext);
            this.Controls.Add(this.showtext);
            this.Controls.Add(this.OpenFile);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "操作窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox showtext;
        private System.Windows.Forms.TextBox operationtext;
        private System.Windows.Forms.TextBox remindTextBox;
        private System.Windows.Forms.Button randombutton;
    }
}

