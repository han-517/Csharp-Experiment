using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            //获取打开文件的文件名
            string filename = openFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                richTextBoxNote.LoadFile(filename, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            //获取所保存文件的文件名
            string filename = saveFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                richTextBoxNote.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
        }

        private void toolStripButtonFont_Click(object sender, EventArgs e)
        {
            //显示字体对话框
            DialogResult dr = fontDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮，则更改文本框中的字体
            if (dr == DialogResult.OK)
            {
                richTextBoxNote.Font = fontDialog1.Font;
            }
        }

        private void toolStripButtonColor_Click(object sender, EventArgs e)
        {
            //显示颜色对话框
            DialogResult dr = colorDialog1.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
                richTextBoxNote.ForeColor = colorDialog1.Color;
            }
        }
    }
}
