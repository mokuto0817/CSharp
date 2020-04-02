using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.IO;

namespace OrderManagemant.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService service = new OrderService();

        OrderItem[] orderItems1 = { new OrderItem(new Goods("apple", 10), 1), new OrderItem(new Goods("chocolate", 15), 5) };
        OrderItem[] orderItems2 = { new OrderItem(new Goods("ice cream", 25), 1), new OrderItem(new Goods("chocolate", 15), 5) };
        OrderItem[] orderItems3 = { new OrderItem(new Goods("banana", 12), 1), new OrderItem(new Goods("chocolate", 15), 5), new OrderItem(new Goods("ice cream", 25), 1), new OrderItem(new Goods("apple", 10), 1) };
        OrderItem[] orderItems4 = { new OrderItem(new Goods("ice cream", 25), 1), new OrderItem(new Goods("chocolate", 15), 5), new OrderItem(new Goods("apple", 10), 1) };

        [TestInitialize()]
        public void init()
        {
            Order order1 = new Order(1, "Customer1", orderItems1);
            Order order2 = new Order(2, "Customer2", orderItems2);
            Order order3 = new Order(3, "Customer2", orderItems3);
            service = new OrderService();
            service.addOrder(order1);
            service.addOrder(order2);
            service.addOrder(order3);
        }


        [TestMethod()]
        public void AddOrderTest()
        {
            Order order4 = new Order(4, "Customer2", orderItems2);
            service.addOrder(order4);
            Assert.AreEqual(4, service.Orders.Count);
            CollectionAssert.Contains(service.Orders, order4);
        }


        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void AddOrderTest2()
        {
            Order order4 = new Order(3, "Customer2", orderItems3);
            service.addOrder(order4);
        }


        [TestMethod()]
        public void RemoveOrderTest()
        {
            service.deletaOrder(3);
            Assert.AreEqual(2, service.Orders.Count);
            service.deletaOrder(100);
            Assert.AreEqual(2, service.Orders.Count);
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            Order order3 = new Order(3, "Customer5", orderItems4);
            service.modifyOrder(order3);
            Assert.AreEqual(3, service.Orders.Count);
            Order o = service.getOrder(3);
            Assert.AreEqual("Customer5", o.Guest);
        }


        [TestMethod()]
        public void QueryOrderByIdTest()
        {
            Order order2 = new Order(2, "Customer2", orderItems1);
            Order o = service.getOrder(2);
            Assert.IsNotNull(o);
            Assert.AreEqual(order2, o);
            o = service.getOrder(4);
            Assert.IsNull(o);
        }

        [TestMethod()]
        public void QueryOrdersByGoodsNameTest()
        {
            Assert.AreEqual(2, service.QueryOrdersByGoodsName("apple").Count);
            Assert.AreEqual(2, service.QueryOrdersByGoodsName("egg").Count);
            Assert.AreEqual(3, service.QueryOrdersByGoodsName("milk").Count);
            Assert.AreEqual(0, service.QueryOrdersByGoodsName("orange").Count);
        }

        [TestMethod()]
        public void QueryOrdersByCustomerNameTest()
        {
            Assert.AreEqual(1, service.QueryOrdersByCustomerName("Customer1").Count);
            Assert.AreEqual(2, service.QueryOrdersByCustomerName("Customer2").Count);
            Assert.AreEqual(0, service.QueryOrdersByCustomerName("Customer3").Count);
        }

        [TestMethod()]
        public void ExportTest()
        {
            String file = "temp.xml";
            service.Export(file);
            Assert.IsTrue(File.Exists(file));
            List<String> expectLines = File.ReadLines("expectedOrders.xml").ToList();
            List<String> outputLines = File.ReadLines(file).ToList();
            Assert.AreEqual(expectLines.Count, outputLines.Count);
            for (int i = 0; i < expectLines.Count; i++)
            {
                Assert.AreEqual(expectLines[i].Trim(), outputLines[i].Trim());
            }

        }

        [TestMethod()]
        public void ImportTest1()
        {
            OrderService os = new OrderService();
            os.Import("./expectedOrders.xml");
            Assert.AreEqual(3, os.Orders.Count);

            os.Import("./newOrders.xml");
            Assert.AreEqual(5, os.Orders.Count);
        }


        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void ImportTest3()
        {
            OrderService os = new OrderService();
            os.Import("./ordersNotExist.xml");
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ImportTest4()
        {
            OrderService os = new OrderService();
            os.Import("./ordersErrorContain.xml");
        }

    }

}
