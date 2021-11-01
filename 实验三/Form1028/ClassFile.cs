using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace ns
{
    class _class1
    {
        public int field1, field2;
        public void class1_m1()
        {
            Console.WriteLine("This is Class1 Method1");
        }
        
        public void class1_m2()
        {
            Console.WriteLine("This is Class1 Method2");
        }
        
        public void class1_m3()
        {
            Console.WriteLine("This is Class1 Method3");
        }
    }
    
    class _class2
    {
        public void class2_m1()
        {
            Console.WriteLine("This is Class2 Method1");
        }
        public void class2_m2()
        {
            Console.WriteLine("This is Class2 Method2");
        }
        public void class2_m3()
        {
            Console.WriteLine("This is Class2 Method3");
        }
    }
    
    class Program
    {
        /*public T Creatinst<T>(Type type)
        {
            object obj = Activator.CreateInstance(type, true);
            return (T) obj;
        }*/

        /*static void Main(string[] args)
        {
            //创建初始化实例的数组
            ArrayList list = new ArrayList();
            
            //文件的打开和读取
            FileStream F = File.Open("components.txt",FileMode.Open,FileAccess.Read,FileShare.Read);
            //读取流
            StreamReader sr = new StreamReader(F);

            //创建一个字符串来储存每一个类名
            String str;
            
            //获取当前程序集
            Assembly assembly = Assembly.GetExecutingAssembly();
            
            
            //读取文件内所有的类名
            while (sr.Peek() > -1)
            {
                str = sr.ReadLine();
                //gettype方法内需要加上类名的命名空间和类名（注意参数为字符串类型）
                Type type = Type.GetType($"ns.{str}");
                Console.WriteLine("\ncomponents文件中包含类：" + type);
                
                //创建类的实例
                object obj = Activator.CreateInstance(type);
                list.Add(obj);
                
                //反射出类中所有的成员（字段和方法）
                FieldInfo[] fields = type.GetFields();
                MethodInfo[] methods = type.GetMethods();
                
                //字段
                if (fields.Length > 0)
                {
                    Console.WriteLine($"{type}的字段有：");
                    foreach (FieldInfo field in fields)
                    {
                        Console.WriteLine("\t" + field);
                    }
                }
                else Console.WriteLine($"{type}中无字段");
                
                //方法
                if (methods.Length > 0)
                {
                    Console.WriteLine($"{type}的方法有：");
                    foreach (MethodInfo method in methods)
                    {
                        Console.WriteLine("\t" + method);
                    }
                }
                else Console.WriteLine($"{type}中无方法");
            }
        }*/
    }
}