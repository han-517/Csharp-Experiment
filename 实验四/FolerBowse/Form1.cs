using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FolerBowse
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            this.treeView1.Font = new Font("Roman",12,FontStyle.Regular);
            this.treeView1.BackColor = Color.White;
            this.treeView1.ForeColor = Color.Black;
            this.treeView1.ImageList = imageList1;
            treeView1.ContextMenu = null;
               
            
            this.listView1.GridLines = true;
            listView1.LabelEdit = true;
            this.listView1.View = View.Details;
            this.listView1.SmallImageList = imageList1;
            listView1.LargeImageList = imageLarge;
            listView1.FullRowSelect = true;

            

            ColumnHeader header1, header2, header3;

            listView1.BeginUpdate();
            header1 = new ColumnHeader();
            header1.Text = "名称";
            header1.Width = listView1.Width / 3;
            listView1.Columns.Add(header1);

            header2 = new ColumnHeader();
            header2.Text = "类型";
            header2.Width = header1.Width;
            listView1.Columns.Add(header2);

            header3 = new ColumnHeader();
            header3.Text = "上次修改";
            header3.Width = header1.Width;
            listView1.Columns.Add(header3);

            listView1.EndUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnumAllDrives();
        }
        //枚举出所有磁盘
        private void EnumAllDrives()
        {

            foreach(string  MyDrive in Directory.GetLogicalDrives())
            {
                    TreeNode RootNode = new TreeNode();
                   
                    RootNode.Text = MyDrive.Substring(0,MyDrive.Length-1);
                    RootNode.Tag =MyDrive;
                    RootNode.ImageIndex = 0;
                    RootNode.ForeColor = Color.Black;
                    treeView1.Nodes.Add(RootNode);

            }

 

        }
        //枚举出所有文件夹
        private void EnumAllFile(TreeNode ParNode)
        {
            string path = ParNode.Tag.ToString();

            if (path.Substring(path.Length-1)!=@"\")
            {
                path+=@"\";
            }
          
            if (ParNode.Nodes.Count!=0)//判断当前选中节点是否已有子目录
            {
                return;
            }
            try
            {
                string[] Folders = Directory.GetDirectories(path);

                if (Folders.Length==0)
                {
                 
                    return;
                }

                treeView1.BeginUpdate();
                TreeNode SubNode;

                foreach (string MyFolder in Folders)
                {
                    SubNode= new TreeNode();
                    SubNode.Text = MyFolder.Substring(path.LastIndexOf(@"\") + 1);//取得文件名，不包含路径
                    SubNode.ImageIndex = 2;
                    SubNode.SelectedImageIndex = 1;
                    SubNode.Tag = MyFolder;//将路径名作为数据对象
                    ParNode.Nodes.Add(SubNode);  
                }
                treeView1.Select();
                treeView1.EndUpdate();
            }
            catch (System.Exception e)
            {
                MessageBox.Show("拒绝访问！");
                e.ToString();
            }

        }
        //节点选择事件
        private void select(object sender, TreeNodeMouseClickEventArgs e)
        {
             EnumAllFile(e.Node);
        }

        //节点双击事件
        private void Show_File(object sender, TreeNodeMouseClickEventArgs e)
        {

            TreeNode newSelected = e.Node;

                listView1.Items.Clear();

                DirectoryInfo nodeDirInfo =new DirectoryInfo(newSelected.Tag.ToString());

                ListViewItem item = null;
              
             try
             {
                 listView1.BeginUpdate();
                 foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                 {

                     item = new ListViewItem(dir.Name);
                     item.ImageIndex = 2;
                     item.SubItems.Add("Directory");
                     item.SubItems.Add(dir.LastAccessTime.ToShortDateString());
                     listView1.Items.Add(item);
                 }
                 foreach (FileInfo file in nodeDirInfo.GetFiles())
                 {
                     item = new ListViewItem(file.Name);
                     item.SubItems.Add("File");
                     item.SubItems.Add(file.LastAccessTime.ToShortDateString());
                     item.ImageIndex = 3;
                     listView1.Items.Add(item);
                 }
             
             }
            //无权限访问
             catch (System.Exception Ex)
             {
                 Ex.ToString();
                MessageBox.Show("拒绝访问！");
             }
           
               listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
              listView1.EndUpdate();
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void 详细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode SelectNode = treeView1.SelectedNode;
            string path = SelectNode.Tag.ToString();
         //   Directory.Delete(path,true);
            treeView1.Nodes.Remove(SelectNode);
        }

   
    }
}