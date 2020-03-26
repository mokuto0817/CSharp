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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods product1 = new Goods("apple", 10);                                          //测试数据
            Goods product2 = new Goods("banana", 12);
            Goods product3 = new Goods("chocolate",15);
            Goods product4 = new Goods("cookie", 20);
            Goods product5 = new Goods("ice cream", 25);

            OrderItem orderItem1 = new OrderItem(product1, 1);
            OrderItem orderItem2 = new OrderItem(product2, 1);
            OrderItem orderItem3 = new OrderItem(product4, 2);
            OrderItem orderItem4 = new OrderItem(product3, 5);
            OrderItem orderItem5 = new OrderItem(product5, 1);


            OrderItem[] orderItems1 = { orderItem1, orderItem4 };
            OrderItem[] orderItems2 = { orderItem5, orderItem3 };
            OrderItem[] orderItems3 = { orderItem2, orderItem3, orderItem5, orderItem1 };
            OrderItem[] orderItems4 = { orderItem5, orderItem3, orderItem1 };

            Order order1 = new Order(001, "annie", orderItems1);
            order1.calSum();
            Order order2 = new Order(002, "Tim", orderItems2);
            order2.calSum();
            Order order3 = new Order(003, "Tom", orderItems3);
            order3.calSum();
            Order order4 = new Order(004, "Bob", orderItems4);
            order4.calSum();

            OrderService orderService = new OrderService();
            orderService.addOrder(order2);
            orderService.addOrder(order1);
            orderService.addOrder(order3);
            orderService.addOrder(order4);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine();
            Console.Write("默认排序后的订单编号序列: ");
            orderService.sort();
            orderService.showID();
            Console.WriteLine();
            Console.WriteLine("删除订单编号为004的订单");
            orderService.deletaOrder(004);
            Console.Write("当前保存的订单编号序列: ");
            orderService.showID();
            Console.WriteLine("\n");
            Console.WriteLine("查询Tom的订单");
            List<Order> porders = orderService.querybyCustomer("Tom");
            foreach (Order order in porders)
            {
                Console.Write(order);
            }
            Console.WriteLine("\n查询购买了chocolate的订单");
            List<Order> aorders = orderService.querybyProduct("chocolate");
            foreach (Order order in aorders)
            {
                Console.Write(order);
            }
        }
    }

    public class Order
    {
        private int orderID;
        private string guest;
        private OrderItem[] orderItems;
        private int sum;

        public int OrderID { get => orderID; set => orderID = value; }
        public string Guest { get => guest; set => guest = value; }
        public OrderItem[] OrderItems { get => orderItems; set => orderItems = value; }
        public int Sum { get => sum; set => sum = value; }

        public Order() { }
        public Order(int orderID, string guest, OrderItem[] orderItems)
        {
            this.orderID = orderID;
            this.guest = guest;
            this.orderItems = orderItems;
            OrderID = orderID;
            Guest = guest;
            OrderItems = orderItems;
        }

        public void calSum()
        {
            foreach (OrderItem orderItem in orderItems)
            {
                sum += (orderItem.Goods.Price) * (orderItem.Num);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   orderID == order.orderID
                   && EqualityComparer<OrderItem[]>.Default.Equals(orderItems, order.orderItems)
                   && sum == order.sum && OrderID == order.OrderID && Sum == order.Sum
                   && EqualityComparer<OrderItem[]>.Default.Equals(OrderItems, order.OrderItems);
        }

        public override int GetHashCode()
        {
            var hashCode = -1604615000;
            hashCode = hashCode * -1521134295 + orderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<OrderItem[]>.Default.GetHashCode(orderItems);
            hashCode = hashCode * -1521134295 + sum.GetHashCode();
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + Sum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<OrderItem[]>.Default.GetHashCode(OrderItems);
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder details = new StringBuilder();
            foreach (OrderItem orderItem in orderItems)
            {
                details.Append(orderItem.ToString());
            }
            return "\n" + "Order ID:" + orderID + "Guest Name:" + guest + "The sum:" + sum + details;
        }

        public static implicit operator Order(List<Order> v)
        {
            throw new NotImplementedException();
        }
    }

    public class OrderItem
    {
        private Goods goods;
        private int num;

        public Goods Goods { get => goods; set => goods = value; }
        public int Num { get => num; set => num = value; }

        public OrderItem() { }
        public OrderItem(Goods goods, int num)
        {
            this.goods = goods;
            this.num = num;
            Goods = goods;
            Num = num;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderItem item && EqualityComparer<Goods>.Default.Equals(goods, item.goods) && num == item.num;
        }

        public override int GetHashCode()
        {
            var hashCode = -502671570;
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(goods);
            hashCode = hashCode * -1521134295 + num.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(Goods);
            hashCode = hashCode * -1521134295 + Num.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "\n" + "Goods:" + goods.Name + "\n" + "Price:" + goods.Price + "\n" + "The num:" + Num;
        }
    }

    public class Goods
    {
        private string name;
        private int price;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }

        public Goods() { }
        public Goods(String name, int price)
        {
            this.name = name;
            this.price = price;
            name = Name;
            price = Price;
        }

        public override string ToString()
        {
            return "Name:" + Name + "Price:" + Price;
        }
    }

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


    }

   
}
