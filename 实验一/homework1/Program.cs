using System;

namespace homework1
{
    public class CQueue
    {
        private int[] data; //用于储存队列数据的数组
        private int maxsize; //队列所能储存元素的最大容量
        private int front; //队头元素的位置索引
        private int rear; //队尾元素的位置索引
        private uint length;

        public CQueue(int size)  //构造函数,队列的初始化
        {
            data = new int[size];
            maxsize = size;
            front = rear = 0;
            length = 0;
        }

        public void Clear() //清空该队列
        {
            front = rear = 0;
            length = 0;
        }

        public bool Empty() //若队列为空，则返回1，否则返回0
        {
            if(front == rear) return true;
            else return false;
        }

        public uint Length() //返回队列长度
        {
            return length;
        }

        public int GetHead() //若队列不空则返回头元素
        {
            if(Empty())
            {
                Console.WriteLine("队列为空，请添加元素");
                return -1;
            }
            else return data[front];
            
        }

        public void Print() //打印队列中内容
        {
            int i = front;
            while(i != rear)
            {
                Console.WriteLine(data[i]);
                i = (i + 1) % maxsize;
            }
        }

        public void Put(int item) //向队尾插入元素
        {
            if(Length() == maxsize)
            {
                Console.WriteLine("队列已满，无法添加元素");
                return;
            }
            data[rear] = item;
            rear = (rear + 1) % maxsize;
            length++;
        }

        public int Poll() //若队列不空则返回并删除队头元素
        {
            if(Empty())
            {
                Console.WriteLine("队列为空，请添加元素");
                return -1;
            }
            else
            {
                int tmp = front;
                front = (front + 1) % maxsize;
                length--;
                return data[tmp];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CQueue cque = new CQueue(1000); //请在括号内输入队列的大小
            //输入队列的相关操作
            


            
        }
    }

}
