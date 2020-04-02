/*
写一个订单管理的控制台程序，能够实现
添加订单add、删除订单delete、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
提示：主要的类有Order（订单：有多个订单明细）、OrderItem（订单明细项），OrderService（订单服务：订单增删改查），
订单数据可以保存在OrderService中一个List中。
在Program里面可以调用OrderService的方法完成各种订单操作。
要求：
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderManagement
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public Order Orders { get; set; }

        public OrderService() { }
        public OrderService(List<Order> orders)
        {
            this.orders = orders;
            Orders = orders;
        }

        public void addOrder(Order order)
        {
            orders.Add(order);
        }

        public void deletaOrder(int ID)
        {
            int a = -1;
            int b = -1;
            foreach (Order order in orders)
            {
                a++;
                if (order.OrderID == ID)
                {
                    b = a;
                }
            }
            orders.RemoveAt(b);
        }

        public void modifyOrder(int ID,Order neworder)
        {
            int a = -1;
            int b = -1;
            foreach (Order order in orders)
            {
                a++;
                if (order.OrderID == ID)
                {
                    b = a;
                }
            }
            orders[b] = neworder;
        }

        public Order getOrder(int id)                                                      //按照订单号查询
        {
            var query = orders.Where(o => o.OrderID == id);
            Order order = (Order)query;
            return order;
        }

        public List<Order> querybyCustomer(String name)                              //按照客户名查询
        {
            var query = orders.Where(o => o.Guest == name).OrderBy(o => o.Sum);
            return query.ToList();
        }

        public List<Order> querybyProduct(String name)                               //按照商品名查询
        {
            var query = orders.Where(o =>
            {
                foreach (OrderItem orderItem in o.OrderItems)
                {
                    if (orderItem.Goods.Name == name)
                    {
                        return true;
                    }
                }
                return false;
            }).OrderBy(o => o.Sum);
            return query.ToList();
        }

        public void modifyOrder(Order order3)
        {
            throw new NotImplementedException();
        }

        public void showID()                                                          //输出订单编号
        {
            foreach (Order order in orders)
            {
                Console.Write(order.OrderID + " ");
            }
        }

        public void sort()                                                 //默认按照订单号排序
        {
            orders.Sort((p1, p2) => p1.OrderID - p2.OrderID);
        }

        public void Export(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fileStream = new FileStream("orders.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, orders);
            }

        }

        public void Import(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fileStream = new FileStream("orders.xml", FileMode.Open))
            {
                List<Order> temp = (List<Order>)xmlSerializer.Deserialize(fileStream);
                temp.ForEach(order => {
                    if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }

        }

    }

   
}
