﻿/*
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

namespace OrderManagement
{
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

   
}
