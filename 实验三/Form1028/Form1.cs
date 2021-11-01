using System;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1028
{
    public partial class Form1 : Form
    {
        public string show_text;
        Assembly assembly = Assembly.LoadFrom("ClassFile.dll");
        ArrayList list = new ArrayList();
        string method_info = "";
        Type type_info;
        Object obj;
        ArrayList typelist = new ArrayList();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            System.Console.SetOut(new Server_Frm.CSS.TextBoxWriter(operationtext));
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            //清空文本框的文本
            showtext.Clear();

            //利用文件询问获取文件名
            DialogResult dr = openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(filename))
            {
                //文件的打开和读取
                FileStream F = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                //读取流
                StreamReader sr = new StreamReader(F);


                while (sr.Peek() > -1)
                {
                    count++;
                    string str = sr.ReadLine();
                    Type type = assembly.GetType($"ns.{str}");
                    typelist.Add(type);
                    showtext.AppendText("文件中包含类：" + type + "\r\n");
                    FieldInfo[] fields = type.GetFields();
                    MethodInfo[] methods = type.GetMethods();

                    //创建类的实例
                    object obj = Activator.CreateInstance(type);
                    list.Add(obj);

                    //字段
                    if (fields.Length > 0)
                    {
                        showtext.AppendText($"{type}的字段有：\r\n");
                        foreach (FieldInfo field in fields)
                        {
                            showtext.AppendText("\t" + field + "\r\n");
                        }
                    }
                    else showtext.AppendText($"{type}中无字段\r\n");

                    //方法
                    if (methods.Length > 0)
                    {
                        showtext.AppendText($"{type}的方法有：\r\n");
                        for (int i = 0; i < methods.Length - 4; i++)
                        {
                            showtext.AppendText("\t" + methods[i] + "\r\n");
                        }
                        /*foreach (MethodInfo method in methods)
                        {
                            showtext.AppendText("\t" + method + "\r\n");
                        }*/
                    }
                    else showtext.AppendText($"{type}中无方法\r\n");
                    showtext.AppendText("\r\n");
                }
                show_text = showtext.Text;
                remindTextBox.Text = "请输入需要操作的类";
                showtext.AppendText("成功创建对象：");
                for (int i = 0; i < list.Count; i++)
                {
                    showtext.AppendText($"{list[i]}" + "  ");
                }
            }

            else MessageBox.Show("文件为空，请重新选择文件");
        }

        private void operationtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '\r')
            {
                string info = operationtext.Text;
                operationtext.Clear();
                try
                {
                    type_info = assembly.GetType($"ns.{info}");
                    MethodInfo[] methods = type_info.GetMethods();
                    obj = Activator.CreateInstance(type_info);
                    showtext.Clear();
                    if (methods.Length > 0)
                    {
                        showtext.AppendText($"{type_info}的方法有：\r\n");
                        for (int i = 0; i < methods.Length - 4; i++)
                        {
                            showtext.AppendText("\t" + methods[i] + "\r\n");
                        }
                        /*foreach (MethodInfo method in methods)
                        {
                            showtext.AppendText("\t" + method + "\r\n");
                        }*/
                    }
                    else showtext.AppendText($"{type_info}中无方法\r\n");
                    showtext.AppendText("\r\n");
                    remindTextBox.Text = "请输入方法的名称";
                    
                }
                catch
                {
                    MessageBox.Show("输入的类名不存在，请重新输入");
                }
            }
            else if (ch == ' ')
            {
                method_info = operationtext.Text;
                operationtext.Clear();
                try
                {
                    MethodInfo method = type_info.GetMethod(method_info);
                    method.Invoke(obj, null);
                    showtext.Text = show_text;
                    remindTextBox.Text = "请输入需要操作的类";
                }
                catch
                {
                    MessageBox.Show("输入的方法不存在，请重新输入");
                }
            }
        }

        private void randombutton_Click(object sender, EventArgs e)
        {
            TimeSpan ts = new DateTime() - new DateTime(1970, 1, 1);
            float hm = ts.Milliseconds;
            Random myrandom = new Random();
            int Num = myrandom.Next(0, count);
            type_info = (Type)typelist[Num];
            obj = Activator.CreateInstance(type_info);
            MethodInfo[] methods = type_info.GetMethods();
            operationtext.Clear();
            Num = myrandom.Next(0, methods.Length - 4);
            MethodInfo method = methods[Num];
            method.Invoke(obj, null);
        }
    }
}
