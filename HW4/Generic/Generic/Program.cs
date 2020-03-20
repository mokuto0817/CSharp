﻿using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            //打印链表元素
            intlist.ForEach(x => Console.WriteLine(x));
            //求最大值
            int max = int.MinValue;
            intlist.ForEach(x => { if (max < x) max = x;});
            Console.WriteLine("The max value is :{0}", max);
            //求最小值
            int min = int.MaxValue;
            intlist.ForEach(x => { if (min > x) min = x; });
            Console.WriteLine("The min value is :{0}", min);
            //求和
            int sum = 0;
            intlist.ForEach(x => { sum += x; });
            Console.WriteLine("Thesum is :{0}", sum);




            // 字符串型List
            GenericList<string> strList = new GenericList<string>();
            for (int x = 0; x < 10; x++)
            {
                strList.Add("str" + x);
            }
            for (Node<string> node = strList.Head;
                    node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }
        }

        // 链表节点
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }

            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }

        //泛型链表类
        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;

            public GenericList()
            {
                tail = head = null;
            }

            public Node<T> Head
            {
                get => head;
            }

            public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }

            public void ForEach(Action<T> action)
            {
                Node<T> node = this.head;
                while (node != null)
                {
                    action(node.Data);
                    node = node.Next;
                }
            }
        }
    }
}
